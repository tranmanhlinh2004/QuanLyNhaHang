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
namespace QuanLyNhaHang
{
    public partial class LoginForm : Form
    {
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sSql = "SELECT * FROM DangNhap Where (Ten_dang_nhap = N'" + txtTendangnhap.Text + "') and (Mat_khau = N'" + txtMatkhau.Text + "')";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader drLogin = mySqlCommand.ExecuteReader();
            if (drLogin.HasRows == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendangnhap.Focus();
                drLogin.Close();
                return;
            }
            drLogin.Close();
            ManageForm main = new ManageForm();
            main.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OptionForm op = new OptionForm();
            op.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
