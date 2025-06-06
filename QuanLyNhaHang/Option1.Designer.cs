namespace QuanLyNhaHang
{
    partial class Option1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            SuspendLayout();
            // 
            // btnKhachHang
            // 
            btnKhachHang.Font = new Font("Segoe UI", 16F);
            btnKhachHang.Location = new Point(369, 114);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(181, 66);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Font = new Font("Segoe UI", 16F);
            btnNhanVien.Location = new Point(63, 114);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(188, 66);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 297);
            Controls.Add(btnNhanVien);
            Controls.Add(btnKhachHang);
            Name = "OptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OptionForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKhachHang;
        private Button btnNhanVien;
    }
}
