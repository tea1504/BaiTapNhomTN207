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
                if (dgvPhatSinh[1, row].Value.ToString() != "")
                    dtpNgay.Value = DateTime.Parse(dgvPhatSinh[1, row].Value.ToString());
                else
                    dtpNgay.Value = DateTime.Now;
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
                cboNhanVien.SelectedIndex = -1;
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
            txtSoThuTu.Visible = true;
            lblSoThuTu.Text = "Số thứ tự:";
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
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnDong.Enabled = false;
            dtpNgay.Enabled = true;
            cboLoai.Enabled = true;
            txtPhieu.ReadOnly = false;
            txtKhachHang.ReadOnly = false;
            txtLyDo.ReadOnly = false;
            cboTenHang.Enabled = true;
            txtSoLuong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            cboNhanVien.Enabled = true;

            txtSoThuTu.Visible = false;
            lblSoThuTu.Text = "Số thứ tự sẽ được tự động thêm.";
            dtpNgay.Value = DateTime.Now;
            cboLoai.SelectedIndex = -1;
            txtPhieu.Clear();
            txtKhachHang.Clear();
            txtLyDo.Clear();
            cboTenHang.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            cboNhanVien.SelectedIndex = -1;

            dgvPhatSinh.Enabled = false;
        }

        void DieuKhienThiChinhSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnDong.Enabled = false;
            dtpNgay.Enabled = true;
            cboLoai.Enabled = true;
            txtPhieu.ReadOnly = false;
            txtKhachHang.ReadOnly = false;
            txtLyDo.ReadOnly = false;
            cboTenHang.Enabled = true;
            txtSoLuong.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            cboNhanVien.Enabled = true;
            dgvPhatSinh.Enabled = false;
        }

        private void frmPhatSinh_Load(object sender, EventArgs e)
        {
            string strSelect = "SELECT PhatSinh.Sott, PhatSinh.Ngay, PhatSinh.Loai, PhatSinh.Phieu, PhatSinh.KhachHang, PhatSinh.LyDo, HangHoa.TenHang + ' (' + HangHoa.DVtinh + ')' AS TenHang, PhatSinh.SoLg, PhatSinh.Dgia, NhanVien.MaNV + ' - ' + NhanVien.HoLot + ' ' + NhanVien.Ten AS htnv FROM PhatSinh LEFT JOIN HangHoa ON PhatSinh.MaHang = HangHoa.MaHang LEFT JOIN NhanVien ON PhatSinh.MaNV = NhanVien.MaNV ORDER BY PhatSinh.Sott";
            MyPublics.OpenData(strSelect, dsPhatSinh, "PhatSinh");
            strSelect = "SELECT MaHang, TenHang + ' (' + DVTinh + ')' AS TenHang  FROM HangHoa";
            MyPublics.OpenData(strSelect, dsTenHang, "HangHoa");
            strSelect = "SELECT MaNV,MaNV + ' - ' + HoLot + ' ' + Ten AS HoTen FROM NhanVien";
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
            dgvPhatSinh.Width = 1420;
            dgvPhatSinh.Columns[0].HeaderText = "Số thứ tự";
            dgvPhatSinh.Columns[0].Width = 80;
            dgvPhatSinh.Columns[1].HeaderText = "Ngày nhập";
            dgvPhatSinh.Columns[1].Width = 100;
            dgvPhatSinh.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhatSinh.Columns[2].HeaderText = "Loại";
            dgvPhatSinh.Columns[2].Width = 80;
            dgvPhatSinh.Columns[3].HeaderText = "Phiếu";
            dgvPhatSinh.Columns[3].Width = 80;
            dgvPhatSinh.Columns[4].HeaderText = "Khách hàng";
            dgvPhatSinh.Columns[4].Width = 150;
            dgvPhatSinh.Columns[5].HeaderText = "Lý do";
            dgvPhatSinh.Columns[5].Width = 200;
            dgvPhatSinh.Columns[6].HeaderText = "Tên hàng";
            dgvPhatSinh.Columns[6].Width = 220;
            dgvPhatSinh.Columns[7].HeaderText = "Số lượng";
            dgvPhatSinh.Columns[7].Width = 80;
            dgvPhatSinh.Columns[8].HeaderText = "Đơn giá";
            dgvPhatSinh.Columns[8].Width = 120;
            dgvPhatSinh.Columns[9].HeaderText = "Nhân viên";
            dgvPhatSinh.Columns[9].Width = 250;
            dgvPhatSinh.AllowUserToAddRows = false;
            dgvPhatSinh.AllowUserToDeleteRows = false;
            dgvPhatSinh.EditMode = DataGridViewEditMode.EditProgrammatically;
            DieuKhienKhiBinhThuong();
        }

        private void dgvPhatSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThemMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhienThiChinhSua();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string LaySoTT()
        {
            string strSql = "SELECT MAX(Sott) FROM PhatSinh";
            string strResult = "";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            SqlDataReader drReader = cmdCommand.ExecuteReader();
            if (drReader.HasRows)
            {
                drReader.Read();
                strResult = drReader[0].ToString();
                drReader.Close();
            }
            return strResult;
        }

        bool Check()
        {
            float f;
            if (txtSoLuong.Text.Trim() == "") txtSoLuong.Text = "0";
            if (txtDonGia.Text.Trim() == "") txtDonGia.Text = "0";
            if(!float.TryParse(txtSoLuong.Text, out f))
            {
                MessageBox.Show("Bạn phải nhập số lượng là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Clear();
                txtSoLuong.Focus();
                return false;
            }
            else if(!float.TryParse(txtDonGia.Text, out f))
            {
                MessageBox.Show("Bạn phải nhập đơn giá là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Clear();
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        void ThemMoi()
        {
            string strSql = "INSERT INTO PhatSinh(Ngay, Loai, Phieu, KhachHang, LyDo, MaHang, SoLg, Dgia, MaNV) Values(@Ngay, @Loai, @Phieu, @KhachHang, @LyDo, @MaHang, @SoLg, @Dgia, @MaNV)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@Ngay", dtpNgay.Value);
            if(cboLoai.SelectedIndex==-1)
                cmdCommand.Parameters.AddWithValue("@Loai", DBNull.Value);
            else
                cmdCommand.Parameters.AddWithValue("@Loai", cboLoai.SelectedValue.ToString());
            cmdCommand.Parameters.AddWithValue("@Phieu", txtPhieu.Text);
            cmdCommand.Parameters.AddWithValue("@KhachHang", txtKhachHang.Text);
            cmdCommand.Parameters.AddWithValue("@LyDo", txtLyDo.Text);
            if(cboTenHang.SelectedIndex==-1)
                cmdCommand.Parameters.AddWithValue("@MaHang", DBNull.Value);
            else
                cmdCommand.Parameters.AddWithValue("@MaHang", cboTenHang.SelectedValue.ToString());
            float sl = float.Parse(txtSoLuong.Text), dg = float.Parse(txtDonGia.Text); 
            cmdCommand.Parameters.AddWithValue("@SoLg", sl);
            cmdCommand.Parameters.AddWithValue("@Dgia", dg);
            if(cboNhanVien.SelectedIndex==-1)
                cmdCommand.Parameters.AddWithValue("@MaNV", DBNull.Value);
            else
                cmdCommand.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            int SoTT = int.Parse(LaySoTT());
            dsPhatSinh.Tables["PhatSinh"].Rows.Add(SoTT, dtpNgay.Value, cboLoai.Text, txtPhieu.Text, txtKhachHang.Text, txtLyDo.Text, cboTenHang.Text, sl, dg, cboNhanVien.Text);
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        void CapNhat()
        {
            string strSql = "UPDATE PhatSinh SET Ngay=@Ngay, Loai=@Loai, Phieu=@Phieu, KhachHang=@KhachHang, LyDo=@LyDo, MaHang=@MaHang, SoLg=@SoLg, Dgia=@Dgia, MaNV=@MaNV WHERE Sott=@Sott";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@Sott", txtSoThuTu.Text);
            cmdCommand.Parameters.AddWithValue("@Ngay", dtpNgay.Value);
            if (cboLoai.SelectedIndex == -1)
                cmdCommand.Parameters.AddWithValue("@Loai", DBNull.Value);
            else
                cmdCommand.Parameters.AddWithValue("@Loai", cboLoai.SelectedValue.ToString());
            cmdCommand.Parameters.AddWithValue("@Phieu", txtPhieu.Text);
            cmdCommand.Parameters.AddWithValue("@KhachHang", txtKhachHang.Text);
            cmdCommand.Parameters.AddWithValue("@LyDo", txtLyDo.Text);
            if (cboTenHang.SelectedIndex == -1)
                cmdCommand.Parameters.AddWithValue("@MaHang", DBNull.Value);
            else
                cmdCommand.Parameters.AddWithValue("@MaHang", cboTenHang.SelectedValue.ToString());
            float sl = float.Parse(txtSoLuong.Text), dg = float.Parse(txtDonGia.Text);
            cmdCommand.Parameters.AddWithValue("@SoLg", sl);
            cmdCommand.Parameters.AddWithValue("@Dgia", dg);
            if (cboNhanVien.SelectedIndex == -1)
                cmdCommand.Parameters.AddWithValue("@MaNV", DBNull.Value);
            else
                cmdCommand.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            int row = dgvPhatSinh.CurrentRow.Index;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][1] = dtpNgay.Value.ToString();
            dsPhatSinh.Tables["PhatSinh"].Rows[row][2] = cboLoai.Text;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][3] = txtPhieu.Text;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][4] = txtKhachHang.Text;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][5] = txtLyDo.Text;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][6] = cboTenHang.Text;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][7] = sl;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][8] = dg;
            dsPhatSinh.Tables["PhatSinh"].Rows[row][9] = cboNhanVien.Text;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (blnThem)
                {
                    ThemMoi();
                    blnThem = false;
                }
                else
                    CapNhat();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn có chắc chắn muốn xóa phát sinh " + txtSoThuTu.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (blnDongY == DialogResult.Yes)
            {
                string strSql = "DELETE FROM PhatSinh WHERE Sott=@Sott";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@Sott", txtSoThuTu.Text);
                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();
                dsPhatSinh.Tables["PhatSinh"].Rows.RemoveAt(dgvPhatSinh.CurrentRow.Index);
                GanDuLieu();
            }
        }
    }
}
