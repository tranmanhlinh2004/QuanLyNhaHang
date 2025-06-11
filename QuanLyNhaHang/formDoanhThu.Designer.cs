namespace QuanLyNhaHang
{
    partial class formDoanhThu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvLichSuGiaoDich = new DataGridView();
            dgvBestSeller = new DataGridView();
            flpTongThu = new FlowLayoutPanel();
            flpTongChi = new FlowLayoutPanel();
            flpLoiNhuan = new FlowLayoutPanel();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            dgvTonKho = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoDich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTonKho).BeginInit();
            SuspendLayout();
            // 
            // dgvLichSuGiaoDich
            // 
            dgvLichSuGiaoDich.AllowUserToAddRows = false;
            dgvLichSuGiaoDich.AllowUserToDeleteRows = false;
            dgvLichSuGiaoDich.AllowUserToResizeColumns = false;
            dgvLichSuGiaoDich.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLichSuGiaoDich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLichSuGiaoDich.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLichSuGiaoDich.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLichSuGiaoDich.Location = new Point(33, 452);
            dgvLichSuGiaoDich.Name = "dgvLichSuGiaoDich";
            dgvLichSuGiaoDich.Size = new Size(908, 319);
            dgvLichSuGiaoDich.TabIndex = 0;
            // 
            // dgvBestSeller
            // 
            dgvBestSeller.AllowUserToAddRows = false;
            dgvBestSeller.AllowUserToDeleteRows = false;
            dgvBestSeller.AllowUserToResizeColumns = false;
            dgvBestSeller.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBestSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBestSeller.ColumnHeadersHeight = 60;
            dgvBestSeller.Location = new Point(33, 77);
            dgvBestSeller.Name = "dgvBestSeller";
            dgvBestSeller.Size = new Size(592, 325);
            dgvBestSeller.TabIndex = 1;
            // 
            // flpTongThu
            // 
            flpTongThu.BackColor = Color.FromArgb(255, 192, 128);
            flpTongThu.Location = new Point(689, 77);
            flpTongThu.Name = "flpTongThu";
            flpTongThu.Size = new Size(252, 92);
            flpTongThu.TabIndex = 2;
            // 
            // flpTongChi
            // 
            flpTongChi.BackColor = Color.FromArgb(255, 192, 128);
            flpTongChi.Location = new Point(689, 192);
            flpTongChi.Name = "flpTongChi";
            flpTongChi.Size = new Size(252, 92);
            flpTongChi.TabIndex = 2;
            // 
            // flpLoiNhuan
            // 
            flpLoiNhuan.BackColor = Color.FromArgb(255, 192, 128);
            flpLoiNhuan.Location = new Point(689, 310);
            flpLoiNhuan.Name = "flpLoiNhuan";
            flpLoiNhuan.Size = new Size(252, 92);
            flpLoiNhuan.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Location = new Point(1400, 791);
            button2.Name = "button2";
            button2.Size = new Size(138, 53);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(33, 417);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 5;
            label3.Text = "Lịch sử thu - chi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(33, 44);
            label4.Name = "label4";
            label4.Size = new Size(187, 21);
            label4.TabIndex = 5;
            label4.Text = "Số lượng món ăn bán ra:";
            // 
            // dgvTonKho
            // 
            dgvTonKho.AllowUserToAddRows = false;
            dgvTonKho.AllowUserToDeleteRows = false;
            dgvTonKho.AllowUserToOrderColumns = true;
            dgvTonKho.AllowUserToResizeColumns = false;
            dgvTonKho.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTonKho.ColumnHeadersHeight = 60;
            dgvTonKho.Location = new Point(986, 77);
            dgvTonKho.Name = "dgvTonKho";
            dgvTonKho.Size = new Size(552, 694);
            dgvTonKho.TabIndex = 8;
            // 
            // formDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 856);
            Controls.Add(dgvTonKho);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flpLoiNhuan);
            Controls.Add(flpTongChi);
            Controls.Add(flpTongThu);
            Controls.Add(dgvBestSeller);
            Controls.Add(dgvLichSuGiaoDich);
            Name = "formDoanhThu";
            Text = "formDoanhThu";
            Load += formDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoDich).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTonKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLichSuGiaoDich;
        private DataGridView dgvBestSeller;
        private FlowLayoutPanel flpTongThu;
        private FlowLayoutPanel flpTongChi;
        private FlowLayoutPanel flpLoiNhuan;
        private Button button2;
        private Label label3;
        private Label label4;
        private DataGridView dgvTonKho;
    }
}