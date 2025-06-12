namespace QuanLyNhaHang
{
    partial class ManageForm
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
            components = new System.ComponentModel.Container();
            btnNhanVien = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnLogout = new Button();
            button7 = new Button();
            label1 = new Label();
            btnQuanLyNhapHang = new Button();
            panel1 = new Panel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flpThongKeBan = new FlowLayoutPanel();
            btnNguyenLieu = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSoDu = new Label();
            panel2 = new Panel();
            panelNhapHang = new Panel();
            btnNhaCungCap = new Button();
            btnNhapHang = new Button();
            panelSubMonAn = new Panel();
            btnThucDon = new Button();
            btnCheBien = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelNhapHang.SuspendLayout();
            panelSubMonAn.SuspendLayout();
            SuspendLayout();
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Teal;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanVien.ForeColor = Color.Transparent;
            btnNhanVien.Location = new Point(-1, 23);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 0, 0);
            btnNhanVien.Size = new Size(207, 61);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Quản lý nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(-1, 136);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(207, 60);
            button2.TabIndex = 0;
            button2.Text = "Quản lý món ăn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(0, 309);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(205, 57);
            button3.TabIndex = 0;
            button3.Text = "Quản lý bàn ăn";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(0, 538);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(205, 52);
            button4.TabIndex = 0;
            button4.Text = "Quản lý hóa đơn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Teal;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(0, 764);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(205, 50);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(0, 587);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(205, 51);
            button7.TabIndex = 0;
            button7.Text = "Thống kê - Doanh thu";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(209, 46);
            label1.Name = "label1";
            label1.Size = new Size(502, 50);
            label1.TabIndex = 1;
            label1.Text = "Hệ thống quản trị nhà hàng";
            // 
            // btnQuanLyNhapHang
            // 
            btnQuanLyNhapHang.BackColor = Color.Teal;
            btnQuanLyNhapHang.FlatAppearance.BorderSize = 0;
            btnQuanLyNhapHang.FlatStyle = FlatStyle.Flat;
            btnQuanLyNhapHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanLyNhapHang.ForeColor = Color.Transparent;
            btnQuanLyNhapHang.Location = new Point(0, 360);
            btnQuanLyNhapHang.Name = "btnQuanLyNhapHang";
            btnQuanLyNhapHang.Padding = new Padding(10, 0, 0, 0);
            btnQuanLyNhapHang.Size = new Size(205, 56);
            btnQuanLyNhapHang.TabIndex = 0;
            btnQuanLyNhapHang.Text = "Quản lý nhập hàng";
            btnQuanLyNhapHang.UseVisualStyleBackColor = false;
            btnQuanLyNhapHang.Click += btnQuanLyNhapHang_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(24, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1556, 140);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(1149, 54);
            label3.Name = "label3";
            label3.Size = new Size(100, 40);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Location = new Point(647, 276);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flpThongKeBan
            // 
            flpThongKeBan.AutoSize = true;
            flpThongKeBan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpThongKeBan.Location = new Point(1173, 219);
            flpThongKeBan.Name = "flpThongKeBan";
            flpThongKeBan.Size = new Size(0, 0);
            flpThongKeBan.TabIndex = 4;
            // 
            // btnNguyenLieu
            // 
            btnNguyenLieu.BackColor = Color.Teal;
            btnNguyenLieu.FlatAppearance.BorderSize = 0;
            btnNguyenLieu.FlatStyle = FlatStyle.Flat;
            btnNguyenLieu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNguyenLieu.ForeColor = Color.Transparent;
            btnNguyenLieu.Location = new Point(-1, 81);
            btnNguyenLieu.Name = "btnNguyenLieu";
            btnNguyenLieu.Padding = new Padding(10, 0, 0, 0);
            btnNguyenLieu.Size = new Size(207, 61);
            btnNguyenLieu.TabIndex = 5;
            btnNguyenLieu.Text = "Quản lý nguyên liệu";
            btnNguyenLieu.UseVisualStyleBackColor = false;
            btnNguyenLieu.Click += btnNguyenLieu_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblSoDu
            // 
            lblSoDu.AutoSize = true;
            lblSoDu.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoDu.ForeColor = Color.LightSeaGreen;
            lblSoDu.Location = new Point(1225, 936);
            lblSoDu.Name = "lblSoDu";
            lblSoDu.Size = new Size(100, 40);
            lblSoDu.TabIndex = 8;
            lblSoDu.Text = "label4";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnNhanVien);
            panel2.Controls.Add(btnQuanLyNhapHang);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(panelNhapHang);
            panel2.Controls.Add(btnNguyenLieu);
            panel2.Controls.Add(panelSubMonAn);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnLogout);
            panel2.Location = new Point(24, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 814);
            panel2.TabIndex = 9;
            // 
            // panelNhapHang
            // 
            panelNhapHang.Controls.Add(btnNhaCungCap);
            panelNhapHang.Controls.Add(btnNhapHang);
            panelNhapHang.Location = new Point(0, 412);
            panelNhapHang.Name = "panelNhapHang";
            panelNhapHang.Size = new Size(205, 126);
            panelNhapHang.TabIndex = 10;
            panelNhapHang.Visible = false;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(0, 64, 64);
            btnNhaCungCap.Dock = DockStyle.Top;
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhaCungCap.ForeColor = Color.Transparent;
            btnNhaCungCap.Location = new Point(0, 58);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10, 0, 0, 0);
            btnNhaCungCap.Size = new Size(205, 64);
            btnNhaCungCap.TabIndex = 0;
            btnNhaCungCap.Text = "Quản lý nhà cung cấp";
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.FromArgb(0, 64, 64);
            btnNhapHang.Dock = DockStyle.Top;
            btnNhapHang.FlatAppearance.BorderSize = 0;
            btnNhapHang.FlatStyle = FlatStyle.Flat;
            btnNhapHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapHang.ForeColor = Color.Transparent;
            btnNhapHang.Location = new Point(0, 0);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Padding = new Padding(10, 0, 0, 0);
            btnNhapHang.Size = new Size(205, 58);
            btnNhapHang.TabIndex = 0;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.UseVisualStyleBackColor = false;
            btnNhapHang.Click += btnNhapHang_Click_1;
            // 
            // panelSubMonAn
            // 
            panelSubMonAn.Controls.Add(btnThucDon);
            panelSubMonAn.Controls.Add(btnCheBien);
            panelSubMonAn.Location = new Point(3, 192);
            panelSubMonAn.Name = "panelSubMonAn";
            panelSubMonAn.Size = new Size(205, 135);
            panelSubMonAn.TabIndex = 10;
            panelSubMonAn.Visible = false;
            // 
            // btnThucDon
            // 
            btnThucDon.BackColor = Color.FromArgb(0, 64, 64);
            btnThucDon.Dock = DockStyle.Top;
            btnThucDon.FlatAppearance.BorderSize = 0;
            btnThucDon.FlatStyle = FlatStyle.Flat;
            btnThucDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThucDon.ForeColor = Color.Transparent;
            btnThucDon.Location = new Point(0, 62);
            btnThucDon.Name = "btnThucDon";
            btnThucDon.Padding = new Padding(10, 0, 0, 0);
            btnThucDon.Size = new Size(205, 58);
            btnThucDon.TabIndex = 0;
            btnThucDon.Text = "Quản lý thực đơn";
            btnThucDon.UseVisualStyleBackColor = false;
            btnThucDon.Click += btnThucDon_Click;
            // 
            // btnCheBien
            // 
            btnCheBien.BackColor = Color.FromArgb(0, 64, 64);
            btnCheBien.Dock = DockStyle.Top;
            btnCheBien.FlatAppearance.BorderSize = 0;
            btnCheBien.FlatStyle = FlatStyle.Flat;
            btnCheBien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheBien.ForeColor = Color.Transparent;
            btnCheBien.Location = new Point(0, 0);
            btnCheBien.Name = "btnCheBien";
            btnCheBien.Padding = new Padding(10, 0, 0, 0);
            btnCheBien.Size = new Size(205, 62);
            btnCheBien.TabIndex = 0;
            btnCheBien.Text = "Chế biến món ăn";
            btnCheBien.UseVisualStyleBackColor = false;
            btnCheBien.Click += btnCheBien_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 1010);
            Controls.Add(panel2);
            Controls.Add(lblSoDu);
            Controls.Add(flpThongKeBan);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageForm";
            Load += ManageForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelNhapHang.ResumeLayout(false);
            panelSubMonAn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNhanVien;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnLogout;
        private Button button7;
        private Label label1;
        private Button btnQuanLyNhapHang;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flpThongKeBan;
        private Button btnNguyenLieu;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label lblSoDu;
        private Panel panel2;
        private Panel panelSubMonAn;
        private Button btnThucDon;
        private Button btnCheBien;
        private Panel panelNhapHang;
        private Button btnNhaCungCap;
        private Button btnNhapHang;
    }
}