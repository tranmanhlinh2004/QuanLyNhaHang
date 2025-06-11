namespace QuanLyNhaHang
{
    partial class formQuanLyBanAn
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
            flpBan = new FlowLayoutPanel();
            dgvChiTietBan = new DataGridView();
            lblTongTien = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBan).BeginInit();
            SuspendLayout();
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.Font = new Font("Arial Rounded MT Bold", 13F);
            flpBan.Location = new Point(655, 54);
            flpBan.Name = "flpBan";
            flpBan.Size = new Size(862, 572);
            flpBan.TabIndex = 1;
            // 
            // dgvChiTietBan
            // 
            dgvChiTietBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietBan.Location = new Point(53, 54);
            dgvChiTietBan.Name = "dgvChiTietBan";
            dgvChiTietBan.Size = new Size(535, 435);
            dgvChiTietBan.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(53, 576);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 30);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(450, 576);
            button1.Name = "button1";
            button1.Size = new Size(138, 50);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formQuanLyBanAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 716);
            Controls.Add(button1);
            Controls.Add(lblTongTien);
            Controls.Add(dgvChiTietBan);
            Controls.Add(flpBan);
            Name = "formQuanLyBanAn";
            Text = "formQuanLyBanAn";
            Load += formQuanLyBanAn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpBan;
        private DataGridView dgvChiTietBan;
        private Label lblTongTien;
        private Button button1;
    }
}