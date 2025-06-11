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
    public partial class formNhapHang : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True");
        public formNhapHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // Load nguyên liệu
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM NguyenLieu", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvNguyenLieu.DataSource = dt1;
            dgvNguyenLieu.Columns["id_nguyen_lieu"].Visible = false;
            dgvNguyenLieu.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns[2].HeaderText = "Đơn vị tính";
            dgvNguyenLieu.Columns[3].HeaderText = "Đơn giá";
            dgvNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Load nhà cung cấp
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT Ten_nha_cung_cap, Dia_chi FROM NhaCungCap", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvNhaCungCap.DataSource = dt2;
            dgvNhaCungCap.Columns[0].HeaderText = "Tên nhà cung cấp";
            dgvNhaCungCap.Columns[1].HeaderText = "Địa chỉ";
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load tồn kho
            SqlDataAdapter da3 = new SqlDataAdapter("select Ten_nguyen_lieu, So_luong_ton, TonKho.Don_vi_tinh from NguyenLieu\r\n\tjoin TonKho on NguyenLieu.id_nguyen_lieu = TonKho.id_nguyen_lieu", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvKho.DataSource = dt3;
            dgvKho.Columns[0].HeaderText = "Tên nguyên liệu";
            dgvKho.Columns[1].HeaderText = "Số lượng";
            dgvKho.Columns[2].HeaderText = "Đơn vị tính";
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void formNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNhaCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["Ten_nha_cung_cap"].Value.ToString();
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["Ten_nguyen_lieu"].Value.ToString();
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Lấy số dư hiện tại
                string getSoDuQuery = "SELECT SoDu FROM ViTien";
                SqlCommand cmdSoDu = new SqlCommand(getSoDuQuery, conn);
                int soDuHienTai = Convert.ToInt32(cmdSoDu.ExecuteScalar());

                // Lấy ID nhà cung cấp
                string query1 = "SELECT id_nha_cung_cap FROM NhaCungCap WHERE Ten_nha_cung_cap = @tenNCC";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@tenNCC", txtNhaCC.Text);
                int idNCC = (int)cmd1.ExecuteScalar();

                // Lấy ID nguyên liệu
                string query2 = "SELECT id_nguyen_lieu, Don_gia FROM NguyenLieu WHERE Ten_nguyen_lieu = @tenNL";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@tenNL", txtNguyenLieu.Text);
                SqlDataReader reader = cmd2.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Không tìm thấy nguyên liệu.");
                    return;
                }

                int idNL = (int)reader["id_nguyen_lieu"];
                int donGia = (int)reader["Don_gia"];
                reader.Close();

                int soLuongNhap = int.Parse(txtSoLuong.Text);
                int tongTienNhap = donGia * soLuongNhap;

                // Kiểm tra số dư
                if (tongTienNhap > soDuHienTai)
                {
                    MessageBox.Show("Số dư ví không đủ để nhập hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Giao dịch bắt đầu
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Thêm vào bảng Phiếu Nhập
                    string insertPhieu = "INSERT INTO PhieuNhap(id_nha_cung_cap) VALUES(@idNCC); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdPhieu = new SqlCommand(insertPhieu, conn, tran);
                    cmdPhieu.Parameters.AddWithValue("@idNCC", idNCC);
                    int idPhieuNhap = Convert.ToInt32(cmdPhieu.ExecuteScalar());

                    // Thêm vào Chi tiết phiếu nhập
                    string insertCT = "INSERT INTO CTPhieuNhap(id_phieu_nhap, id_nguyen_lieu, So_luong) VALUES(@idPhieu, @idNL, @soLuong)";
                    SqlCommand cmdCT = new SqlCommand(insertCT, conn, tran);
                    cmdCT.Parameters.AddWithValue("@idPhieu", idPhieuNhap);
                    cmdCT.Parameters.AddWithValue("@idNL", idNL);
                    cmdCT.Parameters.AddWithValue("@soLuong", soLuongNhap);
                    cmdCT.ExecuteNonQuery();

                    // Trừ tiền từ ví
                    string updateVi = "UPDATE ViTien SET SoDu = SoDu - @tienTru";
                    SqlCommand cmdUpdateVi = new SqlCommand(updateVi, conn, tran);
                    cmdUpdateVi.Parameters.AddWithValue("@tienTru", tongTienNhap);
                    cmdUpdateVi.ExecuteNonQuery();
                    // Ghi lịch sử giao dịch - Chi
                    string insertLog = @"INSERT INTO LichSuGiaoDich (So_tien, Loai_giao_dich, Mo_ta)
                    VALUES (@tien, N'Chi', @mota)";
                    SqlCommand cmdLog = new SqlCommand(insertLog, conn, tran);
                    cmdLog.Parameters.AddWithValue("@tien", tongTienNhap);
                    cmdLog.Parameters.AddWithValue("@mota", "Nhập hàng từ NCC: " + txtNhaCC.Text);
                    cmdLog.ExecuteNonQuery();


                    tran.Commit();
                    MessageBox.Show("Nhập hàng thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi nhập hàng: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            this.Hide();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtNhaCC.Clear();
            txtNguyenLieu.Clear();
            txtSoLuong.Clear();
        }
    }
}
