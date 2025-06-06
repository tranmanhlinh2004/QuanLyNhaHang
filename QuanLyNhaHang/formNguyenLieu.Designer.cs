namespace QuanLyNhaHang
{
    partial class formNguyenLieu
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
            btnClose = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            btnNew = new Button();
            dataGridView = new DataGridView();
            tbSearch = new TextBox();
            tbDongia = new TextBox();
            tbDonvitinh = new TextBox();
            tbTennglieu = new TextBox();
            lbSearch = new Label();
            lbDongia = new Label();
            lbDonvitinh = new Label();
            lbTenNglieu = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnClose.Location = new Point(327, 525);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 60);
            btnClose.TabIndex = 13;
            btnClose.Text = "Kết thúc";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnCancel.Location = new Point(179, 525);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 60);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnSave.Location = new Point(35, 525);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 60);
            btnSave.TabIndex = 15;
            btnSave.Text = "Ghi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnDelete.Location = new Point(327, 440);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 60);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnEdit.Location = new Point(179, 440);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 60);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Sửa ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(908, 45);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 33);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnNew.Location = new Point(35, 440);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(124, 60);
            btnNew.TabIndex = 19;
            btnNew.Text = "Thêm";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 60;
            dataGridView.Location = new Point(505, 103);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.Size = new Size(641, 531);
            dataGridView.TabIndex = 12;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(686, 49);
            tbSearch.Margin = new Padding(2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(209, 29);
            tbSearch.TabIndex = 8;
            // 
            // tbDongia
            // 
            tbDongia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbDongia.Location = new Point(219, 257);
            tbDongia.Margin = new Padding(2);
            tbDongia.Name = "tbDongia";
            tbDongia.Size = new Size(159, 29);
            tbDongia.TabIndex = 9;
            // 
            // tbDonvitinh
            // 
            tbDonvitinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbDonvitinh.Location = new Point(219, 181);
            tbDonvitinh.Margin = new Padding(2);
            tbDonvitinh.Name = "tbDonvitinh";
            tbDonvitinh.Size = new Size(159, 29);
            tbDonvitinh.TabIndex = 10;
            // 
            // tbTennglieu
            // 
            tbTennglieu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbTennglieu.Location = new Point(219, 103);
            tbTennglieu.Margin = new Padding(2);
            tbTennglieu.Name = "tbTennglieu";
            tbTennglieu.Size = new Size(159, 29);
            tbTennglieu.TabIndex = 11;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(504, 51);
            lbSearch.Margin = new Padding(2, 0, 2, 0);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(168, 21);
            lbSearch.TabIndex = 4;
            lbSearch.Text = "Tìm kiếm nguyên liệu:";
            // 
            // lbDongia
            // 
            lbDongia.AutoSize = true;
            lbDongia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbDongia.Location = new Point(72, 259);
            lbDongia.Margin = new Padding(2, 0, 2, 0);
            lbDongia.Name = "lbDongia";
            lbDongia.Size = new Size(70, 21);
            lbDongia.TabIndex = 5;
            lbDongia.Text = "Đơn giá:";
            // 
            // lbDonvitinh
            // 
            lbDonvitinh.AutoSize = true;
            lbDonvitinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbDonvitinh.Location = new Point(72, 182);
            lbDonvitinh.Margin = new Padding(2, 0, 2, 0);
            lbDonvitinh.Name = "lbDonvitinh";
            lbDonvitinh.Size = new Size(92, 21);
            lbDonvitinh.TabIndex = 6;
            lbDonvitinh.Text = "Đơn vị tính:";
            // 
            // lbTenNglieu
            // 
            lbTenNglieu.AutoSize = true;
            lbTenNglieu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbTenNglieu.Location = new Point(72, 103);
            lbTenNglieu.Margin = new Padding(2, 0, 2, 0);
            lbTenNglieu.Name = "lbTenNglieu";
            lbTenNglieu.Size = new Size(127, 21);
            lbTenNglieu.TabIndex = 7;
            lbTenNglieu.Text = "Tên nguyên liệu:";
            // 
            // formNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 770);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnNew);
            Controls.Add(dataGridView);
            Controls.Add(tbSearch);
            Controls.Add(tbDongia);
            Controls.Add(tbDonvitinh);
            Controls.Add(tbTennglieu);
            Controls.Add(lbSearch);
            Controls.Add(lbDongia);
            Controls.Add(lbDonvitinh);
            Controls.Add(lbTenNglieu);
            Name = "formNguyenLieu";
            Text = "formNguyenLieu";
            Load += formNguyenLieu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnNew;
        private DataGridView dataGridView;
        private TextBox tbSearch;
        private TextBox tbDongia;
        private TextBox tbDonvitinh;
        private TextBox tbTennglieu;
        private Label lbSearch;
        private Label lbDongia;
        private Label lbDonvitinh;
        private Label lbTenNglieu;
    }
}