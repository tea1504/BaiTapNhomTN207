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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = MyPublics.strMaNV + " - " + MyPublics.strTen;
            txtNhanVien.ReadOnly = true;
            txtNhanVien.BackColor = Color.White;
            txtMatKhauMoi.PasswordChar = '*';
            txtXacNhan.PasswordChar = '*';
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Xác nhận không chính xác!");
                return;
            }
            else
            {
                string strUpdate = "Update NhanVien Set MatKhau=@MatKhau Where MaNV=@MaNV";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strUpdate, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@MatKhau",MyPublics.MaHoaPassWord(txtMatKhauMoi.Text));
                cmdCommand.Parameters.AddWithValue("@MaNV", MyPublics.strMaNV);
                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();
                this.Close();
            }
        }
    }
}
