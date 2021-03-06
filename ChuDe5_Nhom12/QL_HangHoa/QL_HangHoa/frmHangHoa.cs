﻿using System;
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

        DataSet dsHangHoa = new DataSet();
        DataSet dsLoaiHang = new DataSet();
        DataSet dsDonViTinh = new DataSet();
        bool blnThemMoi = false;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "Quản lý")
            {
                btnThem.Enabled = true;
                btnThem.BackColor = Color.FromArgb(116, 185, 255);
                btnSua.Enabled = true;
                btnSua.BackColor = Color.FromArgb(116, 185, 255);
                btnXoa.Enabled = true;
                btnXoa.BackColor = Color.FromArgb(116, 185, 255);
            }
            else
            {
                btnThem.Enabled = false;
                btnThem.BackColor = Color.FromArgb(223, 230, 233);
                btnSua.Enabled = false;
                btnSua.BackColor = Color.FromArgb(223, 230, 233);
                btnXoa.Enabled = false;
                btnXoa.BackColor = Color.FromArgb(223, 230, 233);
            }
            btnLuu.Enabled = false;
            btnLuu.BackColor = Color.FromArgb(223, 230, 233);
            btnKhongLuu.Enabled = false;
            btnKhongLuu.BackColor = Color.FromArgb(223, 230, 233);
            btnDong.Enabled = true;
            btnDong.BackColor = Color.FromArgb(116, 185, 255);
            txtMaHang.ReadOnly = true;
            txtMaHang.BackColor = Color.White;
            txtTenHang.ReadOnly = true;
            txtTenHang.BackColor = Color.White;
            cboDonViTinh.Enabled = false;
            cboLoaiHang.Enabled = false;
            dgvHangHoa.Enabled = true;
        }

        void DieuKhienKhiThemMoi() 
        {
            btnThem.Enabled = false;
            btnThem.BackColor = Color.FromArgb(223, 230, 233);
            btnSua.Enabled = false;
            btnSua.BackColor = Color.FromArgb(223, 230, 233);
            btnXoa.Enabled = false;
            btnXoa.BackColor = Color.FromArgb(223, 230, 233);
            btnLuu.Enabled = true;
            btnLuu.BackColor = Color.FromArgb(116, 185, 255);
            btnKhongLuu.Enabled = true;
            btnKhongLuu.BackColor = Color.FromArgb(116, 185, 255);
            btnDong.Enabled = false;
            btnDong.BackColor = Color.FromArgb(223, 230, 233);
            txtMaHang.ReadOnly = false;
            txtTenHang.ReadOnly = false;
            txtMaHang.Clear();
            txtTenHang.Clear();
            cboDonViTinh.Enabled = true;
            cboLoaiHang.Enabled = true;
            cboDonViTinh.SelectedIndex = -1;
            cboLoaiHang.SelectedIndex = -1;
            dgvHangHoa.Enabled = false;
        }

        void DieuKhienKhiChinhSua() 
        {
            btnThem.Enabled = false;
            btnThem.BackColor = Color.FromArgb(223, 230, 233);
            btnSua.Enabled = false;
            btnSua.BackColor = Color.FromArgb(223, 230, 233);
            btnXoa.Enabled = false;
            btnXoa.BackColor = Color.FromArgb(223, 230, 233);
            btnLuu.Enabled = true;
            btnLuu.BackColor = Color.FromArgb(116, 185, 255);
            btnKhongLuu.Enabled = true;
            btnKhongLuu.BackColor = Color.FromArgb(116, 185, 255);
            btnDong.Enabled = false;
            btnDong.BackColor = Color.FromArgb(223, 230, 233);
            txtTenHang.ReadOnly = false;
            txtTenHang.Focus();
            cboDonViTinh.Enabled = true;
            cboLoaiHang.Enabled = true;
            dgvHangHoa.Enabled = false;
        }

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
            dgvHangHoa.Width = 708;
            dgvHangHoa.Columns[0].HeaderText = "Mã hàng";
            dgvHangHoa.Columns[0].Width = 150;
            dgvHangHoa.Columns[1].HeaderText = "Tên hàng";
            dgvHangHoa.Columns[1].Width = 208;
            dgvHangHoa.Columns[2].HeaderText = "Đơn vị";
            dgvHangHoa.Columns[2].Width = 100;
            dgvHangHoa.Columns[3].HeaderText = "Loại hàng";
            dgvHangHoa.Columns[3].Width = 190;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
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
            blnThemMoi = true;
            DieuKhienKhiThemMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThemMoi = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        bool KiemTra()
        {
            if (txtMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                return false;
            }
            else if (txtTenHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return false;
            }
            else if(cboDonViTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else if (cboLoaiHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        void ThemMoi()
        {
            string strSql = "INSERT INTO HangHoa(MaHang, TenHang, DVTinh, MaLoai) VALUES(@MaHang, @TenHang, @DVTinh, @MaLoai)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
            cmdCommand.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
            cmdCommand.Parameters.AddWithValue("@DVTinh", cboDonViTinh.SelectedValue.ToString());
            cmdCommand.Parameters.AddWithValue("@MaLoai", cboLoaiHang.SelectedValue.ToString());
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            dsHangHoa.Tables["HangHoa"].Rows.Add(txtMaHang.Text, txtTenHang.Text, cboDonViTinh.Text, cboLoaiHang.Text);
            blnThemMoi = false;
            DieuKhienKhiBinhThuong();
        }

        void ChinhSua()
        {
            string strSql = "UPDATE HangHoa SET TenHang=@TenHang, DVTinh=@DVTinh, MaLoai=@MaLoai WHERE MaHang=@MaHang";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
            cmdCommand.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
            cmdCommand.Parameters.AddWithValue("@DVTinh", cboDonViTinh.SelectedValue.ToString());
            cmdCommand.Parameters.AddWithValue("@MaLoai", cboLoaiHang.SelectedValue.ToString());
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            int row = dgvHangHoa.CurrentRow.Index;
            dsHangHoa.Tables["HangHoa"].Rows[row][1] = txtTenHang.Text;
            dsHangHoa.Tables["HangHoa"].Rows[row][2] = cboDonViTinh.Text;
            dsHangHoa.Tables["HangHoa"].Rows[row][3] = cboLoaiHang.Text;
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blnThemMoi)
                {
                    if (MyPublics.TonTaiKhoaChinh(txtMaHang.Text, "MaHang", "HangHoa"))
                    {
                        MessageBox.Show("Hàng hóa 1 " + txtMaHang.Text + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaHang.Focus();
                    }
                    else
                    {
                        ThemMoi();
                    }
                }
                else
                {
                    ChinhSua();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaHang.Text, "MaHang", "PhatSinh"))
            {
                MessageBox.Show("Bạn phải xóa dữ liệu phát sinh của hàng hóa " + txtMaHang.Text + " trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn có chắn chắn muốn xóa hàng hóa " + txtMaHang.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strSql = "DELETE HangHoa WHERE MaHang=@MaHang";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
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
