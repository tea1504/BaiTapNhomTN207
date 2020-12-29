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
    public partial class frmLoaiHang : Form
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }
        DataSet dsLoaiHang = new DataSet();
        // DataSet dsTenHang = new DataSet();
        bool blnThem = false;
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
            btnKoLuu.Enabled = false;
            btnKoLuu.BackColor = Color.FromArgb(223, 230, 233);
            btnDong.Enabled = true;
            btnDong.BackColor = Color.FromArgb(116, 185, 255);
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            dgvLoai.Enabled = true;
            txtMa.BackColor = Color.White;
            txtTen.BackColor = Color.White;
            
        }
        void DieuKhienKhiThemMoi()
        {
            txtMa.Clear();
            txtTen.Clear();
            btnThem.Enabled = false;
            btnThem.BackColor = Color.FromArgb(223, 230, 233);
            btnSua.Enabled = false;
            btnSua.BackColor = Color.FromArgb(223, 230, 233);
            btnXoa.Enabled = false;
            btnXoa.BackColor = Color.FromArgb(223, 230, 233);
            btnLuu.Enabled = true;
            btnLuu.BackColor = Color.FromArgb(116, 185, 255);
            btnKoLuu.Enabled = true;
            btnKoLuu.BackColor = Color.FromArgb(116, 185, 255);
            btnDong.Enabled = false;
            btnDong.BackColor = Color.FromArgb(223, 230, 233);
            txtMa.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            //cbbMa.SelectedIndex = -1;
            //cbbTenLoai.SelectedIndex = -1;
            dgvLoai.Enabled = false;
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
            btnKoLuu.Enabled = true;
            btnKoLuu.BackColor = Color.FromArgb(116, 185, 255);
            btnDong.Enabled = false;
            btnDong.BackColor = Color.FromArgb(223, 230, 233);
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = false;
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            dgvLoai.Enabled = false;
        }
        void GanDuLieu()
        {
            if (dgvLoai.Rows.Count > 0)
            {
                txtMa.Text = dgvLoai[0, dgvLoai.CurrentRow.Index].Value.ToString();
                txtTen.Text = dgvLoai[1, dgvLoai.CurrentRow.Index].Value.ToString();
            }
            else
            {
                txtMa.Clear();
                txtTen.Clear();
            }
        }
        void ThucThiLuu()
        {
            string strSql = "insert into LoaiHang(MaLoai,TenLoai) values(@MaLoai,@TenLoai)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaLoai", txtMa.Text);
            cmdCommand.Parameters.AddWithValue("@TenLoai", txtTen.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            dsLoaiHang.Tables["LoaiHang"].Rows.Add(txtMa.Text, txtTen.Text);
            blnThem = false;
            DieuKhienKhiBinhThuong();
        }
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            string select = "select * from LoaiHang";
            MyPublics.OpenData(select, dsLoaiHang, "LoaiHang");
            dgvLoai.DataSource = dsLoaiHang;
            dgvLoai.DataMember = "LoaiHang";
            txtMa.MaxLength = 20;
            txtTen.MaxLength = 20;
            dgvLoai.Width = 519; ;
            dgvLoai.AllowUserToAddRows = false;
            dgvLoai.AllowUserToDeleteRows = false;
            dgvLoai.Columns[0].Width = 150;
            dgvLoai.Columns[0].HeaderText = "Mã số";
            dgvLoai.Columns[1].Width = 326;
            dgvLoai.Columns[1].HeaderText = "Loại hàng";
            dgvLoai.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }
        void CapNhat()
        {
            string strsql = "update LoaiHang set TenLoai = @TenLoai where MaLoai = @MaLoai";
            MyPublics.conMyConnection.Open();
            SqlCommand cmd = new SqlCommand(strsql, MyPublics.conMyConnection);
            cmd.Parameters.AddWithValue("@MaLoai", txtMa.Text);
            cmd.Parameters.AddWithValue("@TenLoai", txtTen.Text);
            cmd.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            int c = dgvLoai.CurrentRow.Index;
            dsLoaiHang.Tables["LoaiHang"].Rows[c][0] = txtMa.Text;
            dsLoaiHang.Tables["LoaiHang"].Rows[c][1] = txtTen.Text;
            DieuKhienKhiBinhThuong();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThemMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMa.Text, "MaLoai", "HangHoa"))
            {
                MessageBox.Show("Bạn phải xóa những loại hàng hóa có mã số " + txtMa.Text + " trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn có chắn chắn muốn xóa loại hàng " + txtMa.Text + " (" + txtTen.Text + ")", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strSql = "delete LoaiHang where MaLoai = @MaLoai";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaLoai", txtMa.Text);
                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    dsLoaiHang.Tables["LoaiHang"].Rows.RemoveAt(dgvLoai.CurrentRow.Index);
                    MessageBox.Show("Đã xóa", "Thông báo");
                    GanDuLieu();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã loại hàng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại hàng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (blnThem)
                    if (MyPublics.TonTaiKhoaChinh(txtMa.Text, "MaLoai", "LoaiHang"))
                    {
                        MessageBox.Show("Mã số loại hàng này đã có rồi!", "Thông báo");
                        txtMa.Focus();
                    }
                    else
                    {
                        ThucThiLuu();
                        MessageBox.Show("Đã thêm", "Thông báo");
                    }
                else
                {
                    CapNhat();
                    MessageBox.Show("Đã lưu", "Thông báo");
                }
            }
        }

        private void btnKoLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }
    }
}
