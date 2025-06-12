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
    public partial class formCheBien : Form
    {
        public formCheBien()
        {
            InitializeComponent();
        }
        void SetReadOnlyAll(bool isReadOnly)
        {
            txtTenMonAn.ReadOnly = isReadOnly;
            txtSoLuong1.ReadOnly = isReadOnly;
            txtSoLuong2.ReadOnly = isReadOnly;
            txtSoLuong3.ReadOnly = isReadOnly;
            txtSoLuong4.ReadOnly = isReadOnly;
            txtSoLuong5.ReadOnly = isReadOnly;

            cboNguyenLieu1.Enabled = !isReadOnly;
            cboNguyenLieu2.Enabled = !isReadOnly;
            cboNguyenLieu3.Enabled = !isReadOnly;
            cboNguyenLieu4.Enabled = !isReadOnly;
            cboNguyenLieu5.Enabled = !isReadOnly;
        }
        void SetNguyenLieuLastToReadOnly()
        {
            ComboBox[] cbArr = { cboNguyenLieu1, cboNguyenLieu2, cboNguyenLieu3, cboNguyenLieu4, cboNguyenLieu5 };
            TextBox[] txtArr = { txtSoLuong1, txtSoLuong2, txtSoLuong3, txtSoLuong4, txtSoLuong5 };

            // duyệt từ dưới lên
            for (int i = cbArr.Length - 1; i >= 0; i--)
            {
                if (cbArr[i].Enabled) // nếu dòng này đang mở
                {
                    cbArr[i].Enabled = false;             // khóa combobox
                    txtArr[i].ReadOnly = true;            // khóa textbox
                    cbArr[i].SelectedIndex = -1;          // reset combobox
                    txtArr[i].Clear();                    // xóa textbox
                    break;                                // chỉ xử lý 1 dòng
                }
            }
        }
        private void ResetControls()
        {
            SetReadOnlyAll(true);
            cboNguyenLieu1.Enabled = false;
            cboNguyenLieu2.Enabled = false;
            cboNguyenLieu3.Enabled = false;
            cboNguyenLieu4.Enabled = false;
            cboNguyenLieu5.Enabled = false;
            txtSoLuong1.Clear();
            txtSoLuong2.Clear();
            txtSoLuong3.Clear();
            txtSoLuong4.Clear();
            txtSoLuong5.Clear();
            currentNL = 1; // reset số lượng nguyên liệu
        }
        void EnableNextNguyenLieu()
        {
            ComboBox[] cbArr = { cboNguyenLieu1, cboNguyenLieu2, cboNguyenLieu3, cboNguyenLieu4, cboNguyenLieu5 };
            TextBox[] txtArr = { txtSoLuong1, txtSoLuong2, txtSoLuong3, txtSoLuong4, txtSoLuong5 };

            // duyệt từ trên xuống để mở dòng đầu tiên bị tắt
            for (int i = 0; i < cbArr.Length; i++)
            {
                if (!cbArr[i].Enabled)
                {
                    cbArr[i].Enabled = true;
                    txtArr[i].ReadOnly = false;
                    break;
                }
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();

                // Load bảng Chế biến vào dgv1
                SqlDataAdapter da1 = new SqlDataAdapter("select Ten_nguyen_lieu, So_luong_ton, TonKho.Don_vi_tinh, Ngay_cap_nhat from TonKho join NguyenLieu on NguyenLieu.id_nguyen_lieu = TonKho.id_nguyen_lieu", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                dataGridView1.Columns[0].HeaderText = "Tên nguyên liệu";
                dataGridView1.Columns[1].HeaderText = "Số lượng";
                dataGridView1.Columns[2].HeaderText = "Đơn vị tính";
                dataGridView1.Columns[3].HeaderText = "Ngày cập nhật";
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 30;
                // Load thực đơn vào dgv2
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM ThucDon", conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].HeaderText = "Tên món ăn";
                dataGridView2.Columns[2].HeaderText = "Phân loại";
                dataGridView2.Columns[3].HeaderText = "Đơn giá";
                dataGridView2.Columns[4].HeaderText = "Số lượng";
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                dataGridView2.RowTemplate.Height = 30;
            }
        }
        private void LoadNguyenLieuComboBox()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id_nguyen_lieu, Ten_nguyen_lieu FROM NguyenLieu", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboNguyenLieu1.DataSource = dt.Copy();
                cboNguyenLieu1.DisplayMember = "Ten_nguyen_lieu";
                cboNguyenLieu1.ValueMember = "id_nguyen_lieu";

                cboNguyenLieu2.DataSource = dt.Copy();
                cboNguyenLieu2.DisplayMember = "Ten_nguyen_lieu";
                cboNguyenLieu2.ValueMember = "id_nguyen_lieu";

                cboNguyenLieu3.DataSource = dt.Copy();
                cboNguyenLieu3.DisplayMember = "Ten_nguyen_lieu";
                cboNguyenLieu3.ValueMember = "id_nguyen_lieu";

                cboNguyenLieu4.DataSource = dt.Copy();
                cboNguyenLieu4.DisplayMember = "Ten_nguyen_lieu";
                cboNguyenLieu4.ValueMember = "id_nguyen_lieu";

                cboNguyenLieu5.DataSource = dt.Copy();
                cboNguyenLieu5.DisplayMember = "Ten_nguyen_lieu";
                cboNguyenLieu5.ValueMember = "id_nguyen_lieu";
            }
        }
        private void LoadTonKho()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select Ten_nguyen_lieu, So_luong_ton, TonKho.Don_vi_tinh, Ngay_cap_nhat from TonKho join NguyenLieu on NguyenLieu.id_nguyen_lieu = TonKho.id_nguyen_lieu", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void LoadThucDon()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThucDon", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }
        private void SetControls()
        {
            btnThemMonAn.Enabled = true;
            btnThemNguyenLieu.Enabled = false;   
            btnHuy.Enabled =false;
            btnXoaNguyenLieu.Enabled = false;
            btnCheBien.Enabled = false;
            btnThoat.Enabled = true;
        }
        private void formCheBien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadNguyenLieuComboBox();
            LoadTonKho();
            LoadThucDon();
            SetReadOnlyAll(true);
            SetControls();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txtTenMonAn.Text = row.Cells["Ten_mon_an"].Value.ToString();
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            txtTenMonAn.ReadOnly = false;
            txtTenMonAn.Clear();
            txtTenMonAn.Focus();

            btnThemMonAn.Enabled = false;
            btnThemNguyenLieu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoaNguyenLieu.Enabled = true;
            btnCheBien.Enabled = false;
            btnThoat.Enabled = false;
        }
        int currentNL = 1;

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            btnCheBien.Enabled = true;
            switch (currentNL)
            {
                case 1:
                    cboNguyenLieu1.Enabled = true;
                    txtSoLuong1.ReadOnly = false;
                    break;
                case 2:
                    cboNguyenLieu2.Enabled = true;
                    txtSoLuong2.ReadOnly = false;
                    break;
                case 3:
                    cboNguyenLieu3.Enabled = true;
                    txtSoLuong3.ReadOnly = false;
                    break;
                case 4:
                    cboNguyenLieu4.Enabled = true;
                    txtSoLuong4.ReadOnly = false;
                    break;
                case 5:
                    cboNguyenLieu5.Enabled = true;
                    txtSoLuong5.ReadOnly = false;
                    break;
            }
            currentNL++;
            EnableNextNguyenLieu();
        }

        private void btnCheBien_Click(object sender, EventArgs e)
        {
            {
                string tenMonAn = txtTenMonAn.Text.Trim();

                if (string.IsNullOrEmpty(tenMonAn))
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn!");
                    return;
                }

                // Gom các nguyên liệu trùng lại
                Dictionary<int, int> dsNguyenLieu = new Dictionary<int, int>();

                void ThemNguyenLieu(ComboBox cbo, TextBox txt)
                {
                    if (cbo.Enabled && cbo.SelectedValue != null && int.TryParse(txt.Text, out int soLuong))
                    {
                        int idNL = (int)cbo.SelectedValue;
                        if (dsNguyenLieu.ContainsKey(idNL))
                            dsNguyenLieu[idNL] += soLuong;
                        else
                            dsNguyenLieu[idNL] = soLuong;
                    }
                }

                ThemNguyenLieu(cboNguyenLieu1, txtSoLuong1);
                ThemNguyenLieu(cboNguyenLieu2, txtSoLuong2);
                ThemNguyenLieu(cboNguyenLieu3, txtSoLuong3);
                ThemNguyenLieu(cboNguyenLieu4, txtSoLuong4);
                ThemNguyenLieu(cboNguyenLieu5, txtSoLuong5);

                if (dsNguyenLieu.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một nguyên liệu và nhập số lượng hợp lệ.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    try
                    {
                        // Kiểm tra món ăn đã tồn tại chưa
                        SqlCommand checkCmd = new SqlCommand("SELECT id_mon_an FROM ThucDon WHERE Ten_mon_an = @ten", conn, tran);
                        checkCmd.Parameters.AddWithValue("@ten", tenMonAn);
                        object result = checkCmd.ExecuteScalar();

                        int idMonAn;

                        if (result != null)
                        {
                            // Món ăn đã tồn tại → tăng số lượng
                            idMonAn = (int)result;

                            SqlCommand updateCmd = new SqlCommand("UPDATE ThucDon SET So_luong = So_luong + 1 WHERE id_mon_an = @id", conn, tran);
                            updateCmd.Parameters.AddWithValue("@id", idMonAn);
                            updateCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Món ăn chưa có → thêm mới
                            SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO ThucDon (Ten_mon_an, Phan_loai, Don_gia, So_luong)
                    OUTPUT INSERTED.id_mon_an
                    VALUES (@ten, @loai, @gia, 1)", conn, tran);
                            insertCmd.Parameters.AddWithValue("@ten", tenMonAn);
                            insertCmd.Parameters.AddWithValue("@loai", ""); // Hoặc thay đổi tùy loại
                            insertCmd.Parameters.AddWithValue("@gia", 0); // Chưa biết giá

                            idMonAn = (int)insertCmd.ExecuteScalar();
                        }

                        // Chế biến: trừ kho + thêm vào CheBien
                        foreach (var item in dsNguyenLieu)
                        {
                            int idNL = item.Key;
                            int soLuong = item.Value;

                            // Trừ kho
                            SqlCommand cmd2 = new SqlCommand(@"
                    UPDATE TonKho 
                    SET So_luong_ton = So_luong_ton - @sl, Ngay_cap_nhat = GETDATE() 
                    WHERE id_nguyen_lieu = @idNL", conn, tran);
                            cmd2.Parameters.AddWithValue("@sl", soLuong);
                            cmd2.Parameters.AddWithValue("@idNL", idNL);
                            cmd2.ExecuteNonQuery();
                        }

                        tran.Commit();
                        MessageBox.Show("Chế biến món ăn thành công!", "Thông báo");

                        LoadTonKho();
                        LoadThucDon();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                    }
                }
            }
            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThemMonAn.Enabled = true;
            btnThemNguyenLieu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoaNguyenLieu.Enabled = false;
            btnCheBien.Enabled = false;
            btnThoat.Enabled = true;
            ResetControls();
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            SetNguyenLieuLastToReadOnly();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            this.Hide();   
        }
    }
}
