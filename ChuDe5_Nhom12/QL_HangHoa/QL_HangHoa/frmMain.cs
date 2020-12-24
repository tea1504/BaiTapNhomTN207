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

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa fHH = new frmHangHoa();
            fHH.Show();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình quản lý hàng hóa\n\nBài tập nhóm môn lập trình .NET\n\nNhóm thực hiện: nhóm 12\n 1. Trần Văn Hòa - B1809127\n 2. Trần Phong Bão - B1809217\n 3. Đoàn Huỳnh Giao - B1809231", "Giới Thiệu", MessageBoxButtons.OK);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuPhatSinh_Click(object sender, EventArgs e)
        {
            frmPhatSinh fPS = new frmPhatSinh();
            fPS.Show();
        }
    }
}
