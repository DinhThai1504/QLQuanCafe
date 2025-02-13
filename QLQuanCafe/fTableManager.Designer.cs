namespace QLQuanCafe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ADMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thộngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmChonsoluong = new System.Windows.Forms.NumericUpDown();
            this.btnThemmon = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChuyenban = new System.Windows.Forms.ComboBox();
            this.nmGiamgia = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenban = new System.Windows.Forms.Button();
            this.btnGiamgia = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmChonsoluong)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamgia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADMINToolStripMenuItem,
            this.thộngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ADMINToolStripMenuItem
            // 
            this.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem";
            this.ADMINToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ADMINToolStripMenuItem.Text = "ADMIN";
            this.ADMINToolStripMenuItem.Click += new System.EventHandler(this.ADMINToolStripMenuItem_Click);
            // 
            // thộngTinTàiKhoảnToolStripMenuItem
            // 
            this.thộngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.thộngTinTàiKhoảnToolStripMenuItem.Name = "thộngTinTàiKhoảnToolStripMenuItem";
            this.thộngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.thộngTinTàiKhoảnToolStripMenuItem.Text = "Thộng Tin Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 676);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(580, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 458);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(544, 452);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmChonsoluong);
            this.panel4.Controls.Add(this.btnThemmon);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbLoai);
            this.panel4.Location = new System.Drawing.Point(580, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 62);
            this.panel4.TabIndex = 5;
            // 
            // nmChonsoluong
            // 
            this.nmChonsoluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmChonsoluong.Location = new System.Drawing.Point(471, 22);
            this.nmChonsoluong.Name = "nmChonsoluong";
            this.nmChonsoluong.Size = new System.Drawing.Size(50, 22);
            this.nmChonsoluong.TabIndex = 2;
            this.nmChonsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemmon
            // 
            this.btnThemmon.BackColor = System.Drawing.Color.Aqua;
            this.btnThemmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmon.Location = new System.Drawing.Point(352, 3);
            this.btnThemmon.Name = "btnThemmon";
            this.btnThemmon.Size = new System.Drawing.Size(113, 59);
            this.btnThemmon.TabIndex = 1;
            this.btnThemmon.Text = "Thêm món";
            this.btnThemmon.UseVisualStyleBackColor = false;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(20, 33);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(326, 24);
            this.cbFood.TabIndex = 0;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(20, 3);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(326, 24);
            this.cbLoai.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChuyenban);
            this.panel3.Controls.Add(this.nmGiamgia);
            this.panel3.Controls.Add(this.btnChuyenban);
            this.panel3.Controls.Add(this.btnGiamgia);
            this.panel3.Controls.Add(this.btnThanhtoan);
            this.panel3.Location = new System.Drawing.Point(580, 588);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 98);
            this.panel3.TabIndex = 6;
            // 
            // cbChuyenban
            // 
            this.cbChuyenban.FormattingEnabled = true;
            this.cbChuyenban.Location = new System.Drawing.Point(20, 56);
            this.cbChuyenban.Name = "cbChuyenban";
            this.cbChuyenban.Size = new System.Drawing.Size(121, 24);
            this.cbChuyenban.TabIndex = 4;
            // 
            // nmGiamgia
            // 
            this.nmGiamgia.Location = new System.Drawing.Point(184, 58);
            this.nmGiamgia.Name = "nmGiamgia";
            this.nmGiamgia.Size = new System.Drawing.Size(102, 22);
            this.nmGiamgia.TabIndex = 2;
            this.nmGiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenban
            // 
            this.btnChuyenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenban.Location = new System.Drawing.Point(20, 8);
            this.btnChuyenban.Name = "btnChuyenban";
            this.btnChuyenban.Size = new System.Drawing.Size(121, 42);
            this.btnChuyenban.TabIndex = 1;
            this.btnChuyenban.Text = "Chuyển bàn";
            this.btnChuyenban.UseVisualStyleBackColor = true;
            // 
            // btnGiamgia
            // 
            this.btnGiamgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamgia.Location = new System.Drawing.Point(184, 8);
            this.btnGiamgia.Name = "btnGiamgia";
            this.btnGiamgia.Size = new System.Drawing.Size(102, 44);
            this.btnGiamgia.TabIndex = 1;
            this.btnGiamgia.Text = "Giảm giá";
            this.btnGiamgia.UseVisualStyleBackColor = false;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Location = new System.Drawing.Point(435, 8);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(102, 72);
            this.btnThanhtoan.TabIndex = 1;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 757);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán caffe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmChonsoluong)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ADMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thộngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmChonsoluong;
        private System.Windows.Forms.Button btnThemmon;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbChuyenban;
        private System.Windows.Forms.NumericUpDown nmGiamgia;
        private System.Windows.Forms.Button btnChuyenban;
        private System.Windows.Forms.Button btnGiamgia;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.ListView lsvBill;
    }
}