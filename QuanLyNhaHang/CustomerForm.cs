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
    public partial class CustomerForm : Form
    {
        private DataService myDataService;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OptionForm op = new OptionForm();
            op.Show();
            this.Hide();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            myDataService = new DataService();
            if (myDataService.OpenDataBase())
            {
                Display();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbPhanloai.Items.Clear();
            cbPhanloai.Items.Add("Tất cả");
            cbPhanloai.Items.Add("Đồ ăn");
            cbPhanloai.Items.Add("Đồ uống");
            cbPhanloai.SelectedIndex = 0;
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

        private void cbPhanloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phanloai = cbPhanloai.SelectedItem.ToString();

            string sql;
            if (phanloai == "Tất cả")
            {
                sql = "SELECT Ten_mon_an, Phan_loai, Don_gia FROM ThucDon";
            }
            else
            {
                sql = $"SELECT Ten_mon_an, Phan_loai, Don_gia FROM ThucDon WHERE Phan_loai = N'{phanloai}'";
            }

            DataTable dtPhanloai = myDataService.RunQuery(sql);
            dataGridView1.DataSource = dtPhanloai;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSql = "SELECT Ten_mon_an, Phan_loai, Don_gia FROM ThucDon WHERE Ten_mon_an LIKE N'%" + txtSearch.Text + "%'";
            DataTable dtSearch = myDataService.RunQuery(sSql);
            dataGridView1.DataSource = dtSearch;
        }
    }
}
