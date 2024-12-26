namespace LamViecVoiData
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bảngBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BangKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BangBanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BangChuongTrinhUuDaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngBànToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // bảngBànToolStripMenuItem
            // 
            this.bảngBànToolStripMenuItem.Name = "bảngBànToolStripMenuItem";
            this.bảngBànToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.bảngBànToolStripMenuItem.Text = "Bảng Bàn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bảngToolStripMenuItem
            // 
            this.bảngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BangKhachHangToolStripMenuItem,
            this.BangBanToolStripMenuItem1,
            this.BangChuongTrinhUuDaiToolStripMenuItem});
            this.bảngToolStripMenuItem.Name = "bảngToolStripMenuItem";
            this.bảngToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bảngToolStripMenuItem.Text = "Bảng";
            // 
            // BangKhachHangToolStripMenuItem
            // 
            this.BangKhachHangToolStripMenuItem.Name = "BangKhachHangToolStripMenuItem";
            this.BangKhachHangToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.BangKhachHangToolStripMenuItem.Text = "Bảng khách hàng";
            this.BangKhachHangToolStripMenuItem.Click += new System.EventHandler(this.BangKhachHangToolStripMenuItem_Click);
            // 
            // BangBanToolStripMenuItem1
            // 
            this.BangBanToolStripMenuItem1.Name = "BangBanToolStripMenuItem1";
            this.BangBanToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.BangBanToolStripMenuItem1.Text = "Bảng bàn";
            this.BangBanToolStripMenuItem1.Click += new System.EventHandler(this.BangBanToolStripMenuItem1_Click);
            // 
            // BangChuongTrinhUuDaiToolStripMenuItem
            // 
            this.BangChuongTrinhUuDaiToolStripMenuItem.Name = "BangChuongTrinhUuDaiToolStripMenuItem";
            this.BangChuongTrinhUuDaiToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.BangChuongTrinhUuDaiToolStripMenuItem.Text = "Bảng chương trình ưu đãi";
            this.BangChuongTrinhUuDaiToolStripMenuItem.Click += new System.EventHandler(this.BangChuongTrinhUuDaiToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 651);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bảngBànToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BangKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BangBanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BangChuongTrinhUuDaiToolStripMenuItem;
    }
}