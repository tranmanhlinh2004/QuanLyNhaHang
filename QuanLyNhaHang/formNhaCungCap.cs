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
    public partial class formNhaCungCap : Form
    {
        private string conStr = "Data Source = (local);Initial Catalog= QuanLyNhaHang; Integrated Security = True ";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        private bool modeNew;
        public formNhaCungCap()
        {
            InitializeComponent();
        }
        private void Display()
        {
            string sSql = "SELECT id_nha_cung_cap, Ten_nha_cung_cap, So_dien_thoai, Dia_chi FROM NhaCungCap";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sSql, conn))
                using (SqlDataReader drNhaCungCap = cmd.ExecuteReader())
                {
                    DataTable dtNhaCungCap = new DataTable();
                    dtNhaCungCap.Load(drNhaCungCap);
                    dataGridView.DataSource = dtNhaCungCap;
                }
            }
            dataGridView.Columns["id_nha_cung_cap"].Visible = false;
            dataGridView.Columns[1].HeaderText = "Tên nhà cung cấp";
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].HeaderText = "Số điện thoại";
            dataGridView.Columns[3].HeaderText = "Địa chỉ";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGridView.RowTemplate.Height = 30;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void SetControls(bool edit)
        {
            tbTennhacc.Enabled = edit;
            tbsđt.Enabled = edit;
            tbDiachi.Enabled = edit;

            btnSave.Enabled = edit;
            btnCancel.Enabled = edit;

            btnNew.Enabled = !edit;
            btnEdit.Enabled = !edit;
            btnDelete.Enabled = !edit;
            btnSearch.Enabled = !edit;
            tbSearch.Enabled = !edit;
            dataGridView.Enabled = !edit;
        }
        private void formNhaCungCap_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            Display();
            SetControls(false);
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && r < dataGridView.Rows.Count) // Ensure the row index is valid
            {
                tbTennhacc.Text = dataGridView.Rows[r].Cells[1].Value.ToString(); // Column 0
                tbsđt.Text = dataGridView.Rows[r].Cells[2].Value.ToString();     // Column 1
                tbDiachi.Text = dataGridView.Rows[r].Cells[3].Value.ToString();  // Column 2
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSql = "SELECT Ten_nha_cung_cap, So_dien_thoai, Dia_chi FROM NhaCungCap WHERE Ten_nha_cung_cap LIKE N'%" + tbSearch.Text + "%'";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader drNhacungcap = mySqlCommand.ExecuteReader();
            //muốn hiển thị dữ liệu lên lưới, phải chuyển đối tương SqlDataReader => DataTable
            DataTable dtNhacungcap = new DataTable();
            dtNhacungcap.Load(drNhacungcap);
            //hiển thị trên lưới
            dataGridView.DataSource = dtNhacungcap;
            drNhacungcap.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControls(true);
            tbTennhacc.Clear();
            tbsđt.Clear();
            tbDiachi.Clear();
            tbTennhacc.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControls(true);
            tbTennhacc.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            int row = dataGridView.CurrentRow.Index;
            int id_nha_cung_cap;

            if (int.TryParse(dataGridView.Rows[row].Cells[0].Value.ToString(), out id_nha_cung_cap))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(conStr))
                    {
                        conn.Open();
                        string sSql = "DELETE FROM NhaCungCap WHERE id_nha_cung_cap = @id";
                        using (SqlCommand cmd = new SqlCommand(sSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id_nha_cung_cap);
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                                MessageBox.Show("Xóa thành công.");
                            else
                                MessageBox.Show("Không tìm thấy dữ liệu cần xóa.");
                        }
                    }
                    Display(); // reload lại dữ liệu
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID không hợp lệ. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTennhacc.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập tên nhà cung cấp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTennhacc.Focus();
                return;
            }
            if (tbsđt.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập số điện thoại nhà cung cấp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbsđt.Focus();
                return;
            }
            if (tbDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập địa chỉ nhà cung cấp !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDiachi.Focus();
                return;
            }
            string sSql;
            if (modeNew == true)
            {
                // Thêm nahf cung cấp mới
                sSql = "INSERT INTO NhaCungCap (Ten_nha_cung_cap, So_dien_thoai, Dia_chi) " +
                              "VALUES (@Ten_nha_cung_cap, @So_dien_thoai, @Dia_chi)";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@Ten_nha_cung_cap", SqlDbType.NVarChar, 30).Value = tbTennhacc.Text;
                mySqlCommand.Parameters.Add("@So_dien_thoai", SqlDbType.Int, 20).Value = tbsđt.Text;
                mySqlCommand.Parameters.Add("@Dia_chi", SqlDbType.NVarChar, 30).Value = tbDiachi.Text;
                mySqlCommand.ExecuteNonQuery();
                Display();
                SetControls(false);
            }
            else
            {
                // Lấy dòng hiện tại đang chọn
                int row = dataGridView.CurrentRow.Index;
                string id_nha_cung_cap = dataGridView.Rows[row].Cells[0].Value.ToString();

                // Câu lệnh cập nhật dùng SqlParameter để tránh lỗi dấu nháy và injection
                sSql = @"UPDATE NhaCungCap SET 
                    Ten_nha_cung_cap = @TenNCC, 
                    So_dien_thoai = @SDT, 
                    Dia_chi = @DiaChi 
                    WHERE id_nha_cung_cap = @ID";

                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@TenNCC", tbTennhacc.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("@SDT", tbsđt.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("@DiaChi", tbDiachi.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("@ID", id_nha_cung_cap);

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
            ManageForm frmManage = new ManageForm();
            frmManage.Show();
            this.Hide();
        }
    }
}
