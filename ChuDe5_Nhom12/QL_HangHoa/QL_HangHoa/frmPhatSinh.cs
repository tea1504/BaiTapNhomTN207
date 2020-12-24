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
        DataSet dsPhatSinh = new DataSet();
        DataSet dsLoai = new DataSet();
        DataSet dsTenHang = new DataSet();
        DataSet dsNhanVien = new DataSet();
        bool blnThem = false;

        public frmPhatSinh()
        {
            InitializeComponent();
        }

        void GanDuLieu()
        {
            if(dgvPhatSinh.Rows.Count > 0)
            {
                int row = dgvPhatSinh.CurrentRow.Index;
                txtSoThuTu.Text = dgvPhatSinh[0, row].Value.ToString();
                dtpNgay.Value = DateTime.Parse(dgvPhatSinh[1, row].Value.ToString());
                cboLoai.SelectedValue = dgvPhatSinh[2, row].Value.ToString();
                txtPhieu.Text = dgvPhatSinh[3, row].Value.ToString();
                txtKhachHang.Text = dgvPhatSinh[4, row].Value.ToString();
                txtLyDo.Text = dgvPhatSinh[5, row].Value.ToString();
                cboTenHang.SelectedIndex = cboTenHang.FindStringExact(dgvPhatSinh[6, row].Value.ToString());
                txtSoLuong.Text = dgvPhatSinh[7, row].Value.ToString();
                txtDonGia.Text = dgvPhatSinh[8, row].Value.ToString();
                cboNhanVien.SelectedIndex = cboNhanVien.FindStringExact(dgvPhatSinh[9, row].Value.ToString());
            }
            else
            {
                txtSoThuTu.Clear();
                cboLoai.SelectedIndex = -1;
                txtPhieu.Clear();
                txtKhachHang.Clear();
                txtLyDo.Clear();
                cboTenHang.SelectedIndex = -1;
                txtSoLuong.Clear();
                txtDonGia.Clear();
                cboNhanVien.SelectedIndex = - 1;
            }
        }

        void DieuKhienKhiBinhThuong()
        {
            if(MyPublics.strQuyenSD == "Quản lý")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            txtSoThuTu.ReadOnly = true;
            txtSoThuTu.BackColor = Color.White;
            dtpNgay.Enabled = false;
            cboLoai.Enabled = false;
            txtPhieu.ReadOnly = true;
            txtPhieu.BackColor = Color.White;
            txtKhachHang.ReadOnly = true;
            txtKhachHang.BackColor = Color.White;
            txtLyDo.ReadOnly = true;
            txtLyDo.BackColor = Color.White;
            cboTenHang.Enabled = false;
            txtSoLuong.ReadOnly = true;
            txtSoLuong.BackColor = Color.White;
            txtDonGia.ReadOnly = true;
            txtDonGia.BackColor = Color.White;
            cboNhanVien.Enabled = false;
            dgvPhatSinh.Enabled = true;
        }

        void DieuKhienKhiThemMoi()
        {

        }

        void DieuKhienThiChinhSua()
        {

        }

        private void frmPhatSinh_Load(object sender, EventArgs e)
        {
            string strSelect = "SELECT PhatSinh.Sott, PhatSinh.Ngay, PhatSinh.Loai, PhatSinh.Phieu, PhatSinh.KhachHang, PhatSinh.LyDo, HangHoa.TenHang, PhatSinh.SoLg, PhatSinh.Dgia, NhanVien.HoLot + ' ' + NhanVien.Ten AS htnv FROM PhatSinh LEFT JOIN HangHoa ON PhatSinh.MaHang = HangHoa.MaHang LEFT JOIN NhanVien ON PhatSinh.MaNV = NhanVien.MaNV ORDER BY PhatSinh.Sott";
            MyPublics.OpenData(strSelect, dsPhatSinh, "PhatSinh");
            strSelect = "SELECT MaHang, TenHang FROM HangHoa";
            MyPublics.OpenData(strSelect, dsTenHang, "HangHoa");
            strSelect = "SELECT MaNV, HoLot + ' ' + Ten AS HoTen FROM NhanVien";
            MyPublics.OpenData(strSelect, dsNhanVien, "NhanVien");
            dsLoai.Tables.Add("DSLoai");
            dsLoai.Tables["DSLoai"].Columns.Add("Loai");
            dsLoai.Tables["DSLoai"].Rows.Add("N");
            dsLoai.Tables["DSLoai"].Rows.Add("X");
            dsLoai.Tables["DSLoai"].Rows.Add("T");
            dsLoai.Tables["DSLoai"].Rows.Add("C");
            cboTenHang.DataSource = dsTenHang.Tables["HangHoa"];
            cboTenHang.ValueMember = "MaHang";
            cboTenHang.DisplayMember = "TenHang";
            cboNhanVien.DataSource = dsNhanVien.Tables["NhanVien"];
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DisplayMember = "HoTen";
            cboLoai.DataSource = dsLoai.Tables["DSLoai"];
            cboLoai.DisplayMember = "Loai";
            cboLoai.ValueMember = "Loai";
            dgvPhatSinh.DataSource = dsPhatSinh;
            dgvPhatSinh.DataMember = "PhatSinh";
            txtPhieu.MaxLength = 4;
            txtKhachHang.MaxLength = 30;
            txtLyDo.MaxLength = 30;
            GanDuLieu();
            dgvPhatSinh.Width = 1136;
            dgvPhatSinh.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            DieuKhienKhiBinhThuong();
        }

        private void dgvPhatSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }
    }
}
