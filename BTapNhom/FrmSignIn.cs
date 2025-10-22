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
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }
        ConnectDatabase kn = new ConnectDatabase();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM TAIKHOAN WHERE TenDangNhap='" + txtTaiKhoan.Text + "' AND MATKHAU='" + txtMatKhau.Text + "'";
            dt = kn.GetData(sql);
           
            if (dt.Rows.Count > 0)
            {
                MessageBox
                    .Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string role = dt.Rows[0]["MaVaiTro"].ToString();

                if (role == "1")
                {
                    FrmMain frm = new FrmMain("Tôi là Thuận","Đây là tài khoản admin");
                    frm.Show();
                    this.Hide();
                }
                else if (role == "2")
                {
                    FrmMain2 frm = new FrmMain2("Tôi là Thuận", "Đây là tài khoản giáo viên");
                    frm.Show();
                    this.Hide();
                }
                else if (role == "3")
                {
                    FrmMain3 frm = new FrmMain3("Tôi là Thuận", "Đây là tài khoản phụ huynh");
                    frm.Show();
                    this.Hide();
                }
                else if (role == "4")
                {
                    FrmMain4 frm = new FrmMain4("Tôi là Thuận", "Đây là tài khoản học sinh");
                    frm.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            FrmForgotPassword
                frm = new FrmForgotPassword();
            frm.Show();
        }
    }
}
