namespace QuanLyNhaHang
{
    public partial class Option1 : Form
    {
        public Option1()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoginForm Lg = new LoginForm();
            Lg.Show();
            this.Hide();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            CustomerForm Cs = new CustomerForm();
            Cs.Show();
            this.Hide();
        }
    }
}
