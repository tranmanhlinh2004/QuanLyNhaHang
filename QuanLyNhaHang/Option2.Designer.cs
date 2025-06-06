namespace QuanLyNhaHang
{
    partial class Option2
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
            btnNhaCC = new Button();
            btnNhapHang = new Button();
            SuspendLayout();
            // 
            // btnNhaCC
            // 
            btnNhaCC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhaCC.Location = new Point(74, 113);
            btnNhaCC.Name = "btnNhaCC";
            btnNhaCC.Size = new Size(199, 67);
            btnNhaCC.TabIndex = 0;
            btnNhaCC.Text = "Quản lý nhà cung cấp";
            btnNhaCC.UseVisualStyleBackColor = true;
            btnNhaCC.Click += btnNhaCC_Click;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapHang.Location = new Point(359, 113);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(199, 67);
            btnNhapHang.TabIndex = 0;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.UseVisualStyleBackColor = true;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // Option2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 325);
            Controls.Add(btnNhapHang);
            Controls.Add(btnNhaCC);
            Name = "Option2";
            Text = "formNhapHang";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNhaCC;
        private Button btnNhapHang;
    }
}