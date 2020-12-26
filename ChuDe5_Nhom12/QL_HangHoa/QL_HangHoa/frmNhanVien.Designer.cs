
namespace QL_HangHoa
{
    partial class frmNhanVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboQuyenSD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(376, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ lót:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(374, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(376, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(376, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(373, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ghi chú:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(376, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Lương:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(376, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày sinh :";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoLot.Location = new System.Drawing.Point(501, 106);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(480, 30);
            this.txtHoLot.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(501, 268);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(480, 30);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTen.Location = new System.Drawing.Point(501, 142);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(480, 30);
            this.txtTen.TabIndex = 12;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoNam.Location = new System.Drawing.Point(501, 185);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(74, 29);
            this.rdoNam.TabIndex = 14;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoNu.Location = new System.Drawing.Point(610, 181);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(58, 29);
            this.rdoNu.TabIndex = 15;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLuong.Location = new System.Drawing.Point(501, 304);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(480, 30);
            this.txtLuong.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpNgaySinh.Location = new System.Drawing.Point(501, 230);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(480, 30);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(501, 67);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(480, 33);
            this.cboNhanVien.TabIndex = 18;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            // 
            // cboQuyenSD
            // 
            this.cboQuyenSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboQuyenSD.FormattingEnabled = true;
            this.cboQuyenSD.Location = new System.Drawing.Point(501, 376);
            this.cboQuyenSD.Name = "cboQuyenSD";
            this.cboQuyenSD.Size = new System.Drawing.Size(480, 33);
            this.cboQuyenSD.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(374, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quyền dùng:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(376, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mật khẩu:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatKhau.Location = new System.Drawing.Point(501, 415);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(480, 30);
            this.txtMatKhau.TabIndex = 24;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(501, 340);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(480, 30);
            this.txtGhiChu.TabIndex = 25;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(330, 490);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(796, 217);
            this.dgvNV.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(531, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(390, 42);
            this.label11.TabIndex = 27;
            this.label11.Text = "Danh sách nhân viên";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(383, 461);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(625, 461);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(501, 461);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.Location = new System.Drawing.Point(873, 461);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(75, 23);
            this.btnKhongLuu.TabIndex = 31;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(748, 461);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(1002, 461);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 33;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 719);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboQuyenSD);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.ComboBox cboQuyenSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMatKhau;
        public System.Windows.Forms.TextBox txtHoLot;
        public System.Windows.Forms.TextBox txtTen;
        public System.Windows.Forms.DateTimePicker dtpNgaySinh;
        public System.Windows.Forms.ComboBox cboNhanVien;
        public System.Windows.Forms.TextBox txtDiaChi;
        public System.Windows.Forms.TextBox txtLuong;
        public System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}