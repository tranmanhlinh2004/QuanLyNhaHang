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
            btnDatban = new Button();
            dataGridView1 = new DataGridView();
            btnOrder = new Button();
            btnPaid = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
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
            btnDatban.Font = new Font("Segoe UI", 16F);
            btnDatban.Location = new Point(93, 212);
            btnDatban.Name = "btnDatban";
            btnDatban.Size = new Size(213, 84);
            btnDatban.TabIndex = 0;
            btnDatban.Text = "Đặt bàn";
            btnDatban.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(448, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(813, 556);
            dataGridView1.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 16F);
            btnOrder.Location = new Point(93, 359);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(213, 84);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Gọi món";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnPaid
            // 
            btnPaid.Font = new Font("Segoe UI", 16F);
            btnPaid.Location = new Point(93, 499);
            btnPaid.Name = "btnPaid";
            btnPaid.Size = new Size(213, 84);
            btnPaid.TabIndex = 0;
            btnPaid.Text = "Thanh toán";
            btnPaid.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1093, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 27);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1093, 65);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 3;
            label1.Text = "Phân loại:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(448, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(448, 64);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm món ăn:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(702, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 28);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(448, 142);
            label3.Name = "label3";
            label3.Size = new Size(107, 39);
            label3.TabIndex = 6;
            label3.Text = "Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 62);
            label4.Name = "label4";
            label4.Size = new Size(287, 108);
            label4.TabIndex = 7;
            label4.Text = "Trang \r\nkhách hàng\r\n";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 16F);
            btnReturn.Location = new Point(93, 647);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(213, 84);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Thoát";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 813);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDatban;
        private DataGridView dataGridView1;
        private Button btnOrder;
        private Button btnPaid;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Button btnReturn;
    }
}