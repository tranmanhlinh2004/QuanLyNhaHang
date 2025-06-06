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
    public partial class Option3 : Form
    {
        public Option3()
        {
            InitializeComponent();
        }

        private void btnCheBien_Click(object sender, EventArgs e)
        {
            formCheBien formCheBien = new formCheBien();
            formCheBien.Show();
            this.Hide();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            formQuanLyThucDon formQuanLyThucDon = new formQuanLyThucDon();
            formQuanLyThucDon.Show();
            this.Hide();
        }
    }
}
