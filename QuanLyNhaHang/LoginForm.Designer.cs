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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(66, 66);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(66, 122);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(220, 68);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(169, 23);
            txtTendangnhap.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(220, 124);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '●';
            txtMatkhau.Size = new Size(169, 23);
            txtMatkhau.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(93, 208);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 43);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(336, 208);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 43);
            btnClose.TabIndex = 2;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 282);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTendangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
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
    }
}