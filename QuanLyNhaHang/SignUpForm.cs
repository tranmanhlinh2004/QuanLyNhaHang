using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace QuanLyNhaHang
{
    public partial class SignUpForm : Form
    {
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtTendangky.Text;
            string password = txtMatkhaudangky.Text;
            string confirmPassword = txtXacnhanmatkhau.Text;
            string check;

            if (name == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khâu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            check = "SELECT * FROM DangNhap WHERE Ten_dang_nhap = N'" + name + "'";
            mySqlCommand = new SqlCommand(check, mySqlConnection);
            SqlDataReader drCheck = mySqlCommand.ExecuteReader();

            if (drCheck.HasRows == true)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendangky.Focus();
                txtTendangky.Clear();
                drCheck.Close();
                return;
            }
            drCheck.Close();
            string sSql = "INSERT INTO DangNhap (Ten_dang_nhap, Mat_khau) VALUES (N'" + name + "', N'" + password + "')";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTendangky.Clear();
            txtMatkhaudangky.Clear();
            txtXacnhanmatkhau.Clear();
        }
        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Option1 op = new Option1();
            op.Show();
            this.Hide();
        }
    }
}
