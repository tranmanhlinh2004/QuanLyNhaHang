namespace QuanLyNhaHang
{
    partial class IdSearch
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
            txtIdBan = new TextBox();
            btnThanhToan = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 98);
            label1.Name = "label1";
            label1.Size = new Size(313, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập id bàn bạn muốn thanh toán:";
            // 
            // txtIdBan
            // 
            txtIdBan.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBan.Location = new Point(396, 90);
            txtIdBan.Name = "txtIdBan";
            txtIdBan.Size = new Size(140, 33);
            txtIdBan.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(97, 193);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(199, 61);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(357, 193);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(199, 61);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // IdSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 326);
            Controls.Add(btnThoat);
            Controls.Add(btnThanhToan);
            Controls.Add(txtIdBan);
            Controls.Add(label1);
            Name = "IdSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IdSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdBan;
        private Button btnThanhToan;
        private Button btnThoat;
    }
}