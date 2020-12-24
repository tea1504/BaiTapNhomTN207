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

        private void frmPhatSinh_Load(object sender, EventArgs e)
        {
            string strSelect = "SELECT PhatSinh.Sott, PhatSinh.Ngay, PhatSinh.Loai, PhatSinh.Phieu, PhatSinh.KhachHang, PhatSinh.LyDo, HangHoa.TenHang, PhatSinh.SoLg, PhatSinh.Dgia, NhanVien.HoLot + ' ' + NhanVien.Ten AS htnv FROM PhatSinh LEFT JOIN HangHoa ON PhatSinh.MaHang = HangHoa.MaHang LEFT JOIN NhanVien ON PhatSinh.MaNV = NhanVien.MaNV ORDER BY PhatSinh.Sott";
            MyPublics.OpenData(strSelect, dsPhatSinh, "PhatSinh");
            strSelect = "SELECT MaHang, TenHang FROM HangHoa";
            MyPublics.OpenData(strSelect, dsTenHang, "HangHoa");
            strSelect = "SELECT MaNV, MaNV + ' - ' + HoLot + ' ' + Ten AS HoTen FROM NhanVien";
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

            dgvPhatSinh.Width = 1136;
        }
    }
}
