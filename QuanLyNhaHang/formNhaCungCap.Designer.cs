namespace QuanLyNhaHang
{
    partial class formNhaCungCap
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
            lbSearch = new Label();
            btnClose = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            btnNew = new Button();
            dataGridView = new DataGridView();
            tbSearch = new TextBox();
            tbDiachi = new TextBox();
            tbsđt = new TextBox();
            tbTennhacc = new TextBox();
            lbĐiachi = new Label();
            lbSĐT = new Label();
            lbTennhacc = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(668, 71);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(180, 21);
            lbSearch.TabIndex = 37;
            lbSearch.Text = "Tìm kiếm nhà cung cấp:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClose.Location = new Point(478, 799);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 52);
            btnClose.TabIndex = 30;
            btnClose.Text = "Kết thúc";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(275, 799);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 52);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.Location = new Point(61, 799);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 52);
            btnSave.TabIndex = 32;
            btnSave.Text = "Ghi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(478, 693);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 52);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEdit.Location = new Point(275, 693);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 52);
            btnEdit.TabIndex = 34;
            btnEdit.Text = "Sửa ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(917, 107);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 29);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnNew.Location = new Point(61, 693);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(128, 52);
            btnNew.TabIndex = 36;
            btnNew.Text = "Thêm";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
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
            dataGridView.Location = new Point(668, 166);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.Size = new Size(798, 685);
            dataGridView.TabIndex = 29;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(668, 108);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(227, 29);
            tbSearch.TabIndex = 25;
            // 
            // tbDiachi
            // 
            tbDiachi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbDiachi.Location = new Point(234, 405);
            tbDiachi.Name = "tbDiachi";
            tbDiachi.Size = new Size(241, 29);
            tbDiachi.TabIndex = 26;
            // 
            // tbsđt
            // 
            tbsđt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbsđt.Location = new Point(234, 289);
            tbsđt.Name = "tbsđt";
            tbsđt.Size = new Size(241, 29);
            tbsđt.TabIndex = 27;
            // 
            // tbTennhacc
            // 
            tbTennhacc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbTennhacc.Location = new Point(234, 170);
            tbTennhacc.Name = "tbTennhacc";
            tbTennhacc.Size = new Size(241, 29);
            tbTennhacc.TabIndex = 28;
            // 
            // lbĐiachi
            // 
            lbĐiachi.AutoSize = true;
            lbĐiachi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbĐiachi.Location = new Point(71, 407);
            lbĐiachi.Name = "lbĐiachi";
            lbĐiachi.Size = new Size(79, 21);
            lbĐiachi.TabIndex = 22;
            lbĐiachi.Text = "Địa chỉ(*):";
            // 
            // lbSĐT
            // 
            lbSĐT.AutoSize = true;
            lbSĐT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbSĐT.Location = new Point(71, 289);
            lbSĐT.Name = "lbSĐT";
            lbSĐT.Size = new Size(127, 21);
            lbSĐT.TabIndex = 23;
            lbSĐT.Text = "Số điện thoại(*):";
            // 
            // lbTennhacc
            // 
            lbTennhacc.AutoSize = true;
            lbTennhacc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbTennhacc.Location = new Point(71, 170);
            lbTennhacc.Name = "lbTennhacc";
            lbTennhacc.Size = new Size(156, 21);
            lbTennhacc.TabIndex = 24;
            lbTennhacc.Text = "Tên nhà cung cấp(*):";
            // 
            // formNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 924);
            Controls.Add(lbSearch);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnNew);
            Controls.Add(dataGridView);
            Controls.Add(tbSearch);
            Controls.Add(tbDiachi);
            Controls.Add(tbsđt);
            Controls.Add(tbTennhacc);
            Controls.Add(lbĐiachi);
            Controls.Add(lbSĐT);
            Controls.Add(lbTennhacc);
            Name = "formNhaCungCap";
            Text = "formNhaCungCap";
            Load += formNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbSearch;
        private Button btnClose;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnNew;
        private DataGridView dataGridView;
        private TextBox tbSearch;
        private TextBox tbDiachi;
        private TextBox tbsđt;
        private TextBox tbTennhacc;
        private Label lbĐiachi;
        private Label lbSĐT;
        private Label lbTennhacc;
    }
}