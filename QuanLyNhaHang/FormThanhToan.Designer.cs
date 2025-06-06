namespace QuanLyNhaHang
{
    partial class FormThanhToan
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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnThanhToan = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtTenMon = new TextBox();
            txtDonGia = new TextBox();
            txtThanhTien = new TextBox();
            txtSoLuong = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtTongTien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(537, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 65;
            dataGridView1.Size = new Size(816, 598);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(537, 49);
            label5.Name = "label5";
            label5.Size = new Size(213, 32);
            label5.TabIndex = 12;
            label5.Text = "Các món đã gọi";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThanhToan.Location = new Point(81, 619);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(162, 66);
            btnThanhToan.TabIndex = 13;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Location = new Point(288, 619);
            button2.Name = "button2";
            button2.Size = new Size(162, 66);
            button2.TabIndex = 13;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(288, 486);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 29);
            comboBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(81, 141);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 15;
            label1.Text = "Tên món ăn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(81, 179);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 15;
            label2.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(81, 217);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 15;
            label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(81, 256);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 15;
            label4.Text = "Thành tiền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(81, 488);
            label6.Name = "label6";
            label6.Size = new Size(190, 21);
            label6.TabIndex = 15;
            label6.Text = "Phương thức thanh toán:";
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTenMon.Location = new Point(288, 139);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.ReadOnly = true;
            txtTenMon.Size = new Size(162, 29);
            txtTenMon.TabIndex = 16;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDonGia.Location = new Point(288, 215);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(162, 29);
            txtDonGia.TabIndex = 16;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtThanhTien.Location = new Point(288, 254);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(162, 29);
            txtThanhTien.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtSoLuong.Location = new Point(288, 177);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.ReadOnly = true;
            txtSoLuong.Size = new Size(162, 29);
            txtSoLuong.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(81, 49);
            label7.Name = "label7";
            label7.Size = new Size(106, 32);
            label7.TabIndex = 12;
            label7.Text = "Chi tiết";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(81, 420);
            label8.Name = "label8";
            label8.Size = new Size(201, 21);
            label8.TabIndex = 15;
            label8.Text = "Tổng tiền phải thanh toán:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTongTien.Location = new Point(288, 418);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(162, 29);
            txtTongTien.TabIndex = 16;
            // 
            // FormThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 785);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTongTien);
            Controls.Add(txtThanhTien);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenMon);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(btnThanhToan);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Name = "FormThanhToan";
            Text = "FormThanhToan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Button btnThanhToan;
        private Button button2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtTenMon;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
        private TextBox txtSoLuong;
        private Label label7;
        private Label label8;
        private TextBox txtTongTien;
    }
}