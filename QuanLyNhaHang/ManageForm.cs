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
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }
        private Panel TaoPanel(string soLuong, string moTa, Color backColor)
        {
            Panel pnl = new Panel();
            pnl.Width = 150;
            pnl.Height = 80;
            pnl.BackColor = backColor;
            pnl.Margin = new Padding(10);
            pnl.Padding = new Padding(5);

            Label lblSo = new Label();
            lblSo.Text = soLuong;
            lblSo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblSo.ForeColor = Color.White;
            lblSo.Dock = DockStyle.Top;
            lblSo.Height = 40;
            lblSo.TextAlign = ContentAlignment.MiddleCenter;

            Label lblMoTa = new Label();
            lblMoTa.Text = moTa;
            lblMoTa.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblMoTa.ForeColor = Color.White;
            lblMoTa.Dock = DockStyle.Bottom;
            lblMoTa.Height = 30;
            lblMoTa.TextAlign = ContentAlignment.MiddleCenter;

            pnl.Controls.Add(lblSo);
            pnl.Controls.Add(lblMoTa);

            return pnl;
        }

        private void ThongKeBan()
        {
            flpThongKeBan.Controls.Clear();

            int tongSoBan = 0;
            int soBanTrong = 0;

            string connectionString = @"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Đếm tổng số bàn
                SqlCommand cmdTong = new SqlCommand("SELECT COUNT(*) FROM BanAn", conn);
                tongSoBan = (int)cmdTong.ExecuteScalar();

                // Đếm số bàn trống
                SqlCommand cmdTrong = new SqlCommand("SELECT COUNT(*) FROM BanAn WHERE Trang_thai = N'trống'", conn);
                soBanTrong = (int)cmdTrong.ExecuteScalar();
            }

            // Tạo giao diện
            Panel pnlTong = TaoPanel(tongSoBan.ToString(), "TỔNG SỐ BÀN", Color.FromArgb(41, 128, 255));
            Panel pnlTrong = TaoPanel(soBanTrong.ToString(), "BÀN TRỐNG", Color.FromArgb(41, 128, 255));

            flpThongKeBan.Controls.Add(pnlTong);
            flpThongKeBan.Controls.Add(pnlTrong);
        }


        private void ManageForm_Load(object sender, EventArgs e)
        {
            ThongKeBan();
            timer1_Tick(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Ẩn form hiện tại
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            formQuanLyNhanVien fNhanVien = new formQuanLyNhanVien();
            fNhanVien.Show();
            this.Hide(); // Ẩn form hiện tại
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            formNguyenLieu fNguyenLieu = new formNguyenLieu();
            fNguyenLieu.Show();
            this.Hide(); // Ẩn form hiện tại
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            Option2 fNhapHang = new Option2();
            fNhapHang.Show();
            this.Hide(); // Ẩn form hiện tại
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss tt");
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option3 option3 = new Option3();
            option3.Show();
            this.Hide();
        }
    }
}
