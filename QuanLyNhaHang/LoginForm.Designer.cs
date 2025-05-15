namespace QuanLyNhaHang
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtTendangnhap = new TextBox();
            txtMatkhau = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(175, 164);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(175, 239);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(351, 167);
            txtTendangnhap.Margin = new Padding(3, 4, 3, 4);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(220, 27);
            txtTendangnhap.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(351, 241);
            txtMatkhau.Margin = new Padding(3, 4, 3, 4);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '●';
            txtMatkhau.Size = new Size(220, 27);
            txtMatkhau.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(206, 365);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 57);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(423, 365);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 57);
            btnClose.TabIndex = 2;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 75);
            label3.Name = "label3";
            label3.Size = new Size(216, 47);
            label3.TabIndex = 0;
            label3.Text = "Đăng nhập";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(491, 295);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 25);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng ký";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(321, 295);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 14;
            label4.Text = "Chưa có tài khoản?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 491);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTendangnhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTendangnhap;
        private TextBox txtMatkhau;
        private Button btnLogin;
        private Button btnClose;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}