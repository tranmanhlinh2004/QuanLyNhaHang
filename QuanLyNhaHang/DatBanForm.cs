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
    public partial class DatBanForm : Form
    {
        public DatBanForm()
        {
            InitializeComponent();
        }

        private void DatBan_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM BanAn";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Button btn = new Button();
                    string id = reader["id_ban"].ToString();
                    string trangThai = reader["Trang_thai"].ToString();

                    btn.Text = "Bàn " + id;
                    btn.Tag = id;
                    btn.Width = 200;
                    btn.Height = 100;


                    if (trangThai == "Trống")
                        btn.BackColor = Color.LightGreen;
                    else
                        btn.BackColor = Color.LightCoral;

                    btn.Click += btnBan_Click;

                    flpBan.Controls.Add(btn);
                }

                reader.Close();
            }

        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string idBan = btn.Tag.ToString();
            DisplayTable(idBan);
        }

        private void DisplayTable(string idBan)
        {
            string connStr = @"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM BanAn WHERE id_ban = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idBan);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtIdBan.Text = reader["id_ban"].ToString();
                    txtSochongoi.Text = reader["So_luong_cho_ngoi"].ToString();
                    txtTrangthai.Text = reader["Trang_thai"].ToString();
                }
                reader.Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.Show();
            this.Hide();
        }

        private void btnDatban_Click(object sender, EventArgs e)
        {
            string idBan = txtIdBan.Text.Trim();
            if (string.IsNullOrEmpty(idBan))
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi đặt.", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }

            DataService db = new DataService();
            if (db.OpenDataBase())
            {
                SqlTransaction transaction = db.MyConnection.BeginTransaction(); // Dùng transaction nếu có lỗi rollback luôn

                try
                {
                    // 1. Cập nhật trạng thái bàn
                    string sqlUpdate = "UPDATE BanAn SET Trang_thai = @tt WHERE id_ban = @id";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, db.MyConnection, transaction);
                    cmdUpdate.Parameters.AddWithValue("@tt", "Đã đặt");
                    cmdUpdate.Parameters.AddWithValue("@id", idBan);
                    cmdUpdate.ExecuteNonQuery();

                    // 2. Thêm bản ghi vào bảng DatBan
                    string sqlInsert = "INSERT INTO DatBan (id_ban, Ghi_chu) VALUES (@id_ban, @ghi_chu)";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, db.MyConnection, transaction);
                    cmdInsert.Parameters.AddWithValue("@id_ban", idBan);
                    cmdInsert.Parameters.AddWithValue("@ghi_chu", ""); // Ghi chú rỗng hoặc bạn có thể thêm tùy ý
                    cmdInsert.ExecuteNonQuery();

                    // 3. Commit Transaction
                    transaction.Commit();

                    // 4. Cập nhật màu nút bàn trên form
                    foreach (Control ctrl in flpBan.Controls)
                    {
                        if (ctrl is Button btn && btn.Tag.ToString() == idBan)
                        {
                            btn.BackColor = Color.LightCoral;
                            break;
                        }
                    }

                    txtTrangthai.Text = "Đã đặt";
                    MessageBox.Show("Đặt bàn thành công.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi đặt bàn: " + ex.Message);
                }
                finally
                {
                    db.CloseDatabase();
                }
            }
        }


    }
}
