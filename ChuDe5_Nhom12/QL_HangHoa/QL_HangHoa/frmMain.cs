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
            MessageBox.Show("Bài tập môn Lập trình .NET\n\nĐề tài 5: Chương trình quản lý hàng hóa\n\nNhóm thực hiện nhóm 12\n1. Trần Văn Hòa\n2. Trần Phong Bão\n3. Đoàn Huỳnh Giao", "Giới thiệu");
        }

    }
}
