using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Service
{
    public partial class FirstLogin : Form
    {
        public FirstLogin()
        {
            InitializeComponent();
        }

        private void lb_mahsolat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("سلام!به نرم افزار مدیپوش خوش آمدید!\nلطفا ابتدا نام کاربری و رمز عبور خود را وارد کنید");
        }

        private void btn_khoroj_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخوایید خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btn_vorod1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_faramoshi_Click(object sender, EventArgs e)
        {
            FaramoshiRamz faramoshiRamz = new FaramoshiRamz();
            faramoshiRamz.ShowDialog();
        }
    }
}
