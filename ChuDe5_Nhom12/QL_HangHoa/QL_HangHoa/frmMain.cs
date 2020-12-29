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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap(this);
            frmDN.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa fHH = new frmHangHoa();
            fHH.Show();
        }

        private void mnuPhatSinh_Click(object sender, EventArgs e)
        {
            frmPhatSinh fPS = new frmPhatSinh();
            fPS.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu fGT = new frmGioiThieu();
            fGT.ShowDialog();
        }

        private void mnuLoaiHang_Click(object sender, EventArgs e)
        {
            frmLoaiHang frmLH = new frmLoaiHang();
            frmLH.Show();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            if (MyPublics.strMaNV != "")
            {
                MessageBox.Show("Bạn đã đăng nhập rồi");
            }
            else
            {
                frmDangNhap frmDN = new frmDangNhap(this);
                frmDN.ShowDialog();
            }
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.Show();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.ShowDialog();
        }

        private void mnuThoatDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn muốn thoát đăng nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(blnDongY == DialogResult.Yes)
            {
                this.mnuDuLieu.Enabled = false;
                this.mnuTienIch.Enabled = true;
                this.mnuThoatDangNhap.Enabled = false;
                this.mnuDoiMatKhau.Enabled = false;
                MyPublics.strMaNV = "";
                MyPublics.strQuyenSD = "";
                MyPublics.strTen = "";
            }
        }
    }
}
