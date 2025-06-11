using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FormThanhToan : Form
    {
        int idBan;
        int idGoiMon;
        private DataTable dtMonDaGoi;
        private void LoadPhuongThucThanhToan()
        {
            comboBox1.Items.AddRange(new string[] { "Tiền mặt", "Chuyển khoản", "QR Code" });
        }
        private void TinhTongTien()
        {
            int tongTien = 0;

            foreach (DataRow row in dtMonDaGoi.Rows)
            {
                if (row["Thanh_tien"] != DBNull.Value)
                {
                    tongTien += Convert.ToInt32(row["Thanh_tien"]);
                }
            }

            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ"; // hiển thị có dấu chấm phân cách
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();

                // Lấy id_goi_mon mới nhất cho bàn này
                string query1 = "SELECT TOP 1 id_goi_mon FROM Goimon WHERE id_ban = @idBan ORDER BY Ngay_goi_mon DESC";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@idBan", idBan);
                object result = cmd1.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Bàn này chưa có món được gọi.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                idGoiMon = Convert.ToInt32(result);

                // Load danh sách món đã gọi
                string query2 = @"
                SELECT ctgm.id_mon_an, td.Ten_mon_an, ctgm.So_luong, td.Don_gia, (td.Don_gia * ctgm.So_luong) AS Thanh_tien
                FROM CTGoimon ctgm
                JOIN ThucDon td ON ctgm.id_mon_an = td.id_mon_an
                WHERE ctgm.id_goi_mon = @idGoiMon";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@idGoiMon", idGoiMon);

                dtMonDaGoi = new DataTable();
                adapter.Fill(dtMonDaGoi);
                dataGridView1.DataSource = dtMonDaGoi;
                dataGridView1.Columns[0].HeaderText = "id món ăn";
                dataGridView1.Columns[1].HeaderText = "Tên món ăn";
                dataGridView1.Columns[2].HeaderText = "Số lượng";
                dataGridView1.Columns[3].HeaderText = "Đơn giá";
                dataGridView1.Columns[4].HeaderText = "Thành tiền";
                TinhTongTien(); // Gọi hàm tính tổng tiền
            }
        }


        public FormThanhToan(int idBan)
        {
            InitializeComponent();
            this.idBan = idBan;
            LoadData();
            LoadPhuongThucThanhToan();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {

        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtMonDaGoi == null || dtMonDaGoi.Rows.Count == 0)
            {
                MessageBox.Show("Không có món ăn để thanh toán.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int tongTien = dtMonDaGoi.AsEnumerable().Sum(row => row.Field<int>("Thanh_tien"));

            using (SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Thêm Hóa Đơn
                    string insertHD = "INSERT INTO HoaDon (id_goi_mon, Thanh_tien) OUTPUT INSERTED.id_hoa_don VALUES (@idGoiMon, @tongTien)";
                    SqlCommand cmdHD = new SqlCommand(insertHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@idGoiMon", idGoiMon);
                    cmdHD.Parameters.AddWithValue("@tongTien", tongTien);
                    int idHoaDon = (int)cmdHD.ExecuteScalar();

                    // Thêm CT Hóa Đơn
                    foreach (DataRow row in dtMonDaGoi.Rows)
                    {
                        string insertCT = @"INSERT INTO CTHoaDon (id_hoa_don, id_mon_an, So_luong, Don_gia)
                                    VALUES (@idHD, @idMon, @sl, @dg)";
                        SqlCommand cmdCT = new SqlCommand(insertCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@idHD", idHoaDon);
                        cmdCT.Parameters.AddWithValue("@idMon", row["id_mon_an"]);
                        cmdCT.Parameters.AddWithValue("@sl", row["So_luong"]);
                        cmdCT.Parameters.AddWithValue("@dg", row["Don_gia"]);
                        cmdCT.ExecuteNonQuery();
                    }

                    // Cập nhật trạng thái bàn: giả sử có cột Trang_thai trong bảng BanAn
                    string updateBan = "UPDATE BanAn SET Trang_thai = N'Trống' WHERE id_ban = @idBan";
                    SqlCommand cmdBan = new SqlCommand(updateBan, conn, tran);
                    cmdBan.Parameters.AddWithValue("@idBan", idBan);
                    cmdBan.ExecuteNonQuery();
                    // Cộng tiền vào ví sau khi khách thanh toán
                    string updateVi = "UPDATE ViTien SET SoDu = SoDu + @soTien";
                    SqlCommand cmdVi = new SqlCommand(updateVi, conn, tran);
                    cmdVi.Parameters.AddWithValue("@soTien", tongTien);
                    cmdVi.ExecuteNonQuery();
                    // Ghi lịch sử giao dịch - Thu
                    string insertLog = @"INSERT INTO LichSuGiaoDich (So_tien, Loai_giao_dich, Mo_ta)
                    VALUES (@tien, N'Thu', @mota)";
                    SqlCommand cmdLog = new SqlCommand(insertLog, conn, tran);
                    cmdLog.Parameters.AddWithValue("@tien", tongTien);
                    cmdLog.Parameters.AddWithValue("@mota", "Khách thanh toán hóa đơn #" + idHoaDon);
                    cmdLog.ExecuteNonQuery();


                    tran.Commit();
                    MessageBox.Show("Thanh toán thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IdSearch id = new IdSearch();
            id.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTenMon.Text = row.Cells["Ten_mon_an"].Value.ToString();
                txtSoLuong.Text = row.Cells["So_luong"].Value.ToString();
                txtDonGia.Text = row.Cells["Don_gia"].Value.ToString();
                txtThanhTien.Text = row.Cells["Thanh_tien"].Value.ToString();
            }
        }
    }
}
