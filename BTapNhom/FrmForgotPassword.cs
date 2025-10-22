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

namespace BTapNhom
{
    public partial class FrmForgotPassword : Form
    {
        ConnectDatabase
            kn = new ConnectDatabase();

        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string email = txtEmail.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string matkhauMoi = txtMatKhauMoi.Text;

            int vaiTro;
            int maTK;

            // Lấy thông tin tài khoản
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM TAIKHOAN WHERE TenDangNhap='" + tenDangNhap + "'";
            dt = kn.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                vaiTro = Convert.ToInt32(dt.Rows[0]["MaVaiTro"]);
                maTK = Convert.ToInt32(dt.Rows[0]["MaTK"]);
                MessageBox.Show("Mã vai trò là: " + vaiTro);

                // =============================
                // ADMIN
                // =============================
                if (vaiTro == 1)
                {
                    string sqlAdmin = "SELECT * FROM ADMIN WHERE MaTK='" + maTK + "'";
                    DataTable dtAdmin = kn.GetData(sqlAdmin);
                    if (dtAdmin.Rows.Count > 0)
                    {
                        string emailDB = dtAdmin.Rows[0]["Email"].ToString();
                        string sdtDB = dtAdmin.Rows[0]["SDT"].ToString();

                        if (emailDB == email && sdtDB == soDienThoai)
                        {
                            string sqlUpdate = "UPDATE TAIKHOAN SET MatKhau='" + matkhauMoi + "' WHERE MaTK='" + maTK + "'";
                            kn.Execute(sqlUpdate);
                            MessageBox.Show("Cập nhật mật khẩu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Email hoặc số điện thoại không đúng!");
                        }
                    }
                }

                // =============================
                // GIÁO VIÊN
                // =============================
                else if (vaiTro == 2)
                {
                    string sqlGV = "SELECT * FROM GIAOVIEN WHERE MaTK='" + maTK + "'";
                    DataTable dtGV = kn.GetData(sqlGV);
                    if (dtGV.Rows.Count > 0)
                    {
                        string emailDB = dtGV.Rows[0]["Email"].ToString();
                        string sdtDB = dtGV.Rows[0]["SDT"].ToString();

                        if (emailDB == email && sdtDB == soDienThoai)
                        {
                            string sqlUpdate = "UPDATE TAIKHOAN SET MatKhau='" + matkhauMoi + "' WHERE MaTK='" + maTK + "'";
                            kn.Execute(sqlUpdate);
                            MessageBox.Show("Cập nhật mật khẩu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Email hoặc số điện thoại không đúng!");
                        }
                    }
                }

                // =============================
                // PHỤ HUYNH
                // =============================
                else if (vaiTro == 3)
                {
                    string sqlPH = "SELECT * FROM PHUHUYNH WHERE MaTK='" + maTK + "'";
                    DataTable dtPH = kn.GetData(sqlPH);
                    if (dtPH.Rows.Count > 0)
                    {
                        string emailDB = dtPH.Rows[0]["Email"].ToString();
                        string sdtDB = dtPH.Rows[0]["SDT"].ToString();

                        if (emailDB == email && sdtDB == soDienThoai)
                        {
                            string sqlUpdate = "UPDATE TAIKHOAN SET MatKhau='" + matkhauMoi + "' WHERE MaTK='" + maTK + "'";
                            kn.Execute(sqlUpdate);
                            MessageBox.Show("Cập nhật mật khẩu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Email hoặc số điện thoại không đúng!");
                        }
                    }
                }

                // =============================
                // HỌC SINH
                // =============================
                else if (vaiTro == 4)
                {
                    string sqlHS = "SELECT * FROM HOCSINH WHERE MaTK='" + maTK + "'";
                    DataTable dtHS = kn.GetData(sqlHS);
                    if (dtHS.Rows.Count > 0)
                    {
                        string emailDB = dtHS.Rows[0]["Email"].ToString();
                        string sdtDB = dtHS.Rows[0]["SDT"].ToString();

                        if (emailDB == email && sdtDB == soDienThoai)
                        {
                            string sqlUpdate = "UPDATE TAIKHOAN SET MatKhau='" + matkhauMoi + "' WHERE MaTK='" + maTK + "'";
                            kn.Execute(sqlUpdate);
                            MessageBox.Show("Cập nhật mật khẩu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Email hoặc số điện thoại không đúng!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vai trò phù hợp!");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản!");
            }
        }
    }
}
