namespace QuanLyNhaHang
{
    partial class formNhapHang
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvNguyenLieu = new DataGridView();
            txtNhaCC = new TextBox();
            txtNguyenLieu = new TextBox();
            txtSoLuong = new TextBox();
            dgvKho = new DataGridView();
            btnNhapHang = new Button();
            btnThemMoi = new Button();
            btnThoat = new Button();
            dgvNhaCungCap = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 413);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 455);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên nguyên liệu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(56, 500);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 2;
            label3.Text = "Số lượng:";
            // 
            // dgvNguyenLieu
            // 
            dgvNguyenLieu.AllowUserToAddRows = false;
            dgvNguyenLieu.AllowUserToDeleteRows = false;
            dgvNguyenLieu.AllowUserToResizeColumns = false;
            dgvNguyenLieu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNguyenLieu.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNguyenLieu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNguyenLieu.Location = new Point(535, 65);
            dgvNguyenLieu.Name = "dgvNguyenLieu";
            dgvNguyenLieu.Size = new Size(639, 298);
            dgvNguyenLieu.TabIndex = 3;
            dgvNguyenLieu.CellClick += dgvNguyenLieu_CellClick;
            // 
            // txtNhaCC
            // 
            txtNhaCC.Font = new Font("Segoe UI", 12F);
            txtNhaCC.Location = new Point(190, 410);
            txtNhaCC.Name = "txtNhaCC";
            txtNhaCC.Size = new Size(217, 29);
            txtNhaCC.TabIndex = 4;
            // 
            // txtNguyenLieu
            // 
            txtNguyenLieu.Font = new Font("Segoe UI", 12F);
            txtNguyenLieu.Location = new Point(190, 452);
            txtNguyenLieu.Name = "txtNguyenLieu";
            txtNguyenLieu.Size = new Size(217, 29);
            txtNguyenLieu.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 12F);
            txtSoLuong.Location = new Point(190, 497);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(217, 29);
            txtSoLuong.TabIndex = 4;
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToAddRows = false;
            dgvKho.AllowUserToDeleteRows = false;
            dgvKho.AllowUserToResizeColumns = false;
            dgvKho.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvKho.ColumnHeadersHeight = 60;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKho.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKho.Location = new Point(56, 65);
            dgvKho.Name = "dgvKho";
            dgvKho.Size = new Size(428, 298);
            dgvKho.TabIndex = 5;
            dgvKho.CellContentClick += dgvKho_CellContentClick;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnNhapHang.Location = new Point(56, 670);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(128, 53);
            btnNhapHang.TabIndex = 6;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.UseVisualStyleBackColor = true;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThemMoi.Location = new Point(210, 670);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(128, 53);
            btnThemMoi.TabIndex = 6;
            btnThemMoi.Text = "Làm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(368, 670);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 53);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.AllowUserToDeleteRows = false;
            dgvNhaCungCap.AllowUserToResizeColumns = false;
            dgvNhaCungCap.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvNhaCungCap.ColumnHeadersHeight = 60;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvNhaCungCap.DefaultCellStyle = dataGridViewCellStyle6;
            dgvNhaCungCap.Location = new Point(535, 452);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.Size = new Size(639, 271);
            dgvNhaCungCap.TabIndex = 7;
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(535, 410);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 2;
            label4.Text = "Nhà cung cấp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(535, 28);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 2;
            label5.Text = "Nguyên liệu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(56, 28);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 2;
            label6.Text = "Kho:";
            // 
            // formNhapHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 779);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(btnNhapHang);
            Controls.Add(dgvKho);
            Controls.Add(txtSoLuong);
            Controls.Add(txtNguyenLieu);
            Controls.Add(txtNhaCC);
            Controls.Add(dgvNguyenLieu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formNhapHang";
            Text = "formNhapHang";
            Load += formNhapHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvNguyenLieu;
        private TextBox txtNhaCC;
        private TextBox txtNguyenLieu;
        private TextBox txtSoLuong;
        private DataGridView dgvKho;
        private Button btnNhapHang;
        private Button btnThemMoi;
        private Button btnThoat;
        private DataGridView dgvNhaCungCap;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}