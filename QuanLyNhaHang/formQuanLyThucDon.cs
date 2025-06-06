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
    public partial class formQuanLyThucDon : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True");
        public formQuanLyThucDon()
        {
            InitializeComponent();
        }
        private void Display()
        {
            string query = "SELECT id_mon_an, Ten_mon_an, Phan_loai, Don_gia, So_luong FROM ThucDon";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id_mon_an"].Visible = false; // Ẩn cột id_mon_an
        }
        private void LoadData()
        {
            string query = "SELECT id_mon_an, Ten_mon_an, Phan_loai, Don_gia, So_luong FROM ThucDon";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id_mon_an"].Visible = false; // Ẩn cột id_mon_an
        }
        void LoadComboBox()
        {
            cboPhanLoai.Items.Clear();
            cboPhanLoai.Items.Add("Đồ ăn");
            cboPhanLoai.Items.Add("Đồ uống");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemmoi.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnhuybo.Enabled = true;
            btnThoat.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTenMonAn.Text = row.Cells[1].Value.ToString();
                cboPhanLoai.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
            }
        }
        private void formQuanLyThucDon_Load(object sender, EventArgs e)
        {
            Display();
            LoadComboBox();
            btnThemmoi.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = false;
            btnhuybo.Enabled = false;
            btnThoat.Enabled = true;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            txtTenMonAn.Clear();
            cboPhanLoai.SelectedIndex = -1;
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTenMonAn.Focus();
            btnThemmoi.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnhuybo.Enabled = true;
            btnThoat.Enabled = false;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ThucDon (Ten_mon_an, Phan_loai, Don_gia, So_luong) " +
                   "VALUES (@Ten, @Loai, @Gia, @SoLuong)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Ten", txtTenMonAn.Text);
            cmd.Parameters.AddWithValue("@Loai", cboPhanLoai.Text);
            cmd.Parameters.AddWithValue("@Gia", int.Parse(txtDonGia.Text));
            cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadData();
            MessageBox.Show("Thêm thực đơn thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;
            string idmonan = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();

            string query = "UPDATE ThucDon SET Ten_mon_an = @Ten, Phan_loai = @Loai, Don_gia = @Gia, So_luong = @SoLuong WHERE id_mon_an = @idmonan";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@idmonan", Convert.ToInt32(idmonan));  // ✅ Tên phải khớp với câu SQL
            cmd.Parameters.AddWithValue("@Ten", txtTenMonAn.Text);
            cmd.Parameters.AddWithValue("@Loai", cboPhanLoai.Text);
            cmd.Parameters.AddWithValue("@Gia", int.Parse(txtDonGia.Text));
            cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadData();
            MessageBox.Show("Cập nhật thành công");
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy id_mon_an từ dòng đang chọn
                int idMonAn = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_mon_an"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM ThucDon WHERE id_mon_an = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idMonAn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadData();
                    MessageBox.Show("Xóa món ăn thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa");
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            btnThemmoi.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = false;
            btnhuybo.Enabled = false;
            btnThoat.Enabled = true;
        }
    }
}
