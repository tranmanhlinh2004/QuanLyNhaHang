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
    public partial class formNhapHang : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True");
        public formNhapHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // Load nguyên liệu
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM NguyenLieu", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvNguyenLieu.DataSource = dt1;

            // Load nhà cung cấp
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM NhaCungCap", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvNhaCungCap.DataSource = dt2;

            // Load tồn kho
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM TonKho", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvKho.DataSource = dt3;
        }

        private void formNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNhaCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["Ten_nha_cung_cap"].Value.ToString();
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["Ten_nguyen_lieu"].Value.ToString();
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Lấy ID nhà cung cấp
                string query1 = "SELECT id_nha_cung_cap FROM NhaCungCap WHERE Ten_nha_cung_cap = @tenNCC";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@tenNCC", txtNhaCC.Text);
                int idNCC = (int)cmd1.ExecuteScalar();

                // Thêm vào bảng Phiếu Nhập
                string insertPhieu = "INSERT INTO PhieuNhap(id_nha_cung_cap) VALUES(@idNCC); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdPhieu = new SqlCommand(insertPhieu, conn);
                cmdPhieu.Parameters.AddWithValue("@idNCC", idNCC);
                int idPhieuNhap = Convert.ToInt32(cmdPhieu.ExecuteScalar());

                // Lấy ID nguyên liệu
                string query2 = "SELECT id_nguyen_lieu FROM NguyenLieu WHERE Ten_nguyen_lieu = @tenNL";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@tenNL", txtNguyenLieu.Text);
                int idNL = (int)cmd2.ExecuteScalar();

                int soLuongNhap = int.Parse(txtSoLuong.Text);

                // Thêm vào bảng Chi tiết phiếu nhập
                string insertCT = "INSERT INTO CTPhieuNhap(id_phieu_nhap, id_nguyen_lieu, So_luong) VALUES(@idPhieu, @idNL, @soLuong)";
                SqlCommand cmdCT = new SqlCommand(insertCT, conn);
                cmdCT.Parameters.AddWithValue("@idPhieu", idPhieuNhap);
                cmdCT.Parameters.AddWithValue("@idNL", idNL);
                cmdCT.Parameters.AddWithValue("@soLuong", soLuongNhap);
                cmdCT.ExecuteNonQuery();

                MessageBox.Show("Nhập hàng thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            this.Hide();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtNhaCC.Clear();
            txtNguyenLieu.Clear();
            txtSoLuong.Clear();
        }
    }
}
