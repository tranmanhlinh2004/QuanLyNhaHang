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
    public partial class formQuanLyNhanVien : Form
    {
        private string conStr = "Data Source = (local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        private bool modeNew;
        private string Tennvcu;
        public formQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void formQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            Display();
            SetControls(false);
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioTinh = comboBox1.SelectedItem.ToString();
            string sSql = "SELECT Ho_ten, So_dien_thoai, Dia_chi, Ngay_sinh, Ngay_vao_lam, Gioi_tinh FROM NhanVien WHERE Gioi_tinh = @Gioi_tinh";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@Gioi_tinh", gioTinh);
            SqlDataReader drNhanVien = mySqlCommand.ExecuteReader();
            DataTable dtNhanvien = new DataTable();
            dtNhanvien.Load(drNhanVien);
            dataGridView.DataSource = dtNhanvien;
            drNhanVien.Close();
        }
        private void Display()
        {
            string sSql = "SELECT id_nhan_vien, Ho_ten, So_dien_thoai, Dia_chi, Ngay_sinh, Ngay_vao_lam, Gioi_tinh FROM NhanVien";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader drNhanVien = mySqlCommand.ExecuteReader();
            DataTable dtNhanvien = new DataTable();
            dtNhanvien.Load(drNhanVien);
            dataGridView.DataSource = dtNhanvien;
            drNhanVien.Close();
            dataGridView.Columns[0].HeaderText = "Họ tên";
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[1].HeaderText = "Số điện thoại";
            dataGridView.Columns[2].HeaderText = "Địa chỉ";
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[3].HeaderText = "Ngày sinh";
            dataGridView.Columns[4].HeaderText = "Ngày vào làm";
            dataGridView.Columns[5].HeaderText = "Giới tính";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGridView.RowTemplate.Height = 35;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AllowUserToResizeColumns = false;
        }
        private void SetControls(bool edit)
        {
            // Trường nhập liệu
            tbTennv.Enabled = edit;
            tbSDTnv.Enabled = edit;
            tbDiachi.Enabled = edit;
            tbNgaysinh.Enabled = edit;
            tbNgayvaolam.Enabled = edit;
            rbNam.Enabled = edit;
            rbNu.Enabled = edit;

            // Nút chức năng
            btnSearch.Enabled = !edit;
            tbSearch.Enabled = !edit;
            btnSave.Enabled = edit;
            btnCancel.Enabled = edit;

            // Các nút chính: bật khi không ở chế độ chỉnh sửa
            btnNew.Enabled = !edit;
            btnEdit.Enabled = !edit && dataGridView.Rows.Count > 0;
            btnDelete.Enabled = !edit && dataGridView.Rows.Count > 0;
            btnClose.Enabled = !edit;

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTennv.Text = dataGridView.Rows[e.RowIndex].Cells["Ho_ten"].Value.ToString();
            tbSDTnv.Text = dataGridView.Rows[e.RowIndex].Cells["So_dien_thoai"].Value.ToString();
            tbDiachi.Text = dataGridView.Rows[e.RowIndex].Cells["Dia_chi"].Value.ToString();
            tbNgaysinh.Text = dataGridView.Rows[e.RowIndex].Cells["Ngay_sinh"].Value.ToString();
            tbNgayvaolam.Text = dataGridView.Rows[e.RowIndex].Cells["Ngay_vao_lam"].Value.ToString();
            if (dataGridView.Rows[e.RowIndex].Cells["Gioi_tinh"].Value.ToString() == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            //luu lại tên nhân viên cũ
            Tennvcu = tbTennv.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControls(true);
            tbSearch.Clear();
            tbTennv.Clear();
            tbSDTnv.Clear();
            tbDiachi.Clear();
            tbNgaysinh.Clear();
            tbNgayvaolam.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            tbTennv.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            SetControls(true);
            tbTennv.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Chắc chắc xóa dòng đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            int r = dataGridView.CurrentRow.Index;
            int id_nhan_vien = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            string sSql = "DELETE FROM NhanVien WHERE id_nhan_vien = @id_nhan_vien";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            mySqlCommand.Parameters.Add("id_nhan_vien", SqlDbType.Int, 4).Value = id_nhan_vien;
            mySqlCommand.ExecuteNonQuery();
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTennv.Text.Trim() == "")
            {
                MessageBox.Show("Họ và tên không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTennv.Focus();
                return;

            }
            if (tbSDTnv.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSDTnv.Focus();
                return;
            }
            DateTime ngaySinh, ngayVaoLam;
            if (!DateTime.TryParse(tbNgaysinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng (VD: 01/01/2000).");
                tbNgaysinh.Focus();
                return;
            }
            if (!DateTime.TryParse(tbNgayvaolam.Text, out ngayVaoLam))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ. Vui lòng nhập đúng định dạng (VD: 01/01/2020).");
                tbNgayvaolam.Focus();
                return;
            }

            // Sau khi kiểm tra xong thì truyền biến:
            mySqlCommand.Parameters.Add("@Ngay_sinh", SqlDbType.DateTime).Value = ngaySinh;
            mySqlCommand.Parameters.Add("@Ngay_vao_lam", SqlDbType.DateTime).Value = ngayVaoLam;


            string sSql;
            if (modeNew == true)
            {
                // Thêm nhân viên mới
                sSql = "INSERT INTO NhanVien (Ho_Ten, So_dien_thoai, Dia_chi, Ngay_sinh, Ngay_vao_lam, Gioi_tinh) " +
                              "VALUES (@Ho_Ten, @So_dien_thoai, @Dia_chi, @Ngay_sinh,@Ngay_vao_lam, @Gioi_tinh)";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@Ho_ten", SqlDbType.NVarChar, 30).Value = tbTennv.Text;
                mySqlCommand.Parameters.Add("@So_dien_thoai", SqlDbType.NVarChar, 15).Value = tbSDTnv.Text;
                mySqlCommand.Parameters.Add("@Dia_chi", SqlDbType.NVarChar, 30).Value = tbDiachi.Text;
                mySqlCommand.Parameters.Add("@Ngay_sinh", SqlDbType.DateTime).Value = DateTime.Parse(tbNgaysinh.Text);
                mySqlCommand.Parameters.Add("@Ngay_vao_lam", SqlDbType.DateTime).Value = DateTime.Parse(tbNgayvaolam.Text);
                if (rbNam.Checked == true)
                    mySqlCommand.Parameters.Add("@Gioi_tinh", SqlDbType.NVarChar, 10).Value = "Nam";
                else
                    mySqlCommand.Parameters.Add("@Gioi_tinh", SqlDbType.NVarChar, 4).Value = "Nữ";

                mySqlCommand.ExecuteNonQuery();
                Display();
                SetControls(false);
            }
            else
            {
                int r = dataGridView.CurrentRow.Index;
                string id_Nhanvien = dataGridView.Rows[r].Cells["id_nhan_vien"].Value.ToString();

                sSql = @"UPDATE NhanVien 
                         SET Ho_Ten = @Ho_Ten,So_dien_thoai = @So_dien_thoai, Dia_chi = @Dia_chi, Ngay_sinh = @Ngay_sinh,Ngay_vao_lam = @Ngay_vao_lam ,Gioi_tinh = @Gioi_tinh
                         WHERE id_nhan_vien = @id_nhan_vien";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@id_nhan_vien", SqlDbType.Int).Value = Convert.ToInt32(id_Nhanvien);
                mySqlCommand.Parameters.Add("@Ho_ten", SqlDbType.NVarChar, 30).Value = tbTennv.Text;
                mySqlCommand.Parameters.Add("@So_dien_thoai", SqlDbType.NVarChar, 15).Value = tbSDTnv.Text;
                mySqlCommand.Parameters.Add("@Dia_chi", SqlDbType.NVarChar, 30).Value = tbDiachi.Text;
                mySqlCommand.Parameters.Add("@Ngay_sinh", SqlDbType.DateTime).Value = DateTime.Parse(tbNgaysinh.Text);
                mySqlCommand.Parameters.Add("@Ngay_vao_lam", SqlDbType.DateTime).Value = DateTime.Parse(tbNgayvaolam.Text);
                if (rbNam.Checked == true)
                    mySqlCommand.Parameters.Add("@Gioi_tinh", SqlDbType.NVarChar, 10).Value = "Nam";
                else
                    mySqlCommand.Parameters.Add("@Gioi_tinh", SqlDbType.NVarChar, 4).Value = "Nữ";

                mySqlCommand.ExecuteNonQuery();
            }
            Display();
            SetControls(false);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSql = "select Ho_ten, So_dien_thoai, Dia_chi, Ngay_sinh, Ngay_vao_lam, Gioi_tinh from NhanVien WHERE Ho_ten LIKE @ten";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@ten", "%" + tbSearch.Text.Trim() + "%");

            SqlDataReader drNhanVien = mySqlCommand.ExecuteReader();
            DataTable dtNhanvien = new DataTable();
            dtNhanvien.Load(drNhanVien);
            dataGridView.DataSource = dtNhanvien;
            drNhanVien.Close();
        }

        
    }
}
