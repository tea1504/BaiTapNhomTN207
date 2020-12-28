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
    public partial class frmNhanVien : Form
    {
        DataSet dsNhanVien = new DataSet();
        DataSet dsQuyenSD = new DataSet();
        bool blnThem = false;


        public int ThemSua { get; private set; }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        void GanDuLieu()
        {
            if (dsNhanVien.Tables["NhanVien"].Rows.Count > 0)
            {
                txtMaNV.Text = dgvNV[0, dgvNV.CurrentRow.Index].Value.ToString();
                txtHoLot.Text = dgvNV[1, dgvNV.CurrentRow.Index].Value.ToString();
                txtTen.Text = dgvNV[2, dgvNV.CurrentRow.Index].Value.ToString();
                if (dgvNV[3, dgvNV.CurrentRow.Index].Value.ToString() == "true")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dtpNgaySinh.Value = DateTime.Parse(dgvNV[5, dgvNV.CurrentRow.Index].Value.ToString());
                txtDiaChi.Text = dgvNV[4, dgvNV.CurrentRow.Index].Value.ToString();
                txtLuong.Text = dgvNV[6, dgvNV.CurrentRow.Index].Value.ToString();


                txtMatKhau.Text = dgvNV[9, dgvNV.CurrentRow.Index].Value.ToString();
                txtGhiChu.Text = dgvNV[7, dgvNV.CurrentRow.Index].Value.ToString();


                cboQuyenSD.SelectedValue = dgvNV[8, dgvNV.CurrentRow.Index].Value.ToString();

            }
            else
            {
                txtMaNV.Clear();
                txtHoLot.Clear();
                txtTen.Clear();
                rdoNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Today;
                txtDiaChi.Clear();
                txtLuong.Clear();

                txtMatKhau.Clear();
                txtGhiChu.Clear();


                cboQuyenSD.SelectedIndex = -1;

            }
        }



        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "Quản lý")
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
            txtMaNV.ReadOnly = true;
            txtMaNV.BackColor = Color.White;
            txtHoLot.ReadOnly = true;
            txtHoLot.BackColor = Color.White;
            txtTen.ReadOnly = true;
            txtTen.BackColor = Color.White;
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.White;
            dtpNgaySinh.Enabled = false;
            rdoNam.Checked = true;
            rdoNu.Checked = false;
            txtLuong.ReadOnly = true;
            txtLuong.BackColor = Color.White;
            txtGhiChu.ReadOnly = true;
            txtGhiChu.BackColor = Color.White;
            txtMatKhau.ReadOnly = true;
            txtMatKhau.BackColor = Color.White;

            dgvNV.Enabled = true;

        }
        void DieuKhienKhiThemMoi()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnDong.Enabled = false;
            txtMaNV.ReadOnly = false;
            txtHoLot.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtLuong.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
            rdoNu.Checked = false;
            rdoNam.Checked = true;
            dgvNV.Enabled = false;
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtLuong.Clear();
            txtGhiChu.Clear();
            txtMatKhau.Clear();
            rdoNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Today;
            cboQuyenSD.SelectedIndex = -1;
        }
        void DieuKhienKhiChinhSua()
        {
            btnDong.Enabled = false;
            btnKhongLuu.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNV.ReadOnly = false;
            txtHoLot.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtLuong.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
            dgvNV.Enabled = false;

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string strSelect = " Select * From Nhanvien";
            MyPublics.OpenData(strSelect, dsNhanVien, "NhanVien");





            dsQuyenSD.Tables.Add("DSQuyenSD");
            dsQuyenSD.Tables["DSQuyenSD"].Columns.Add("QuyenSD");
            dsQuyenSD.Tables["DSQuyenSD"].Rows.Add("Nhân viên");
            dsQuyenSD.Tables["DSQuyenSD"].Rows.Add("Quản lý");
            cboQuyenSD.DataSource = dsQuyenSD.Tables["DSQuyenSD"];
            cboQuyenSD.DisplayMember = "QuyenSD";
            cboQuyenSD.ValueMember = "QuyenSD";
            txtHoLot.MaxLength = 20;
            txtTen.MaxLength = 10;
            txtDiaChi.MaxLength = 20;
            txtLuong.MaxLength = 20;
            txtGhiChu.MaxLength = 20;
            txtMatKhau.MaxLength = 15;

            dgvNV.DataSource = dsNhanVien;
            dgvNV.DataMember = "NhanVien";
            dgvNV.Width = 690;
            dgvNV.AllowUserToAddRows = false;
            dgvNV.AllowUserToDeleteRows = false;
            dgvNV.Columns[0].Width = 20;
            dgvNV.Columns[0].HeaderText = "Mã NV";
            dgvNV.Columns[1].Width = 80;
            dgvNV.Columns[1].HeaderText = "Họ Lót";
            dgvNV.Columns[2].Width = 40;
            dgvNV.Columns[2].HeaderText = "Tên";
            dgvNV.Columns[3].Width = 40;
            dgvNV.Columns[3].HeaderText = "Giới tính";
            dgvNV.Columns[5].Width = 40;
            dgvNV.Columns[5].HeaderText = "Ngày sinh";
            dgvNV.Columns[4].Width = 80;
            dgvNV.Columns[4].HeaderText = "Địa chỉ";
            dgvNV.Columns[6].Width = 40;
            dgvNV.Columns[6].HeaderText = "Lương";
            dgvNV.Columns[9].Width = 40;
            dgvNV.Columns[9].HeaderText = "Mật khẩu";
            dgvNV.Columns[7].Width = 80;
            dgvNV.Columns[7].HeaderText = "Ghi chú";
            dgvNV.Columns[8].Width = 40;
            dgvNV.Columns[8].HeaderText = " Quyền SD";
            dgvNV.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }






        void ThucThiLuu()
        {
            string strSQL,  strMatkhau = "", strQuyenSD;
            bool  GioiTinh = true;
            float Luong;

            if (blnThem)
                strSQL = "Insert Into NhanVien Values(@MaNV,@HoLot,@Ten,@GioiTinh,@NgaySinh,@DiaChi,@Luong,@MatKhau,@GhiChu,@QuyenSD)";
            else
                strSQL = "Update NhanVien Set HoLot=@HoLot,Ten=@Ten,Phai=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,Luong=@Luong,GhiChu=@GhiChu,QuyenSD=@QuyenSD Where MaNV=@MaNV";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSQL, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            cmdCommand.Parameters.AddWithValue("@HoLot", txtHoLot.Text);
            cmdCommand.Parameters.AddWithValue("@Ten", txtTen.Text);
            cmdCommand.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            if (txtLuong.Text == "")
            {
                Luong = 0;
            }
            else
            {
                Luong=float.Parse(txtLuong.Text);
            }
            cmdCommand.Parameters.AddWithValue("@Luong", Luong);
            cmdCommand.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
            if (rdoNu.Checked)
                GioiTinh = false;
            cmdCommand.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmdCommand.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);

            if (blnThem)
            {
                strMatkhau = MyPublics.MaHoaPassWord(txtMaNV.Text);
                cmdCommand.Parameters.AddWithValue("@MatKhau", strMatkhau);

            }

            if (cboQuyenSD.SelectedIndex == -1)
                cmdCommand.Parameters.AddWithValue("@QuyenSD", DBNull.Value);
            else
                cmdCommand.Parameters.AddWithValue("@QuyenSD", cboQuyenSD.SelectedValue.ToString());
            
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            if (blnThem)
            {
                dsNhanVien.Tables["NhanVien"].Rows.Add(txtMaNV.Text, txtHoLot.Text, txtTen.Text, GioiTinh,  txtDiaChi.Text,dtpNgaySinh.Value, Luong ,txtGhiChu.Text,cboQuyenSD.Text, strMatkhau );
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvNV.CurrentRow.Index;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][1] = txtHoLot.Text;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][2] = txtTen.Text;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][3] = GioiTinh;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][5] = dtpNgaySinh.Value;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][4] = txtDiaChi.Text;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][6] = txtLuong.Text;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][9] = strMatkhau;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][7] = txtGhiChu.Text;
                dsNhanVien.Tables["NhanVien"].Rows[curRow][8] =cboQuyenSD.Text;
            }
            DieuKhienKhiBinhThuong();

        }





        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThemMoi();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                string strDelete = "Delete NhanVien Where MaNV=@MaNV";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strDelete, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();
                int curRow = dgvNV.CurrentRow.Index;
                dsNhanVien.Tables["NhanVien"].Rows.RemoveAt(curRow);
                GanDuLieu();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if ((txtMaNV.Text == "") || (txtHoLot.Text == "") ||( txtLuong.Text!="" && !float.TryParse(txtLuong.Text, out float Luong )))
                MessageBox.Show("Lỗi nhập dữ liệu !");
                
            else if (blnThem && (MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MaNV", "NhanVien")))
            {
                MessageBox.Show("Đã có!! ");
                txtMaNV.Focus();
            }
            else
                ThucThiLuu();
        }

        private void btnKhongLuu_Click_1(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {

                if(e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }
    }
}




