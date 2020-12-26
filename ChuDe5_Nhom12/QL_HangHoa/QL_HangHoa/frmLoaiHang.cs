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
                btnSua.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            btnLuu.Enabled = false;
            btnKoLuu.Enabled = false;
            btnDong.Enabled = true;
            cbbMa.Enabled = false;
            cbbTenLoai.Enabled = false;
            dgvLoai.Enabled = true;
        }
        void DieuKhienKhiThemMoi()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnKoLuu.Enabled = true;
            btnDong.Enabled = false;
            cbbMa.Enabled = true;
            cbbTenLoai.Enabled = true;
            //cbbMa.SelectedIndex = -1;
            //cbbTenLoai.SelectedIndex = -1;
            dgvLoai.Enabled = false;
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnKoLuu.Enabled = true;
            btnDong.Enabled = false;
            cbbMa.Enabled = true;
            cbbTenLoai.Enabled = true;
            dgvLoai.Enabled = false;
        }
        void GanDuLieu()
        {
            if (dgvLoai.Rows.Count > 0)
            {
                int row = dgvLoai.CurrentRow.Index;
                cbbMa.SelectedValue = dgvLoai[0, row].Value.ToString();
                cbbTenLoai.SelectedIndex = cbbTenLoai.FindStringExact(dgvLoai[1, row].Value.ToString());
            }
            else
            {
                cbbMa.SelectedIndex = -1;
                cbbTenLoai.SelectedIndex = -1;
            }
        }
        void ThucThiLuu()
        {
            string strSql = "insert into LoaiHang(MaLoai,TenLoai) values(@MaLoai,@TenLoai)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaLoai", cbbMa.SelectedValue.ToString());
            cmdCommand.Parameters.AddWithValue("@TenLoai", cbbTenLoai.SelectedValue.ToString());
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            dsLoaiHang.Tables["LoaiHang"].Rows.Add(cbbMa.Text, cbbTenLoai.Text);
            blnThem = false;
            DieuKhienKhiBinhThuong();
        }
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            string select = "select * from LoaiHang";
            MyPublics.OpenData(select, dsLoaiHang, "LoaiHang");
            cbbMa.DataSource = dsLoaiHang.Tables["MaLoai"];
            cbbMa.DisplayMember = "MaLoai";
            cbbMa.ValueMember = "MaLoai";
            cbbMa.DataSource = dsLoaiHang.Tables["TenLoai"];
            cbbTenLoai.DisplayMember = "TenLoai";
            cbbTenLoai.ValueMember = "TenLoai";
            dgvLoai.DataSource = dsLoaiHang;
            dgvLoai.DataMember = "LoaiHang";
            dgvLoai.Width = 220;
            dgvLoai.AllowUserToAddRows = false;
            dgvLoai.AllowUserToDeleteRows = false;
            dgvLoai.Columns[0].Width = 80;
            dgvLoai.Columns[0].HeaderText = "Mã số";
            dgvLoai.Columns[1].Width = 140;
            dgvLoai.Columns[1].HeaderText = "Loại hàng";
            dgvLoai.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
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
            if (MyPublics.TonTaiKhoaChinh(cbbMa.Text, "MaLoai", "HangHoa"))
            {
                MessageBox.Show("Bạn phải xóa những loại hàng hóa thuộc " + cbbMa.Text + " trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn có chắn chắn muốn xóa loại hàng " + cbbMa.Text + " (" + cbbTenLoai.Text + ")", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strSql = "delete LoaiHang where MaLoai = @MaLoai";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaLoai", cbbMa.Text);
                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    dsLoaiHang.Tables["LoaiHang"].Rows.RemoveAt(dgvLoai.CurrentRow.Index);
                    GanDuLieu();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((cbbMa.Text == "") || (cbbTenLoai.Text == "")) MessageBox.Show("Lỗi nhập dữ liệu!");
            else
            {
                if (MyPublics.TonTaiKhoaChinh(cbbMa.Text, "MaLoai", "LoaiHang"))
                {
                    MessageBox.Show("Mã số loại hàng này đã có rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbMa.Focus();
                }
                else ThucThiLuu();
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
    }
}
