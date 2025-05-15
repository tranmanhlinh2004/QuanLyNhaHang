namespace QuanLyNhaHang
{
    partial class CustomerForm
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
            btnDatban = new Button();
            dataGridView1 = new DataGridView();
            btnOrder = new Button();
            btnPaid = new Button();
            cbPhanloai = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            label3 = new Label();
            label4 = new Label();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDatban
            // 
            btnDatban.Cursor = Cursors.Hand;
            btnDatban.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnDatban.Location = new Point(105, 236);
            btnDatban.Name = "btnDatban";
            btnDatban.Size = new Size(213, 84);
            btnDatban.TabIndex = 0;
            btnDatban.Text = "Đặt bàn";
            btnDatban.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(448, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 65;
            dataGridView1.Size = new Size(886, 584);
            dataGridView1.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnOrder.Location = new Point(105, 383);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(213, 84);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Gọi món";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnPaid
            // 
            btnPaid.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnPaid.Location = new Point(105, 523);
            btnPaid.Name = "btnPaid";
            btnPaid.Size = new Size(213, 84);
            btnPaid.TabIndex = 0;
            btnPaid.Text = "Thanh toán";
            btnPaid.UseVisualStyleBackColor = true;
            // 
            // cbPhanloai
            // 
            cbPhanloai.Font = new Font("Segoe UI", 9F);
            cbPhanloai.FormattingEnabled = true;
            cbPhanloai.Location = new Point(1166, 93);
            cbPhanloai.Name = "cbPhanloai";
            cbPhanloai.Size = new Size(168, 23);
            cbPhanloai.TabIndex = 2;
            cbPhanloai.SelectedIndexChanged += cbPhanloai_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1166, 64);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 3;
            label1.Text = "Phân loại:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(448, 94);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 23);
            txtSearch.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(448, 64);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm món ăn:";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(702, 91);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 28);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(448, 142);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 6;
            label3.Text = "Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 62);
            label4.Name = "label4";
            label4.Size = new Size(236, 88);
            label4.TabIndex = 7;
            label4.Text = "Trang \r\nkhách hàng\r\n";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnReturn.Location = new Point(105, 671);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(213, 84);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Thoát";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 845);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbPhanloai);
            Controls.Add(dataGridView1);
            Controls.Add(btnReturn);
            Controls.Add(btnPaid);
            Controls.Add(btnOrder);
            Controls.Add(btnDatban);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            FormClosing += CustomerForm_FormClosing;
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDatban;
        private DataGridView dataGridView1;
        private Button btnOrder;
        private Button btnPaid;
        private ComboBox cbPhanloai;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Button btnReturn;
    }
}