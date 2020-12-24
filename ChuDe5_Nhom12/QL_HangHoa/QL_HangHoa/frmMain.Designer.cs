namespace QL_HangHoa
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
            this.mnuQLBanHang = new System.Windows.Forms.MenuStrip();
            this.mnuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhatSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQLBanHang
            // 
            this.mnuQLBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDuLieu,
            this.mnuTienIch,
            this.mnuThoat});
            this.mnuQLBanHang.Location = new System.Drawing.Point(0, 0);
            this.mnuQLBanHang.Name = "mnuQLBanHang";
            this.mnuQLBanHang.Size = new System.Drawing.Size(671, 24);
            this.mnuQLBanHang.TabIndex = 0;
            this.mnuQLBanHang.Text = "menuStrip1";
            // 
            // mnuDuLieu
            // 
            this.mnuDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuHangHoa,
            this.mnuLoaiHang,
            this.mnuPhatSinh});
            this.mnuDuLieu.Name = "mnuDuLieu";
            this.mnuDuLieu.Size = new System.Drawing.Size(59, 20);
            this.mnuDuLieu.Text = "Dữ Liệu";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(129, 22);
            this.mnuNhanVien.Text = "Nhân Viên";
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(129, 22);
            this.mnuHangHoa.Text = "Hàng Hóa";
            this.mnuHangHoa.Click += new System.EventHandler(this.mnuHangHoa_Click);
            // 
            // mnuLoaiHang
            // 
            this.mnuLoaiHang.Name = "mnuLoaiHang";
            this.mnuLoaiHang.Size = new System.Drawing.Size(129, 22);
            this.mnuLoaiHang.Text = "Loại Hàng";
            // 
            // mnuPhatSinh
            // 
            this.mnuPhatSinh.Name = "mnuPhatSinh";
            this.mnuPhatSinh.Size = new System.Drawing.Size(152, 22);
            this.mnuPhatSinh.Text = "Phát Sinh";
            this.mnuPhatSinh.Click += new System.EventHandler(this.mnuPhatSinh_Click);
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuThoatDangNhap,
            this.mnuDoiMatKhau,
            this.mnuGioiThieu});
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(60, 20);
            this.mnuTienIch.Text = "Tiện Ích";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(167, 22);
            this.mnuDangNhap.Text = "Đăng Nhập";
            // 
            // mnuThoatDangNhap
            // 
            this.mnuThoatDangNhap.Name = "mnuThoatDangNhap";
            this.mnuThoatDangNhap.Size = new System.Drawing.Size(167, 22);
            this.mnuThoatDangNhap.Text = "Thoát Đăng Nhập";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(167, 22);
            this.mnuDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(167, 22);
            this.mnuGioiThieu.Text = "Giới Thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(49, 20);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 439);
            this.Controls.Add(this.mnuQLBanHang);
            this.MainMenuStrip = this.mnuQLBanHang;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuQLBanHang.ResumeLayout(false);
            this.mnuQLBanHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQLBanHang;
        public System.Windows.Forms.ToolStripMenuItem mnuDuLieu;
        public System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        public System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        public System.Windows.Forms.ToolStripMenuItem mnuLoaiHang;
        public System.Windows.Forms.ToolStripMenuItem mnuPhatSinh;
        public System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuThoatDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}

