namespace QuanLyNhaHang
{
    partial class formQuanLyNhanVien
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
            dataGridView = new DataGridView();
            btnSearch = new Button();
            label9 = new Label();
            tbSearch = new TextBox();
            btnClose = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            lbNgayvaolam = new Label();
            lbNgaysinh = new Label();
            lbGioitinhnv = new Label();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            tbNgayvaolam = new TextBox();
            tbNgaysinh = new TextBox();
            tbDiachi = new TextBox();
            tbSDTnv = new TextBox();
            tbTennv = new TextBox();
            lbDiachi = new Label();
            lbSDTnv = new Label();
            lbTennv = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(630, 119);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.Size = new Size(1056, 708);
            dataGridView.TabIndex = 38;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(1047, 71);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 31);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(630, 76);
            label9.Name = "label9";
            label9.Size = new Size(142, 21);
            label9.TabIndex = 36;
            label9.Text = "Tìm tên nhân viên:";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSearch.Location = new Point(780, 73);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(237, 29);
            tbSearch.TabIndex = 26;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClose.Location = new Point(441, 723);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 44);
            btnClose.TabIndex = 24;
            btnClose.Text = "Kết thúc";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(441, 636);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 44);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.Location = new Point(59, 723);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 44);
            btnSave.TabIndex = 22;
            btnSave.Text = "Ghi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(255, 723);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 44);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEdit.Location = new Point(255, 636);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 44);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(59, 636);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(131, 44);
            btnNew.TabIndex = 19;
            btnNew.Text = "Thêm";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lbNgayvaolam
            // 
            lbNgayvaolam.AutoSize = true;
            lbNgayvaolam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbNgayvaolam.Location = new Point(60, 471);
            lbNgayvaolam.Name = "lbNgayvaolam";
            lbNgayvaolam.Size = new Size(129, 21);
            lbNgayvaolam.TabIndex = 52;
            lbNgayvaolam.Text = "Ngày vào làm(*):";
            // 
            // lbNgaysinh
            // 
            lbNgaysinh.AutoSize = true;
            lbNgaysinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbNgaysinh.Location = new Point(60, 378);
            lbNgaysinh.Name = "lbNgaysinh";
            lbNgaysinh.Size = new Size(102, 21);
            lbNgaysinh.TabIndex = 51;
            lbNgaysinh.Text = "Ngày sinh(*):";
            // 
            // lbGioitinhnv
            // 
            lbGioitinhnv.AutoSize = true;
            lbGioitinhnv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbGioitinhnv.Location = new Point(60, 555);
            lbGioitinhnv.Name = "lbGioitinhnv";
            lbGioitinhnv.Size = new Size(75, 21);
            lbGioitinhnv.TabIndex = 50;
            lbGioitinhnv.Text = "Giới tính:";
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbNam.Location = new Point(175, 555);
            rbNam.Margin = new Padding(3, 4, 3, 4);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 25);
            rbNam.TabIndex = 49;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbNu.Location = new Point(274, 553);
            rbNu.Margin = new Padding(3, 4, 3, 4);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 25);
            rbNu.TabIndex = 48;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // tbNgayvaolam
            // 
            tbNgayvaolam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbNgayvaolam.Location = new Point(214, 471);
            tbNgayvaolam.Margin = new Padding(3, 4, 3, 4);
            tbNgayvaolam.Name = "tbNgayvaolam";
            tbNgayvaolam.Size = new Size(193, 29);
            tbNgayvaolam.TabIndex = 47;
            // 
            // tbNgaysinh
            // 
            tbNgaysinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbNgaysinh.Location = new Point(214, 378);
            tbNgaysinh.Margin = new Padding(3, 4, 3, 4);
            tbNgaysinh.Name = "tbNgaysinh";
            tbNgaysinh.Size = new Size(193, 29);
            tbNgaysinh.TabIndex = 46;
            // 
            // tbDiachi
            // 
            tbDiachi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbDiachi.Location = new Point(214, 284);
            tbDiachi.Margin = new Padding(3, 4, 3, 4);
            tbDiachi.Name = "tbDiachi";
            tbDiachi.Size = new Size(193, 29);
            tbDiachi.TabIndex = 45;
            // 
            // tbSDTnv
            // 
            tbSDTnv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbSDTnv.Location = new Point(214, 192);
            tbSDTnv.Margin = new Padding(3, 4, 3, 4);
            tbSDTnv.Name = "tbSDTnv";
            tbSDTnv.Size = new Size(193, 29);
            tbSDTnv.TabIndex = 44;
            // 
            // tbTennv
            // 
            tbTennv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbTennv.Location = new Point(214, 108);
            tbTennv.Margin = new Padding(3, 4, 3, 4);
            tbTennv.Name = "tbTennv";
            tbTennv.Size = new Size(193, 29);
            tbTennv.TabIndex = 43;
            // 
            // lbDiachi
            // 
            lbDiachi.AutoSize = true;
            lbDiachi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbDiachi.Location = new Point(60, 284);
            lbDiachi.Name = "lbDiachi";
            lbDiachi.Size = new Size(79, 21);
            lbDiachi.TabIndex = 41;
            lbDiachi.Text = "Địa chỉ(*):";
            // 
            // lbSDTnv
            // 
            lbSDTnv.AutoSize = true;
            lbSDTnv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbSDTnv.Location = new Point(60, 192);
            lbSDTnv.Name = "lbSDTnv";
            lbSDTnv.Size = new Size(105, 21);
            lbSDTnv.TabIndex = 42;
            lbSDTnv.Text = "Điện thoại(*):";
            // 
            // lbTennv
            // 
            lbTennv.AutoSize = true;
            lbTennv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbTennv.Location = new Point(60, 108);
            lbTennv.Name = "lbTennv";
            lbTennv.Size = new Size(129, 21);
            lbTennv.TabIndex = 40;
            lbTennv.Text = "Tên nhân viên(*):";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1514, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 29);
            comboBox1.TabIndex = 53;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(1409, 76);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 36;
            label1.Text = "Giới tính:";
            // 
            // formQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 890);
            Controls.Add(comboBox1);
            Controls.Add(lbNgayvaolam);
            Controls.Add(lbNgaysinh);
            Controls.Add(lbGioitinhnv);
            Controls.Add(rbNam);
            Controls.Add(rbNu);
            Controls.Add(tbNgayvaolam);
            Controls.Add(tbNgaysinh);
            Controls.Add(tbDiachi);
            Controls.Add(tbSDTnv);
            Controls.Add(tbTennv);
            Controls.Add(lbDiachi);
            Controls.Add(lbSDTnv);
            Controls.Add(lbTennv);
            Controls.Add(dataGridView);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(tbSearch);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Name = "formQuanLyNhanVien";
            Text = "formQuanLyNhanVien";
            Load += formQuanLyNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView;
        private Button btnSearch;
        private Label label9;
        private TextBox tbSearch;
        private Button btnClose;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnNew;
        private Label lbNgayvaolam;
        private Label lbNgaysinh;
        private Label lbGioitinhnv;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private TextBox tbNgayvaolam;
        private TextBox tbNgaysinh;
        private TextBox tbDiachi;
        private TextBox tbSDTnv;
        private TextBox tbTennv;
        private Label lbDiachi;
        private Label lbSDTnv;
        private Label lbTennv;
        private ComboBox comboBox1;
        private Label label1;
    }
}