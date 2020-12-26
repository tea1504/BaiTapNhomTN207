
namespace QL_HangHoa
{
    partial class frmPhatSinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoThuTu = new System.Windows.Forms.Label();
            this.txtSoThuTu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dgvPhatSinh = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phát sinh";
            // 
            // lblSoThuTu
            // 
            this.lblSoThuTu.AutoSize = true;
            this.lblSoThuTu.Location = new System.Drawing.Point(512, 81);
            this.lblSoThuTu.Name = "lblSoThuTu";
            this.lblSoThuTu.Size = new System.Drawing.Size(96, 25);
            this.lblSoThuTu.TabIndex = 1;
            this.lblSoThuTu.Text = "Số thứ tự:";
            // 
            // txtSoThuTu
            // 
            this.txtSoThuTu.Location = new System.Drawing.Point(632, 78);
            this.txtSoThuTu.Name = "txtSoThuTu";
            this.txtSoThuTu.Size = new System.Drawing.Size(360, 30);
            this.txtSoThuTu.TabIndex = 2;
            this.txtSoThuTu.TextChanged += new System.EventHandler(this.txtSoThuTu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại:";
            // 
            // txtPhieu
            // 
            this.txtPhieu.Location = new System.Drawing.Point(632, 174);
            this.txtPhieu.Name = "txtPhieu";
            this.txtPhieu.Size = new System.Drawing.Size(360, 30);
            this.txtPhieu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phiếu:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(632, 206);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(360, 30);
            this.txtKhachHang.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Khách hàng:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(632, 238);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(360, 30);
            this.txtLyDo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lý do:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên hàng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(632, 302);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(360, 30);
            this.txtSoLuong.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(632, 334);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(360, 30);
            this.txtDonGia.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đơn giá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nhân viên:";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(632, 111);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(360, 30);
            this.dtpNgay.TabIndex = 21;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(632, 140);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(360, 33);
            this.cboLoai.TabIndex = 22;
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Location = new System.Drawing.Point(632, 270);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(360, 33);
            this.cboTenHang.TabIndex = 23;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(632, 366);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(360, 33);
            this.cboNhanVien.TabIndex = 24;
            // 
            // dgvPhatSinh
            // 
            this.dgvPhatSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhatSinh.Location = new System.Drawing.Point(12, 426);
            this.dgvPhatSinh.Name = "dgvPhatSinh";
            this.dgvPhatSinh.RowHeadersWidth = 51;
            this.dgvPhatSinh.RowTemplate.Height = 30;
            this.dgvPhatSinh.Size = new System.Drawing.Size(1420, 295);
            this.dgvPhatSinh.TabIndex = 25;
            this.dgvPhatSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhatSinh_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(453, 743);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 46);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(568, 743);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 46);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(684, 743);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 46);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(800, 743);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 46);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Location = new System.Drawing.Point(916, 743);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(110, 46);
            this.btnKhongLuu.TabIndex = 30;
            this.btnKhongLuu.Text = "Không Lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1032, 743);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 46);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng Form";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmPhatSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 801);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhatSinh);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.cboTenHang);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoThuTu);
            this.Controls.Add(this.lblSoThuTu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhatSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phát sinh";
            this.Load += new System.EventHandler(this.frmPhatSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoThuTu;
        private System.Windows.Forms.TextBox txtSoThuTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DataGridView dgvPhatSinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnDong;
    }
}