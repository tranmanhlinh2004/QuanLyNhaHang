namespace QuanLyNhaHang
{
    partial class SignUpForm
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
            btnSignUp = new Button();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtXacnhanmatkhau = new TextBox();
            txtMatkhaudangky = new TextBox();
            txtTendangky = new TextBox();
            btnClose = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI", 12F);
            btnSignUp.Location = new Point(111, 303);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(125, 55);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Đăng kí";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtXacnhanmatkhau);
            groupBox1.Controls.Add(txtMatkhaudangky);
            groupBox1.Controls.Add(txtTendangky);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnSignUp);
            groupBox1.Location = new Point(107, 119);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(666, 407);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(399, 260);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 25);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng nhập";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(252, 260);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 12;
            label2.Text = "Đã có tài khoản?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(49, 207);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 10;
            label1.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(49, 149);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 10;
            label5.Text = "Mật khẩu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(49, 96);
            label6.Name = "label6";
            label6.Size = new Size(179, 32);
            label6.TabIndex = 11;
            label6.Text = "Tên đăng nhập:";
            // 
            // txtXacnhanmatkhau
            // 
            txtXacnhanmatkhau.Location = new Point(279, 209);
            txtXacnhanmatkhau.Margin = new Padding(3, 4, 3, 4);
            txtXacnhanmatkhau.Name = "txtXacnhanmatkhau";
            txtXacnhanmatkhau.PasswordChar = '●';
            txtXacnhanmatkhau.Size = new Size(213, 27);
            txtXacnhanmatkhau.TabIndex = 2;
            // 
            // txtMatkhaudangky
            // 
            txtMatkhaudangky.Location = new Point(279, 154);
            txtMatkhaudangky.Margin = new Padding(3, 4, 3, 4);
            txtMatkhaudangky.Name = "txtMatkhaudangky";
            txtMatkhaudangky.PasswordChar = '●';
            txtMatkhaudangky.Size = new Size(213, 27);
            txtMatkhaudangky.TabIndex = 1;
            // 
            // txtTendangky
            // 
            txtTendangky.Location = new Point(279, 96);
            txtTendangky.Margin = new Padding(3, 4, 3, 4);
            txtTendangky.Name = "txtTendangky";
            txtTendangky.Size = new Size(213, 27);
            txtTendangky.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(328, 303);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 55);
            btnClose.TabIndex = 4;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(351, 43);
            label4.Name = "label4";
            label4.Size = new Size(160, 47);
            label4.TabIndex = 10;
            label4.Text = "Đăng kí";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 636);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            FormClosing += SignUpForm_FormClosing;
            Load += SignUpForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private GroupBox groupBox1;
        private TextBox txtXacnhanmatkhau;
        private TextBox txtMatkhaudangky;
        private TextBox txtTendangky;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button btnClose;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}