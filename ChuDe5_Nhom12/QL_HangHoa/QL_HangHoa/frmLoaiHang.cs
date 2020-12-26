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
    public partial class frmLoaiHang : Form
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }
        DataSet dsLoaiHang = new DataSet();
        // DataSet dsTenHang = new DataSet();
        bool blnThem = false;
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            string select = "select * from LoaiHang";
            MyPublics.OpenData(select, dsLoaiHang, "LoaiHang");
            cbbMa.DataSource = dsLoaiHang;
        }
    }
}
