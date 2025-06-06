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
    public partial class formNguyenLieu : Form
    {
        private string conStr = "Data Source = (local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        private bool modeNew;
        private string Tennglieucu;
        public formNguyenLieu()
        {
            InitializeComponent();
        }
        private void Display()
        {
            string sSql = "SELECT id_nguyen_lieu, Ten_nguyen_lieu, Don_vi_tinh, Don_gia FROM NguyenLieu";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader dr = mySqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView.DataSource = dt;
            dr.Close();
            dataGridView.Columns[0].Visible = false; // Hide the ID column
            dataGridView.Columns[1].HeaderText = "Tên nguyên liệu";
            dataGridView.Columns[2].HeaderText = "Đơn vị tính";
            dataGridView.Columns[3].HeaderText = "Đơn giá";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGridView.RowTemplate.Height = 30;
        }

        private void SetControls(bool edit)
        {
            tbTennglieu.Enabled = edit;
            tbDonvitinh.Enabled = edit;
            tbDongia.Enabled = edit;

            btnSave.Enabled = edit;
            btnCancel.Enabled = edit;

            btnNew.Enabled = !edit;
            btnEdit.Enabled = !edit;
            btnDelete.Enabled = !edit;
            btnSearch.Enabled = !edit;
            tbSearch.Enabled = !edit;
            dataGridView.Enabled = !edit;
        }

        private void formNguyenLieu_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            Display();
            SetControls(false);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            tbTennglieu.Text = dataGridView.Rows[r].Cells[1].Value.ToString();
            tbDonvitinh.Text = dataGridView.Rows[r].Cells[2].Value.ToString();
            tbDongia.Text = dataGridView.Rows[r].Cells[3].Value.ToString();
            Tennglieucu = tbTennglieu.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSql = "SELECT Ten_nguyen_lieu, Don_vi_tinh, Don_gia FROM NguyenLieu WHERE Ten_nguyen_lieu LIKE N'%" + tbSearch.Text + "%'";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader dr = mySqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView.DataSource = dt;
            dr.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControls(true);
            tbTennglieu.Clear();
            tbDonvitinh.Clear();
            tbDongia.Clear();
            tbTennglieu.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            SetControls(true);
            tbTennglieu.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) return;

            int row = dataGridView.CurrentRow.Index;
            string id = dataGridView.Rows[row].Cells[0].Value.ToString();
            string sSql = "DELETE FROM NguyenLieu WHERE id_nguyen_lieu = @ID";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@ID", id);
            mySqlCommand.ExecuteNonQuery();
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTennglieu.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTennglieu.Focus();
                return;
            }
            if (tbDonvitinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDonvitinh.Focus();
                return;
            }
            if (tbDongia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDongia.Focus();
                return;
            }
            string sSql;
            if (modeNew == true)
            {
                // Thêm nhân viên mới
                sSql = "INSERT INTO NguyenLieu (Ten_nguyen_lieu, Don_vi_tinh, Don_gia) " +
                              "VALUES (@Ten_nguyen_lieu, @Don_vi_tinh, @Don_gia)";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@Ten_nguyen_lieu", SqlDbType.NVarChar, 30).Value = tbTennglieu.Text;
                mySqlCommand.Parameters.Add("@Don_vi_tinh", SqlDbType.NVarChar, 15).Value = tbDonvitinh.Text;
                mySqlCommand.Parameters.Add("@Don_gia", SqlDbType.Int, 30).Value = tbDongia.Text;
                mySqlCommand.ExecuteNonQuery();
                Display();
                SetControls(false);
            }
            else
            {

                int row = dataGridView.CurrentRow.Index;
                string id_nguyen_lieu = dataGridView.Rows[row].Cells[0].Value.ToString();

                sSql = @"UPDATE NguyenLieu SET 
                            Ten_nguyen_lieu = @Ten,
                            Don_vi_tinh = @DVT,
                            Don_gia = @Gia
                            WHERE id_nguyen_lieu = @ID";

                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(id_nguyen_lieu);
                mySqlCommand.Parameters.AddWithValue("@Ten", tbTennglieu.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("@DVT", tbDonvitinh.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("@Gia", int.Parse(tbDongia.Text.Trim()));

                mySqlCommand.ExecuteNonQuery();
                Display();
                SetControls(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbTennglieu.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDonvitinh.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbDongia.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Tennglieucu = tbTennglieu.Text;
            }
        }
    }
}
