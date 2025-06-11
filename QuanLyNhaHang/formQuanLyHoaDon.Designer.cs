namespace QuanLyNhaHang
{
    partial class formQuanLyHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            dgvHoaDon = new DataGridView();
            dgvChiTietHoaDon = new DataGridView();
            btnXuatHoaDon = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdBan = new TextBox();
            txtThoiGian = new TextBox();
            txtTongTien = new TextBox();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            txtIdHoaDon = new TextBox();
            label7 = new Label();
            label = new Label();
            label9 = new Label();
            txtDonGia = new TextBox();
            txtTenMonAn = new TextBox();
            txtSoLuong = new TextBox();
            btnChiTietHoaDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(687, 64);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm hóa đơn:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1261, 55);
            button1.Name = "button1";
            button1.Size = new Size(112, 38);
            button1.TabIndex = 1;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(837, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 29);
            textBox1.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeColumns = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvHoaDon.ColumnHeadersHeight = 60;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            dgvHoaDon.Location = new Point(687, 126);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.Size = new Size(740, 310);
            dgvHoaDon.TabIndex = 3;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvChiTietHoaDon.AllowUserToResizeColumns = false;
            dgvChiTietHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvChiTietHoaDon.ColumnHeadersHeight = 60;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvChiTietHoaDon.DefaultCellStyle = dataGridViewCellStyle8;
            dgvChiTietHoaDon.Location = new Point(71, 126);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.Size = new Size(571, 489);
            dgvChiTietHoaDon.TabIndex = 4;
            dgvChiTietHoaDon.CellClick += dgvChiTietHoaDon_CellClick;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXuatHoaDon.Location = new Point(287, 659);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(138, 52);
            btnXuatHoaDon.TabIndex = 5;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            btnXuatHoaDon.Click += btnXuatHoaDon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(687, 534);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 6;
            label2.Text = "id Bàn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(687, 591);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 6;
            label3.Text = "Thời gian:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(1083, 639);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 6;
            label4.Text = "Tổng tiền:";
            // 
            // txtIdBan
            // 
            txtIdBan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBan.Location = new Point(791, 531);
            txtIdBan.Name = "txtIdBan";
            txtIdBan.Size = new Size(240, 29);
            txtIdBan.TabIndex = 7;
            // 
            // txtThoiGian
            // 
            txtThoiGian.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThoiGian.Location = new Point(792, 588);
            txtThoiGian.Name = "txtThoiGian";
            txtThoiGian.Size = new Size(240, 29);
            txtThoiGian.TabIndex = 7;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(1188, 636);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(239, 29);
            txtTongTien.TabIndex = 7;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.Location = new Point(469, 659);
            button4.Name = "button4";
            button4.Size = new Size(138, 52);
            button4.TabIndex = 5;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 73);
            label5.Name = "label5";
            label5.Size = new Size(178, 30);
            label5.TabIndex = 0;
            label5.Text = "Chi tiết hóa đơn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(687, 479);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 6;
            label6.Text = "id Hóa đơn:";
            // 
            // txtIdHoaDon
            // 
            txtIdHoaDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdHoaDon.Location = new Point(791, 476);
            txtIdHoaDon.Name = "txtIdHoaDon";
            txtIdHoaDon.Size = new Size(240, 29);
            txtIdHoaDon.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(1083, 534);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 6;
            label7.Text = "Đơn giá:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label.Location = new Point(1083, 591);
            label.Name = "label";
            label.Size = new Size(80, 21);
            label.TabIndex = 6;
            label.Text = "Số lượng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(1083, 479);
            label9.Name = "label9";
            label9.Size = new Size(97, 21);
            label9.TabIndex = 6;
            label9.Text = "Tên món ăn:";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDonGia.Location = new Point(1187, 531);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(240, 29);
            txtDonGia.TabIndex = 7;
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenMonAn.Location = new Point(1187, 476);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(240, 29);
            txtTenMonAn.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(1188, 588);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(240, 29);
            txtSoLuong.TabIndex = 7;
            // 
            // btnChiTietHoaDon
            // 
            btnChiTietHoaDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnChiTietHoaDon.Location = new Point(111, 659);
            btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            btnChiTietHoaDon.Size = new Size(138, 52);
            btnChiTietHoaDon.TabIndex = 5;
            btnChiTietHoaDon.Text = "Chi tiết hóa đơn";
            btnChiTietHoaDon.UseVisualStyleBackColor = true;
            btnChiTietHoaDon.Click += btnChiTietHoaDon_Click;
            // 
            // formQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 770);
            Controls.Add(txtTongTien);
            Controls.Add(txtSoLuong);
            Controls.Add(txtThoiGian);
            Controls.Add(txtTenMonAn);
            Controls.Add(txtIdHoaDon);
            Controls.Add(txtDonGia);
            Controls.Add(txtIdBan);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(btnChiTietHoaDon);
            Controls.Add(btnXuatHoaDon);
            Controls.Add(dgvChiTietHoaDon);
            Controls.Add(dgvHoaDon);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "formQuanLyHoaDon";
            Text = "formQuanLyHoaDon";
            Load += formQuanLyHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dgvHoaDon;
        private DataGridView dgvChiTietHoaDon;
        private Button btnXuatHoaDon;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdBan;
        private TextBox txtThoiGian;
        private TextBox txtTongTien;
        private Button button4;
        private Label label5;
        private Label label6;
        private TextBox txtIdHoaDon;
        private Label label7;
        private Label label;
        private Label label9;
        private TextBox txtDonGia;
        private TextBox txtTenMonAn;
        private TextBox txtSoLuong;
        private Button btnChiTietHoaDon;
    }
}