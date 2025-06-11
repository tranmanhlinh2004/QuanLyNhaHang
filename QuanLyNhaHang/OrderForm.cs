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
    public partial class OrderForm : Form
    {
        private DataService myDataService;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("id_ban", "ID Bàn");
            dataGridView2.Columns.Add("ten_mon_an", "Tên món ăn");
            dataGridView2.Columns.Add("so_luong", "Số lượng");
            myDataService = new DataService();
            if (myDataService.OpenDataBase())
            {
                Display();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Display();
        }
        private void Display()
        {
            string sSql = "SELECT Ten_mon_an, Phan_loai, Don_gia FROM ThucDon";
            DataTable dtMenu = myDataService.RunQuery(sSql);
            dataGridView1.DataSource = dtMenu;
            dataGridView1.Columns[0].HeaderText = "Tên món ăn";
            dataGridView1.Columns[1].HeaderText = "Phân loại";
            dataGridView1.Columns[2].HeaderText = "Đơn giá";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AllowUserToResizeColumns = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTenMonAn.Text = row.Cells["Ten_mon_an"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenMonAn = txtTenMonAn.Text;
            int soLuong;

            // Kiểm tra ID bàn
            if (string.IsNullOrWhiteSpace(txtIdBan.Text))
            {
                MessageBox.Show("Vui lòng nhập ID bàn trước khi thêm món.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBan;
            if (!int.TryParse(txtIdBan.Text, out idBan))
            {
                MessageBox.Show("ID bàn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Kiểm tra xem bàn đã được đặt chưa
            using (SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DatBan WHERE id_ban = @id_ban";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_ban", idBan);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Bàn này chưa được đặt. Vui lòng đặt bàn trước khi thêm món.", "Chưa đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            // ✅ Kiểm tra món còn hàng hay không
            using (SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();
                string checkMonQuery = "SELECT So_luong FROM ThucDon WHERE Ten_mon_an = @tenMonAn";

                using (SqlCommand cmd = new SqlCommand(checkMonQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@tenMonAn", tenMonAn);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Không tìm thấy món ăn trong thực đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int soLuongTon = Convert.ToInt32(result);
                    if (soLuongTon <= 0)
                    {
                        MessageBox.Show("Món ăn này đã hết. Vui lòng chọn món khác!", "Hết món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }


            // Kiểm tra số lượng hợp lệ
            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Thêm vào DataGridView
            dataGridView2.Rows.Add(txtIdBan.Text, tenMonAn, soLuong);
        }



        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa có món ăn nào được thêm
            bool hasValidRow = dataGridView2.Rows
                .Cast<DataGridViewRow>()
                .Any(row => !row.IsNewRow);

            if (!hasValidRow)
            {
                MessageBox.Show("Vui lòng chọn món ăn trước khi gọi món.", "Thiếu món ăn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Tạo bản ghi mới trong Goimon
                    string insertGoiMon = "INSERT INTO Goimon(id_ban, So_luong) OUTPUT INSERTED.id_goi_mon VALUES (@idBan, @tongSoLuong)";
                    SqlCommand cmdGoiMon = new SqlCommand(insertGoiMon, conn, transaction);
                    cmdGoiMon.Parameters.AddWithValue("@idBan", txtIdBan.Text);

                    // Tính tổng số lượng
                    int tongSoLuong = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;
                        tongSoLuong += Convert.ToInt32(row.Cells[2].Value);
                    }
                    cmdGoiMon.Parameters.AddWithValue("@tongSoLuong", tongSoLuong);
                    int idGoiMon = (int)cmdGoiMon.ExecuteScalar();

                    // Duyệt các món đã chọn
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string tenMonAn = row.Cells[1].Value.ToString();
                        int soLuong = Convert.ToInt32(row.Cells[2].Value);

                        // Lấy id_mon_an từ tên món
                        SqlCommand cmdGetIdMon = new SqlCommand("SELECT id_mon_an FROM ThucDon WHERE Ten_mon_an = @tenMon", conn, transaction);
                        cmdGetIdMon.Parameters.AddWithValue("@tenMon", tenMonAn);
                        int idMonAn = (int)cmdGetIdMon.ExecuteScalar();
                        // ✅ Kiểm tra số lượng tồn kho
                        SqlCommand cmdGetSoLuongTon = new SqlCommand("SELECT So_luong FROM ThucDon WHERE id_mon_an = @idMonAn", conn, transaction);
                        cmdGetSoLuongTon.Parameters.AddWithValue("@idMonAn", idMonAn);
                        int soLuongTon = (int)cmdGetSoLuongTon.ExecuteScalar();

                        if (soLuong > soLuongTon)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Món '{tenMonAn}' chỉ còn {soLuongTon} phần. Không thể gọi {soLuong} phần.", "Thiếu hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Kiểm tra xem món đã tồn tại trong CTGoimon chưa
                        string checkExistSql = "SELECT COUNT(*) FROM CTGoimon WHERE id_goi_mon = @idGoiMon AND id_mon_an = @idMonAn";
                        SqlCommand cmdCheck = new SqlCommand(checkExistSql, conn, transaction);
                        cmdCheck.Parameters.AddWithValue("@idGoiMon", idGoiMon);
                        cmdCheck.Parameters.AddWithValue("@idMonAn", idMonAn);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            // Cộng dồn số lượng nếu đã tồn tại
                            string updateSql = "UPDATE CTGoimon SET So_luong = So_luong + @soLuong WHERE id_goi_mon = @idGoiMon AND id_mon_an = @idMonAn";
                            SqlCommand cmdUpdate = new SqlCommand(updateSql, conn, transaction);
                            cmdUpdate.Parameters.AddWithValue("@soLuong", soLuong);
                            cmdUpdate.Parameters.AddWithValue("@idGoiMon", idGoiMon);
                            cmdUpdate.Parameters.AddWithValue("@idMonAn", idMonAn);
                            cmdUpdate.ExecuteNonQuery();
                        }
                        else
                        {
                            // Thêm mới nếu chưa có
                            SqlCommand cmdInsert = new SqlCommand("INSERT INTO CTGoimon(id_goi_mon, id_mon_an, So_luong) VALUES (@idGoiMon, @idMonAn, @soLuong)", conn, transaction);
                            cmdInsert.Parameters.AddWithValue("@idGoiMon", idGoiMon);
                            cmdInsert.Parameters.AddWithValue("@idMonAn", idMonAn);
                            cmdInsert.Parameters.AddWithValue("@soLuong", soLuong);
                            cmdInsert.ExecuteNonQuery();
                        }
                        // ✅ Trừ số lượng món trong bảng ThucDon
                        SqlCommand cmdUpdateThucDon = new SqlCommand("UPDATE ThucDon SET So_luong = So_luong - @soLuong WHERE id_mon_an = @idMonAn", conn, transaction);
                        cmdUpdateThucDon.Parameters.AddWithValue("@soLuong", soLuong);
                        cmdUpdateThucDon.Parameters.AddWithValue("@idMonAn", idMonAn);
                        cmdUpdateThucDon.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Gọi món thành công!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi gọi món: " + ex.Message);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridView2.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
