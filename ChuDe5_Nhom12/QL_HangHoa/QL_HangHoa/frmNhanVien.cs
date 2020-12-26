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
    public partial class frmNhanVien : Form
    {
        DataSet dsNV = new DataSet();
        DataSet dsNhanVien = new DataSet();
        DataSet dsQuyenSD = new DataSet();
        

        public frmNhanVien()
        {
            InitializeComponent();
        }

        void GanDuLieu()
        {
            if (dsNV.Tables["NhanVien"].Rows.Count > 0)
            {
                txtHoLot.Text = dgvNV[0, dgvNV.CurrentRow.Index].Value.ToString();
                txtTen.Text = dgvNV[1, dgvNV.CurrentRow.Index].Value.ToString();
                txtDiaChi.Text = dgvNV[2, dgvNV.CurrentRow.Index].Value.ToString();
                txtLuong.Text = dgvNV[3, dgvNV.CurrentRow.Index].Value.ToString();
                txtGhiChu.Text = dgvNV[4, dgvNV.CurrentRow.Index].Value.ToString();
                txtMatKhau.Text= dgvNV[5, dgvNV.CurrentRow.Index].Value.ToString();
                if (dgvNV[6, dgvNV.CurrentRow.Index].Value.ToString() == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dtpNgaySinh.Value = DateTime.Parse(dgvNV[7, dgvNV.CurrentRow.Index].Value.ToString());
                cboNhanVien.SelectedValue = dgvNV[8, dgvNV.CurrentRow.Index].Value.ToString();
                cboQuyenSD.SelectedValue = dgvNV[9, dgvNV.CurrentRow.Index].Value.ToString();

            }
            else
            {
                txtHoLot.Clear();
                
                txtTen.Clear();
                txtDiaChi.Clear();
                txtLuong.Clear();
                txtGhiChu.Clear();
                txtMatKhau.Clear();
                rdoNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Today;
                cboNhanVien.SelectedIndex = -1;
                cboQuyenSD.SelectedIndex = -1;

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
