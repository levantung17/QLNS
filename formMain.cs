using System;
using System.Windows.Forms;

namespace form1
{
    public partial class formMain : Form
    {
       
        public bool isExit = true;
        public event EventHandler Logout;
        public formMain()
        {
            InitializeComponent();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                {
                e.Cancel = true;
            }
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo");
            Logout(this,new EventArgs());

           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                this.Close();
            }
                
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            fLogin fLogin = new fLogin();
            if (fLogin.Loaitk)
            {
                xuấtExcelToolStripMenuItem.Enabled = false;

            }


        }
    }
}
