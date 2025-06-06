using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Option2 : Form
    {
        public Option2()
        {
            InitializeComponent();
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            formNhaCungCap frmNhaCungCap = new formNhaCungCap();
            frmNhaCungCap.Show();
            this.Hide();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            formNhapHang frmNhapHang = new formNhapHang();
            frmNhapHang.Show();
            this.Hide();
        }
    }
}
