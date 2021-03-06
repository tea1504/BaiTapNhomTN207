﻿using System;
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
    public partial class frmDangNhap: Form
    {
        private frmMain fMain;
        int count = 0;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(frmMain fm) : this()
        {
            fMain = fm;
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
            txtTK.Focus();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            string sqlselect, strpwd;
            try
            {
                MyPublics.ConnectDatabase();
                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    MyPublics.strMaNV = txtTK.Text;
                    strpwd = MyPublics.MaHoaPassWord(txtMK.Text);
                    // strpwd = txtMK.Text;
                    sqlselect = "Select MaNV, QuyenSD, HoLot + ' ' + Ten AS HoTen from NhanVien Where MaNV = @MaNV and MatKhau = @MatKhau";
                    cmd = new SqlCommand(sqlselect, MyPublics.conMyConnection);
                    cmd.Parameters.AddWithValue("@MaNV", MyPublics.strMaNV);
                    cmd.Parameters.AddWithValue("@MatKhau", strpwd);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        MyPublics.strMaNV = dr.GetString(0);
                        MyPublics.strQuyenSD = dr.GetString(1);
                        MyPublics.strTen = dr.GetString(2);
                        dr.Close();
                        fMain.mnuDuLieu.Enabled = true;
                        fMain.mnuTienIch.Enabled = true;
                        fMain.mnuDangNhap.Enabled = true;
                        fMain.mnuThoatDangNhap.Enabled = true;
                        fMain.mnuDoiMatKhau.Enabled = true;
                        MessageBox.Show("Đăng nhập thành công.\nXin chào bạn " + MyPublics.strTen, "Thông báo");
                        MyPublics.conMyConnection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên hoặc mật khẩu sai!", "Thông báo");
                        txtTK.Focus();
                        count++;
                        if(count >= 3)
                        {
                            MessageBox.Show("Bạn đã nhập sai 3 lần!", "Thông báo");
                            MyPublics.strMaNV = "";
                            fMain.mnuDuLieu.Enabled = false;
                            fMain.mnuTienIch.Enabled = true;
                            fMain.mnuThoatDangNhap.Enabled = false;
                            fMain.mnuDoiMatKhau.Enabled = false;
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công!", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi thực hiện kết nối!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MyPublics.strMaNV = "";
            fMain.mnuDuLieu.Enabled = false;
            fMain.mnuTienIch.Enabled = true;
            fMain.mnuThoatDangNhap.Enabled = false;
            fMain.mnuDoiMatKhau.Enabled = false;
            Close();
        }
    }
}
