namespace QuanLyNhaHang
{
    partial class DatBanForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdBan = new TextBox();
            txtSochongoi = new TextBox();
            txtTrangthai = new TextBox();
            btnDatban = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.Font = new Font("Arial Rounded MT Bold", 13F);
            flpBan.Location = new Point(512, 77);
            flpBan.Name = "flpBan";
            flpBan.Size = new Size(862, 572);
            flpBan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(65, 102);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 1;
            label1.Text = "id Bàn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(65, 153);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Số chỗ ngồi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(65, 203);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 1;
            label3.Text = "Trạng thái:";
            // 
            // txtIdBan
            // 
            txtIdBan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtIdBan.Location = new Point(184, 102);
            txtIdBan.Name = "txtIdBan";
            txtIdBan.ReadOnly = true;
            txtIdBan.Size = new Size(172, 29);
            txtIdBan.TabIndex = 2;
            // 
            // txtSochongoi
            // 
            txtSochongoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtSochongoi.Location = new Point(184, 153);
            txtSochongoi.Name = "txtSochongoi";
            txtSochongoi.ReadOnly = true;
            txtSochongoi.Size = new Size(172, 29);
            txtSochongoi.TabIndex = 2;
            // 
            // txtTrangthai
            // 
            txtTrangthai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTrangthai.Location = new Point(184, 208);
            txtTrangthai.Name = "txtTrangthai";
            txtTrangthai.ReadOnly = true;
            txtTrangthai.Size = new Size(172, 29);
            txtTrangthai.TabIndex = 2;
            // 
            // btnDatban
            // 
            btnDatban.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnDatban.Location = new Point(65, 561);
            btnDatban.Name = "btnDatban";
            btnDatban.Size = new Size(159, 71);
            btnDatban.TabIndex = 3;
            btnDatban.Text = "Đặt bàn";
            btnDatban.UseVisualStyleBackColor = true;
            btnDatban.Click += btnDatban_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnReturn.Location = new Point(284, 561);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(159, 71);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Thoát";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // DatBanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 699);
            Controls.Add(btnReturn);
            Controls.Add(btnDatban);
            Controls.Add(txtTrangthai);
            Controls.Add(txtSochongoi);
            Controls.Add(txtIdBan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpBan);
            Name = "DatBanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatBan";
            Load += DatBan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpBan;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdBan;
        private TextBox txtSochongoi;
        private TextBox txtTrangthai;
        private Button btnDatban;
        private Button btnReturn;
    }
}