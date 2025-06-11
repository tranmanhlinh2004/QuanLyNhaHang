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
    public partial class formDoanhThu : Form
    {
        public formDoanhThu()
        {
            InitializeComponent();
        }
        private void ShowLabelInPanel(FlowLayoutPanel panel, string title, int value, Color color)
        {
            panel.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = $"\n{title}:\n{value.ToString("N0")} VNĐ";
            lbl.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lbl.ForeColor = color;
            lbl.AutoSize = true;
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            panel.Controls.Add(lbl);
        }

        private void HienThiTongThuChiLoiNhuan()
        {
            string connStr = @"Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                SELECT 
                SUM(CASE WHEN Loai_giao_dich = N'Thu' THEN So_tien ELSE 0 END) AS TongThu,
                SUM(CASE WHEN Loai_giao_dich = N'Chi' THEN So_tien ELSE 0 END) AS TongChi
                FROM LichSuGiaoDich";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int tongThu = reader["TongThu"] != DBNull.Value ? Convert.ToInt32(reader["TongThu"]) : 0;
                    int tongChi = reader["TongChi"] != DBNull.Value ? Convert.ToInt32(reader["TongChi"]) : 0;
                    int loiNhuan = tongThu - tongChi;

                    ShowLabelInPanel(flpTongThu, "Tổng thu", tongThu, Color.Green);
                    ShowLabelInPanel(flpTongChi, "Tổng chi", tongChi, Color.Red);
                    ShowLabelInPanel(flpLoiNhuan, "Lợi nhuận", loiNhuan, Color.Blue);
                }

                reader.Close();
            }
        }

        private void LoadBestSeller()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();
                string query = @"SELECT t.Ten_mon_an, SUM(c.So_luong) AS TongSoLuong
                                 FROM CTHoaDon c
                                 JOIN ThucDon t ON c.id_mon_an = t.id_mon_an
                                 JOIN HoaDon h ON h.id_hoa_don = c.id_hoa_don
                                 GROUP BY t.Ten_mon_an";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBestSeller.DataSource = dt;
                dgvBestSeller.Columns["Ten_mon_an"].HeaderText = "Tên Món Ăn";
                dgvBestSeller.Columns["TongSoLuong"].HeaderText = "Tổng Số Lượng Bán";
                dgvBestSeller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBestSeller.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            }
        }
        private void LoadLichSuGiaoDich()
        {
            string connectionString = @"Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                id_giao_dich AS [Mã GD], 
                Ngay_giao_dich AS [Ngày giao dịch], 
                So_tien AS [Số tiền], 
                Loai_giao_dich AS [Loại GD], 
                Mo_ta AS [Mô tả]
                FROM LichSuGiaoDich";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvLichSuGiaoDich.DataSource = dt;
                dgvLichSuGiaoDich.Columns[0].HeaderText = "Mã GD";
                dgvLichSuGiaoDich.Columns[1].HeaderText = "Ngày giao dịch";
                dgvLichSuGiaoDich.Columns[2].HeaderText = "Số tiền";
                dgvLichSuGiaoDich.Columns[3].HeaderText = "Loại GD";
                dgvLichSuGiaoDich.Columns[4].HeaderText = "Mô tả";
                dgvLichSuGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLichSuGiaoDich.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            }
        }
        private void LoadTonKho()
        {
            string connectionString = @"Data Source=.;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select Ten_nguyen_lieu, So_luong_ton, TonKho.Don_vi_tinh from NguyenLieu join TonKho on NguyenLieu.id_nguyen_lieu = TonKho.id_nguyen_lieu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTonKho.DataSource = dt;
                dgvTonKho.Columns["Ten_nguyen_lieu"].HeaderText = "Tên Nguyên Liệu";
                dgvTonKho.Columns["So_luong_ton"].HeaderText = "Số Lượng Tồn";
                dgvTonKho.Columns["Don_vi_tinh"].HeaderText = "Đơn Vị Tính";
                dgvTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTonKho.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            }
        }
        private void formDoanhThu_Load(object sender, EventArgs e)
        {
            LoadBestSeller();
            LoadLichSuGiaoDich();
            LoadTonKho();
            HienThiTongThuChiLoiNhuan();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            this.Hide(); // Ẩn form hiện tại
        }
    }
}
