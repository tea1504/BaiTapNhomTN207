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
    public partial class frmHangHoa : Form
    {

        DataSet dsHangHoa = new DataSet();
        DataSet dsLoaiHang = new DataSet();
        DataSet dsDonViTinh = new DataSet();
        bool blnThemMoi = false;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        void DieuKhienKhiBinhThuong() { }

        void DieuKhienKhiThemMoi() { }

        void DieuKhienKhiChinhSua() { }

        void GanDuLieu()
        {
            if(dgvHangHoa.Rows.Count > 0)
            {
                int row = dgvHangHoa.CurrentRow.Index;
                txtMaHang.Text = dgvHangHoa[0, row].Value.ToString();
                txtTenHang.Text = dgvHangHoa[1, row].Value.ToString();
                cboDonViTinh.SelectedValue = dgvHangHoa[2, row].Value.ToString();
                cboLoaiHang.SelectedIndex = cboLoaiHang.FindStringExact(dgvHangHoa[3, row].Value.ToString());
            }
            else
            {
                txtMaHang.Clear();
                txtTenHang.Clear();
                cboDonViTinh.SelectedIndex = -1;
                cboDonViTinh.SelectedIndex = -1;
            }
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            string strSelect = "SELECT MaHang, TenHang, DVTinh, TenLoai FROM HangHoa, LoaiHang WHERE HangHoa.MaLoai = LoaiHang.MaLoai";
            MyPublics.OpenData(strSelect, dsHangHoa, "HangHoa");
            strSelect = "SELECT MaLoai, TenLoai FROM LoaiHang";
            MyPublics.OpenData(strSelect, dsLoaiHang, "LoaiHang");
            dsDonViTinh.Tables.Add("DonViTinh");
            dsDonViTinh.Tables["DonViTinh"].Columns.Add("DonVi");
            dsDonViTinh.Tables["DonViTinh"].Rows.Add("Bộ");
            dsDonViTinh.Tables["DonViTinh"].Rows.Add("Cái");
            dsDonViTinh.Tables["DonViTinh"].Rows.Add("Chai");
            dsDonViTinh.Tables["DonViTinh"].Rows.Add("Gói");
            dsDonViTinh.Tables["DonViTinh"].Rows.Add("Hộp");
            dsDonViTinh.Tables["DonViTinh"].Rows.Add("Kg");
            cboLoaiHang.DataSource = dsLoaiHang.Tables["LoaiHang"];
            cboLoaiHang.ValueMember = "MaLoai";
            cboLoaiHang.DisplayMember = "TenLoai";
            cboDonViTinh.DataSource = dsDonViTinh.Tables["DonViTinh"];
            cboDonViTinh.DisplayMember = "DonVi";
            cboDonViTinh.ValueMember = "DonVi";
            txtMaHang.MaxLength = 5;
            txtTenHang.MaxLength = 20;
            dgvHangHoa.DataSource = dsHangHoa;
            dgvHangHoa.DataMember = "HangHoa";
            dgvHangHoa.Columns[0].HeaderText = "Mã hàng";
            dgvHangHoa.Columns[1].HeaderText = "Tên hàng";
            dgvHangHoa.Columns[2].HeaderText = "Đơn vị";
            dgvHangHoa.Columns[3].HeaderText = "Loại hàng";
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
        }
    }
}
