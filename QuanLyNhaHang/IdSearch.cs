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
    public partial class IdSearch : Form
    {
        public IdSearch()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBan.Text))
            {
                MessageBox.Show("Vui lòng nhập ID bàn.");
                return;
            }

            int idBan;
            if (!int.TryParse(txtIdBan.Text, out idBan))
            {
                MessageBox.Show("ID bàn không hợp lệ.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra trong database xem ID bàn có tồn tại không
            using (SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM BanAn WHERE id_ban = @idBan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idBan", idBan);

                int count = (int)cmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Không tồn tại bàn có ID: " + idBan, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Mở form thanh toán nếu ID bàn hợp lệ và tồn tại
            FormThanhToan frm = new FormThanhToan(idBan);
            frm.ShowDialog();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.Show();
            this.Hide();
        }
    }
}
