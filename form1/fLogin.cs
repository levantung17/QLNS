
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS_BUS;
using QLNS_DTO;


namespace form1
{
    public partial class fLogin : Form
    {

        public static bool Loaitk = false;
        public fLogin()
        {
            InitializeComponent();
        }
        TK_DTO tK_DTO = new TK_DTO();
        TK_BUS tK_BUS = new TK_BUS();


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formMain f = new formMain();
            tK_DTO.Ten_tai_khoan = txbUserName.Text.Trim();
            tK_DTO.Mat_khau = txtPass.Text.Trim();
           
            
            if (txbUserName.Text == "nhanvien" && txtPass.Text == "123456" )
            {
                Loaitk = true;
                // formMain f = new formMain();
                f.Show();
                this.Hide();
                // f.ShowDialog();
                f.Logout += F_Logout;
                txbUserName.Clear();
                txtPass.Clear();
            }
            else {
             

                string getuser = tK_BUS.CheckLogin(tK_DTO);
                switch (getuser)
                {
                    case "requeid_taikhoan":
                        MessageBox.Show("Tài khoản không được để trống");
                        return;
                    case "requeid_matkhau":
                        MessageBox.Show("Tài khoản không được để trống");
                        return;
                    case "Tai khoan va mat khau khong chinh xac":
                        MessageBox.Show("Tài khoản và mật khẩu không chính xác");
                        return;

                }
                Loaitk = false;
                // formMain f = new formMain();
                f.Show();
                this.Hide();
                // f.ShowDialog();
                f.Logout += F_Logout;
                txbUserName.Clear();
                txtPass.Clear();
            }
        

            
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as formMain).isExit = false;
            (sender as formMain).Close();
            this.Show();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void CheckPass(object sender, EventArgs e)
        {
            if (ckbPassword.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            if (!ckbPassword.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txbUserName_KeyUp(object sender, KeyEventArgs e)
        {
            
            if ((e.KeyCode == Keys.Enter
                
                ) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }

}
