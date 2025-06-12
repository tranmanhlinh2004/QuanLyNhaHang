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
        //Hàm khởi tạo: gọi InitializeComponent() để khởi tạo giao diện (tự sinh khi thiết kế Form)
            InitializeComponent();
        }
        //Truy vấn toàn bộ bảng ThucDon, nạp vào DataTable, và hiển thị trên dataGridView1.
        private void Display()
        {
            string query = "SELECT id_mon_an, Ten_mon_an, Phan_loai, Don_gia, So_luong FROM ThucDon";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //Đặt tên tiêu đề cho các cột dễ hiểu hơn.
            dataGridView1.Columns["id_mon_an"].Visible = false; // Ẩn cột id_mon_an
            dataGridView1.Columns["Ten_mon_an"].HeaderText = "Tên Món Ăn";
            dataGridView1.Columns["Phan_loai"].HeaderText = "Phân Loại";
            dataGridView1.Columns["Don_gia"].HeaderText = "Đơn Giá";
            dataGridView1.Columns["So_luong"].HeaderText = "Số Lượng";
            //Tùy chỉnh font chữ, chiều cao dòng và căn giữa tiêu đề cột.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        //Tương tự như Display() nhưng không tùy chỉnh giao diện. Dùng sau khi thêm/sửa/xóa để cập nhật dữ liệu.
        private void LoadData()
        {
            string query = "SELECT id_mon_an, Ten_mon_an, Phan_loai, Don_gia, So_luong FROM ThucDon";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id_mon_an"].Visible = false; // Ẩn cột id_mon_an
        }
        //Nạp các mục phân loại vào combobox: "Đồ ăn", "Đồ uống".
        void LoadComboBox()
        {
            cboPhanLoai.Items.Clear();
            cboPhanLoai.Items.Add("Đồ ăn");
            cboPhanLoai.Items.Add("Đồ uống");
        }
        //Bật,tắt các nút thao tác phù hợp với trạng thái hiện tại
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemmoi.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnhuybo.Enabled = true;
            btnThoat.Enabled = false;
            //Khi người dùng bấm vào dòng dữ liệu, hiển thị thông tin lên các control để sửa/xóa.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTenMonAn.Text = row.Cells[1].Value.ToString();
                cboPhanLoai.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
            }
        }
        //Gọi Display() để hiển thị dữ liệu, LoadComboBox() để nạp phân loại
        private void formQuanLyThucDon_Load(object sender, EventArgs e)
        {
            Display();
            LoadComboBox();
            //Cấu hình trạng thái nút khi mới mở form
            btnThemmoi.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = false;
            btnhuybo.Enabled = false;
            btnThoat.Enabled = true;
        }
        //Xóa trắng các ô nhập và chuẩn bị thêm mới.

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
        
         //Lưu món ăn mới vào bảng ThucDon, sau đó nạp lại dữ liệu.
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
       //Lấy id_mon_an từ dòng đang chọn.
        private void btnSua_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;
            string idmonan = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();

            string query = "UPDATE ThucDon SET Ten_mon_an = @Ten, Phan_loai = @Loai, Don_gia = @Gia, So_luong = @SoLuong WHERE id_mon_an = @idmonan";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idmonan", Convert.ToInt32(idmonan));  // ✅ Tên phải khớp với câu SQL
            //Câu truy vấn cập nhật món ăn theo id_mon_an
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();   
            manageForm.Show();  
            this.Hide(); // Ẩn form hiện tại    
        }
    }
}
