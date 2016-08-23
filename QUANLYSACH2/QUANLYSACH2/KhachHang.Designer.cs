namespace QUANLYSACH2
{
    partial class KhachHang
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
            this.danhSachKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsxem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsthem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsxoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnssưa = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachKhachHangToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSachKhachHangToolStripMenuItem
            // 
            this.danhSachKhachHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsxem,
            this.mnsthem,
            this.mnsxoa,
            this.mnssưa});
            this.danhSachKhachHangToolStripMenuItem.Name = "danhSachKhachHangToolStripMenuItem";
            this.danhSachKhachHangToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.danhSachKhachHangToolStripMenuItem.Text = "Khách Hàng";
            // 
            // mnsxem
            // 
            this.mnsxem.Name = "mnsxem";
            this.mnsxem.Size = new System.Drawing.Size(225, 22);
            this.mnsxem.Text = "Xem Danh Sách Khách Hàng";
            this.mnsxem.Click += new System.EventHandler(this.XemDanhSachKhachHang_Click);
            // 
            // mnsthem
            // 
            this.mnsthem.Name = "mnsthem";
            this.mnsthem.Size = new System.Drawing.Size(225, 22);
            this.mnsthem.Text = "Thêm Khách Hàng";
            this.mnsthem.Click += new System.EventHandler(this.ThemKhachHang_Click);
            // 
            // mnsxoa
            // 
            this.mnsxoa.Name = "mnsxoa";
            this.mnsxoa.Size = new System.Drawing.Size(225, 22);
            this.mnsxoa.Text = "Xóa Khách Hàng";
            this.mnsxoa.Click += new System.EventHandler(this.XoaKhachHang_Click);
            // 
            // mnssưa
            // 
            this.mnssưa.Name = "mnssưa";
            this.mnssưa.Size = new System.Drawing.Size(225, 22);
            this.mnssưa.Text = "Sửa Khách Hàng";
            this.mnssưa.Click += new System.EventHandler(this.SuaKhachHang_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 328);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSachKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsxem;
        private System.Windows.Forms.ToolStripMenuItem mnsthem;
        private System.Windows.Forms.ToolStripMenuItem mnsxoa;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnssưa;
    }
}