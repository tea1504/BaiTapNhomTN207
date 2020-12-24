using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HangHoa
{
    public partial class frmPhatSinh : Form
    {
        private Button btnDong;
        private Button btnKhongLuu;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvPhatSinh;
        private ComboBox cboLoai;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tctSTT;
        private Label label2;
        private TextBox txtKhachHang;
        private Label label6;
        private TextBox txtLyDo;
        private Label label7;
        private Label label8;
        private TextBox txtSoLuong;
        private Label label9;
        private TextBox txtGia;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpNgay;
        private TextBox txtPhieu;
        private ComboBox cboTenHang;
        private ComboBox cboNhanVien;
        private Label label1;

        public frmPhatSinh()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnDong = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhatSinh = new System.Windows.Forms.DataGridView();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tctSTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtPhieu = new System.Windows.Forms.TextBox();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(619, 737);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(106, 42);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng form";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Location = new System.Drawing.Point(507, 737);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(106, 42);
            this.btnKhongLuu.TabIndex = 30;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(395, 737);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 42);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(283, 737);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 42);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(171, 737);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 42);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.Location = new System.Drawing.Point(59, 737);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 42);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvPhatSinh
            // 
            this.dgvPhatSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhatSinh.Location = new System.Drawing.Point(33, 444);
            this.dgvPhatSinh.Name = "dgvPhatSinh";
            this.dgvPhatSinh.RowTemplate.Height = 30;
            this.dgvPhatSinh.Size = new System.Drawing.Size(708, 255);
            this.dgvPhatSinh.TabIndex = 25;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(276, 160);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(229, 28);
            this.cboLoai.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày:";
            // 
            // tctSTT
            // 
            this.tctSTT.Location = new System.Drawing.Point(276, 88);
            this.tctSTT.Name = "tctSTT";
            this.tctSTT.Size = new System.Drawing.Size(229, 26);
            this.tctSTT.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số thứ tự";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách phát sinh";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(276, 238);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(229, 26);
            this.txtKhachHang.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Khách hàng:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(276, 270);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(229, 26);
            this.txtLyDo.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Lý do:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tên hàng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(276, 334);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(229, 26);
            this.txtSoLuong.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Số lượng:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(276, 366);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(229, 26);
            this.txtGia.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Giá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Nhân viên:";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/mm/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(276, 120);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(229, 26);
            this.dtpNgay.TabIndex = 44;
            // 
            // txtPhieu
            // 
            this.txtPhieu.Location = new System.Drawing.Point(276, 196);
            this.txtPhieu.Name = "txtPhieu";
            this.txtPhieu.Size = new System.Drawing.Size(229, 26);
            this.txtPhieu.TabIndex = 45;
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Location = new System.Drawing.Point(276, 302);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(229, 28);
            this.cboTenHang.TabIndex = 46;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(276, 398);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(229, 28);
            this.cboNhanVien.TabIndex = 47;
            // 
            // frmPhatSinh
            // 
            this.ClientSize = new System.Drawing.Size(780, 796);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.cboTenHang);
            this.Controls.Add(this.txtPhieu);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhatSinh);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tctSTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhatSinh";
            this.Text = "Danh sách phát sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
