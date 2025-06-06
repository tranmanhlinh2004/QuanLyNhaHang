namespace QuanLyNhaHang
{
    partial class formQuanLyThucDon
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnThemmoi = new Button();
            txtDonGia = new TextBox();
            label3 = new Label();
            txtTenMonAn = new TextBox();
            cboPhanLoai = new ComboBox();
            btnGhi = new Button();
            btnSua = new Button();
            btnhuybo = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label4 = new Label();
            txtSoLuong = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(561, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(681, 502);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(88, 88);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên món ăn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(88, 153);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Phân loại:";
            // 
            // btnThemmoi
            // 
            btnThemmoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThemmoi.Location = new Point(88, 479);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(113, 48);
            btnThemmoi.TabIndex = 2;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDonGia.Location = new Point(196, 213);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(291, 29);
            txtDonGia.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(88, 213);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 1;
            label3.Text = "Đơn giá:";
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTenMonAn.Location = new Point(196, 88);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(291, 29);
            txtTenMonAn.TabIndex = 3;
            // 
            // cboPhanLoai
            // 
            cboPhanLoai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboPhanLoai.FormattingEnabled = true;
            cboPhanLoai.Location = new Point(196, 153);
            cboPhanLoai.Name = "cboPhanLoai";
            cboPhanLoai.Size = new Size(291, 29);
            cboPhanLoai.TabIndex = 4;
            // 
            // btnGhi
            // 
            btnGhi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGhi.Location = new Point(88, 542);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(113, 48);
            btnGhi.TabIndex = 2;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSua.Location = new Point(229, 479);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(113, 48);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnhuybo
            // 
            btnhuybo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnhuybo.Location = new Point(229, 542);
            btnhuybo.Name = "btnhuybo";
            btnhuybo.Size = new Size(113, 48);
            btnhuybo.TabIndex = 2;
            btnhuybo.Text = "Hủy";
            btnhuybo.UseVisualStyleBackColor = true;
            btnhuybo.Click += btnhuybo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(374, 479);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 48);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(374, 542);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 48);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(88, 276);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 1;
            label4.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtSoLuong.Location = new Point(196, 276);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(291, 29);
            txtSoLuong.TabIndex = 3;
            // 
            // formQuanLyThucDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 692);
            Controls.Add(cboPhanLoai);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenMonAn);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnhuybo);
            Controls.Add(btnSua);
            Controls.Add(btnGhi);
            Controls.Add(label4);
            Controls.Add(btnThemmoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "formQuanLyThucDon";
            Text = "formQuanLyThucDon";
            Load += formQuanLyThucDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button btnThemmoi;
        private TextBox txtDonGia;
        private Label label3;
        private TextBox txtTenMonAn;
        private ComboBox cboPhanLoai;
        private Button btnGhi;
        private Button btnSua;
        private Button btnhuybo;
        private Button btnXoa;
        private Button btnThoat;
        private Label label4;
        private TextBox txtSoLuong;
    }
}