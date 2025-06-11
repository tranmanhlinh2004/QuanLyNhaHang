using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class formQuanLyBanAn : Form
    {
        public formQuanLyBanAn()
        {
            InitializeComponent();
        }
        private void DisplayBanAn()
        {
            string connStr = @"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
            SELECT 
                TD.Ten_mon_an AS [Tên món], 
                CTG.So_luong AS [Số lượng], 
                TD.Don_gia AS [Đơn giá],
                (CTG.So_luong * TD.Don_gia) AS [Thành tiền]
            FROM CTGoimon CTG
            INNER JOIN ThucDon TD ON CTG.id_mon_an = TD.id_mon_an
            WHERE CTG.id_goi_mon = @idGoiMon";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idGoiMon", 1); // Giả sử id_goi_mon là 1, cần thay đổi theo logic thực tế
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
    
                    dgvChiTietBan.DataSource = dt;
    
                    // Tính tổng tiền
                    int tongTien = dt.AsEnumerable().Sum(row => row.Field<int>("Thành tiền"));
                    lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " đ";
            }
        }
        private void LoadDanhSachMonAnTheoBan(int idBan)
        {
            string connStr = @"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // 1. Kiểm tra trạng thái bàn
                string sqlTrangThai = "SELECT Trang_thai FROM BanAn WHERE id_ban = @idBan";
                SqlCommand cmdTrangThai = new SqlCommand(sqlTrangThai, conn);
                cmdTrangThai.Parameters.AddWithValue("@idBan", idBan);
                string trangThai = cmdTrangThai.ExecuteScalar()?.ToString();

                if (trangThai == "Trống")
                {
                    dgvChiTietBan.DataSource = null;
                    lblTongTien.Text = "Bàn đang trống.";
                    return;
                }
                // 2. Lấy id_goi_mon gần nhất
                string sqlGoiMon = @"SELECT TOP 1 id_goi_mon 
                             FROM Goimon 
                             WHERE id_ban = @idBan 
                             ORDER BY Ngay_goi_mon DESC";

                SqlCommand cmdGoiMon = new SqlCommand(sqlGoiMon, conn);
                cmdGoiMon.Parameters.AddWithValue("@idBan", idBan);

                object result = cmdGoiMon.ExecuteScalar();
                if (result == null)
                {
                    dgvChiTietBan.DataSource = null;
                    lblTongTien.Text = "Không có dữ liệu gọi món.";
                    return;
                }

                int idGoiMon = Convert.ToInt32(result);

                // 3. Lấy danh sách món ăn từ CTGoimon + ThucDon
                string sql = @"
            SELECT 
                TD.Ten_mon_an AS [Tên món], 
                CTG.So_luong AS [Số lượng], 
                TD.Don_gia AS [Đơn giá],
                (CTG.So_luong * TD.Don_gia) AS [Thành tiền]
            FROM CTGoimon CTG
            INNER JOIN ThucDon TD ON CTG.id_mon_an = TD.id_mon_an
            WHERE CTG.id_goi_mon = @idGoiMon";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@idGoiMon", idGoiMon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvChiTietBan.DataSource = dt;

                // 4. Tổng tiền
                int tongTien = dt.AsEnumerable().Sum(row => row.Field<int>("Thành tiền"));
                lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " đ";
            }
        }

        private void formQuanLyBanAn_Load(object sender, EventArgs e)
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
            DisplayBanAn();
            LoadDanhSachMonAnTheoBan(1);
        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idBan = Convert.ToInt32(btn.Tag);
            LoadDanhSachMonAnTheoBan(idBan);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            this.Hide();
        }
    }
}
