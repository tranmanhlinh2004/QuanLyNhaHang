namespace QuanLyNhaHang
{
    partial class Option3
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
            btnThucDon = new Button();
            btnCheBien = new Button();
            SuspendLayout();
            // 
            // btnThucDon
            // 
            btnThucDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThucDon.Location = new Point(358, 135);
            btnThucDon.Name = "btnThucDon";
            btnThucDon.Size = new Size(199, 67);
            btnThucDon.TabIndex = 1;
            btnThucDon.Text = "Thực đơn";
            btnThucDon.UseVisualStyleBackColor = true;
            btnThucDon.Click += btnThucDon_Click;
            // 
            // btnCheBien
            // 
            btnCheBien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheBien.Location = new Point(73, 135);
            btnCheBien.Name = "btnCheBien";
            btnCheBien.Size = new Size(199, 67);
            btnCheBien.TabIndex = 2;
            btnCheBien.Text = "Chế biến";
            btnCheBien.UseVisualStyleBackColor = true;
            btnCheBien.Click += btnCheBien_Click;
            // 
            // Option3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 359);
            Controls.Add(btnThucDon);
            Controls.Add(btnCheBien);
            Name = "Option3";
            Text = "Option3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnThucDon;
        private Button btnCheBien;
    }
}