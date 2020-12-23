using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HangHoa
{
    public partial class frmHangHoa : Form
    {
        bool blnThem;
        DataSet dsHangHoa = new DataSet();
        DataSet dsDonViTinh = new DataSet();
        DataSet dsLoai = new DataSet();

        public frmHangHoa()
        {
            InitializeComponent();
        }

        void DieuKhienKhiBinhThuong()
        {
            MyPublics.strQuyenSD = "Quản Lý";//Xóa khi có đăng nhập
            if (MyPublics.strQuyenSD == "Quản Lý")
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
            btnDong.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            txtMaHang.ReadOnly = true;
            txtMaHang.BackColor = Color.White;
            txtTenHang.ReadOnly = true;
            txtTenHang.BackColor = Color.White;
            cboDonViTinh.Enabled = false;
            cboMaLoai.Enabled = false;
            dgvHangHoa.Enabled = true;
        }

        void DieuKienKhiThem()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnDong.Enabled = false;
            dgvHangHoa.Enabled = false;
            txtMaHang.ReadOnly = false;
            txtTenHang.ReadOnly = false;
            txtMaHang.Clear();
            txtTenHang.Clear();
            cboDonViTinh.Enabled = true;
            cboDonViTinh.SelectedIndex = -1;
            cboMaLoai.Enabled = true;
            cboMaLoai.SelectedIndex = -1;
            txtMaHang.Focus();
        }

        void DieuKienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnDong.Enabled = false;
            dgvHangHoa.Enabled = false;
            txtTenHang.ReadOnly = false;
            cboDonViTinh.Enabled = true;
            cboMaLoai.Enabled = true;
            txtTenHang.Focus();
        }

        void GanDuLieu()
        {
            if (dsHangHoa.Tables["HangHoa"].Rows.Count > 0)
            {
                int row = dgvHangHoa.CurrentRow.Index;
                txtMaHang.Text = dgvHangHoa[0, row].Value.ToString();
                txtTenHang.Text = dgvHangHoa[1, row].Value.ToString();
                cboDonViTinh.SelectedValue = dgvHangHoa[2, row].Value.ToString();
                cboMaLoai.SelectedIndex = cboMaLoai.FindStringExact(dgvHangHoa[3, row].Value.ToString());
            }
            else
            {
                txtMaHang.Clear();
                txtTenHang.Clear();
                cboDonViTinh.SelectedIndex = -1;
                cboMaLoai.SelectedIndex = -1;
            }
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            string strSelect = "SELECT MaHang, TenHang, DVTinh, TenLoai FROM HangHoa, LoaiHang WHERE HangHoa.MaLoai = LoaiHang.MaLoai";
            MyPublics.ConnectDatabase(); //Bỏ khi có form đăng nhập
            MyPublics.OpenData(strSelect, dsHangHoa, "HangHoa");
            strSelect = "SELECT MaLoai, TenLoai FROM LoaiHang";
            MyPublics.OpenData(strSelect, dsLoai, "Loai");
            cboMaLoai.DataSource = dsLoai.Tables["Loai"];
            cboMaLoai.ValueMember = "MaLoai";
            cboMaLoai.DisplayMember = "TenLoai";
            dsDonViTinh.Tables.Add("DVTinh");
            dsDonViTinh.Tables["DVTinh"].Columns.Add("DonVi");
            dsDonViTinh.Tables["DVTinh"].Rows.Add("Cái");
            dsDonViTinh.Tables["DVTinh"].Rows.Add("Bộ");
            dsDonViTinh.Tables["DVTinh"].Rows.Add("Kg");
            dsDonViTinh.Tables["DVTinh"].Rows.Add("Hộp");
            dsDonViTinh.Tables["DVTinh"].Rows.Add("Chai");
            dsDonViTinh.Tables["DVTinh"].Rows.Add("Gói");
            cboDonViTinh.DataSource = dsDonViTinh.Tables["DVTinh"];
            cboDonViTinh.DisplayMember = "DonVi";
            cboDonViTinh.ValueMember = "DonVi";
            txtMaHang.MaxLength = 5;
            txtTenHang.MaxLength = 20;
            dgvHangHoa.DataSource = dsHangHoa;
            dgvHangHoa.DataMember = "HangHoa";
            GanDuLieu();
            dgvHangHoa.Columns[0].HeaderText = "Mã hàng";
            dgvHangHoa.Columns[1].HeaderText = "Tên hàng";
            dgvHangHoa.Columns[2].HeaderText = "Đơn vị tính";
            dgvHangHoa.Columns[3].HeaderText = "Loại hàng";
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            DieuKhienKhiBinhThuong();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKienKhiThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKienKhiChinhSua();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        bool KiemTra()
        {
            if (txtMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Mã hàng không được để trống");
                txtMaHang.Focus();
                return false;
            }
            else if (txtTenHang.Text.Trim() == "")
            {
                MessageBox.Show("Tên hàng không được để trống");
                txtTenHang.Focus();
                return false;
            }
            else if (cboDonViTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn đơn vị tính");
                return false;
            }
            else if (cboMaLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn tên loại");
                return false;
            }
            return true;
        }

        void CapNhat()
        {
            string strSql = "UPDATE HangHoa SET TenHang=@TenHang, DVTinh=@DVTinh, MaLoai=@MaLoai WHERE MaHang=@MaHang";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
            cmdCommand.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
            cmdCommand.Parameters.AddWithValue("@DVTinh", cboDonViTinh.SelectedValue.ToString());
            cmdCommand.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedValue.ToString());
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            int row = dgvHangHoa.CurrentRow.Index;
            dsHangHoa.Tables["HangHoa"].Rows[row][1] = txtTenHang.Text;
            dsHangHoa.Tables["HangHoa"].Rows[row][2] = cboDonViTinh.SelectedValue.ToString();
            dsHangHoa.Tables["HangHoa"].Rows[row][3] = cboMaLoai.Text;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        void ThemMoi()
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaHang.Text, "MaHang", "HangHoa"))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
                txtMaHang.Focus();
            }
            else
            {
                string strSql = "INSERT INTO HangHoa(MaHang, TenHang, DVTinh, MaLoai) Values (@MaHang, @TenHang, @DVTinh, @MaLoai)";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
                cmdCommand.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
                cmdCommand.Parameters.AddWithValue("@DVTinh", cboDonViTinh.SelectedValue.ToString());
                cmdCommand.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedValue.ToString());
                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();
                dsHangHoa.Tables["HangHoa"].Rows.Add(txtMaHang.Text, txtTenHang.Text, cboDonViTinh.SelectedValue.ToString(), cboMaLoai.Text);
                GanDuLieu();
                DieuKhienKhiBinhThuong();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blnThem)
                {
                    ThemMoi();
                    blnThem = false;
                }
                else
                {
                    CapNhat();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaHang.Text, "MaHang", "PhatSinh"))
            {
                MessageBox.Show("BẠn phải xóa dữ liệu phát sinh của hàng hóa trước");
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn có chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strSql = "DELETE HangHoa WHERE MaHang=@MaHang";
                    if(MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    dsHangHoa.Tables["HangHoa"].Rows.RemoveAt(dgvHangHoa.CurrentRow.Index);
                    GanDuLieu();
                }
            }
        }
    }
}
