using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using System.Windows.Forms;

namespace QuanLyNhaHang
{

    public partial class formQuanLyHoaDon : Form
    {
        string connectionString = @"Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public formQuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void LoadHoaDon()
        {
            string query = @"SELECT HoaDon.id_hoa_don, id_ban, HoaDon.id_goi_mon, id_mon_an, 
                                CTHoaDon.So_luong, Don_gia, HoaDon.Thanh_tien 
                                FROM HoaDon
                                JOIN CTHoaDon ON HoaDon.id_hoa_don = CTHoaDon.id_hoa_don
                                JOIN Goimon ON HoaDon.id_goi_mon = Goimon.id_goi_mon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHoaDon.DataSource = dt;
                dgvHoaDon.Columns["id_hoa_don"].HeaderText = "ID Hóa Đơn";
                dgvHoaDon.Columns["id_ban"].HeaderText = "ID Bàn";
                dgvHoaDon.Columns["id_goi_mon"].HeaderText = "ID Gọi Món";
                dgvHoaDon.Columns["id_mon_an"].HeaderText = "ID Món Ăn";
                dgvHoaDon.Columns["So_luong"].HeaderText = "Số Lượng";
                dgvHoaDon.Columns["Don_gia"].HeaderText = "Đơn Giá";
                dgvHoaDon.Columns["Thanh_tien"].HeaderText = "Thành Tiền";
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtIdHoaDon.Text = row.Cells["id_hoa_don"].Value.ToString();
                txtIdBan.Text = row.Cells["id_ban"].Value.ToString();
                txtTongTien.Text = row.Cells["Thanh_tien"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Thoi_gian FROM HoaDon WHERE id_hoa_don = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtIdHoaDon.Text);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        txtThoiGian.Text = result != null ? Convert.ToDateTime(result).ToString("dd/MM/yyyy HH:mm") : "";
                    }
                }
            }
        }
        private void formQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietHoaDon.Rows[e.RowIndex];
                txtTenMonAn.Text = row.Cells["Ten_mon_an"].Value.ToString();
                txtDonGia.Text = row.Cells["Don_gia"].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.Rows[rowIndex].Cells["So_luong"].Value.ToString();
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdHoaDon.Text, out int idHoaDon))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập đúng ID hóa đơn.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"HoaDon_{idHoaDon}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy thông tin hóa đơn
                    string queryInfo = @"
                    SELECT h.id_hoa_don, g.id_ban, h.Thanh_tien, h.Thoi_gian 
                    FROM HoaDon h
                    JOIN Goimon g ON h.id_goi_mon = g.id_goi_mon
                    WHERE h.id_hoa_don = @idHoaDon";

                    string queryChiTiet = @"
                    SELECT t.Ten_mon_an, c.Don_gia, c.So_luong
                    FROM CTHoaDon c
                    JOIN ThucDon t ON c.id_mon_an = t.id_mon_an
                    WHERE c.id_hoa_don = @idHoaDon";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Lấy thông tin chung
                        SqlCommand cmdInfo = new SqlCommand(queryInfo, conn);
                        cmdInfo.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                        string idBan = "";
                        int tongTien = 0;
                        DateTime thoiGian = DateTime.Now;

                        using (SqlDataReader reader = cmdInfo.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idBan = reader["id_ban"].ToString();
                                tongTien = Convert.ToInt32(reader["Thanh_tien"]);
                                thoiGian = Convert.ToDateTime(reader["Thoi_gian"]);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn.");
                                return;
                            }
                        }

                        // Lấy chi tiết món ăn
                        SqlDataAdapter da = new SqlDataAdapter(queryChiTiet, conn);
                        da.SelectCommand.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                        DataTable dtChiTiet = new DataTable();
                        da.Fill(dtChiTiet);

                        // Tạo file PDF
                        Document doc = new Document(PageSize.A4);
                        PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                        doc.Open();

                        // Sửa ở đây: Sử dụng font Unicode hỗ trợ tiếng Việt
                        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
                        BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD); // Explicitly specify iTextSharp.text.Font
                        iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12); // Explicitly specify iTextSharp.text.Font

                        doc.Add(new Paragraph("HÓA ĐƠN NHÀ HÀNG", titleFont));
                        doc.Add(new Paragraph(" "));

                        doc.Add(new Paragraph($"Mã hóa đơn: {idHoaDon}", normalFont));
                        doc.Add(new Paragraph($"Số bàn: {idBan}", normalFont));
                        doc.Add(new Paragraph($"Thời gian: {thoiGian:dd/MM/yyyy HH:mm}", normalFont));
                        doc.Add(new Paragraph(" "));

                        PdfPTable table = new PdfPTable(3);
                        table.WidthPercentage = 100;

                        PdfPCell cell1 = new PdfPCell(new Phrase("Tên món ăn", normalFont));
                        table.AddCell(cell1);

                        PdfPCell cell2 = new PdfPCell(new Phrase("Đơn giá", normalFont));
                        table.AddCell(cell2);

                        PdfPCell cell3 = new PdfPCell(new Phrase("Số lượng", normalFont));
                        table.AddCell(cell3);



                        doc.Add(table);
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph($"TỔNG TIỀN: {tongTien:N0} VND", titleFont));

                        doc.Close();
                        MessageBox.Show("Xuất hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            this.Hide();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdHoaDon.Text))
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trước!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
        SELECT ThucDon.Ten_mon_an, CTHoaDon.Don_gia, CTHoaDon.So_luong 
        FROM CTHoaDon
        JOIN ThucDon ON CTHoaDon.id_mon_an = ThucDon.id_mon_an
        WHERE CTHoaDon.id_hoa_don = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@id", txtIdHoaDon.Text);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvChiTietHoaDon.DataSource = dt;

                // Đặt tên cột dễ đọc
                dgvChiTietHoaDon.Columns["Ten_mon_an"].HeaderText = "Tên Món Ăn";
                dgvChiTietHoaDon.Columns["Don_gia"].HeaderText = "Đơn Giá";
                dgvChiTietHoaDon.Columns["So_luong"].HeaderText = "Số Lượng";
                dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

    }
}
