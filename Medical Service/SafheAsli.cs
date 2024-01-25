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
    public partial class SafheAsli : Form
    {
        public SafheAsli()
        {
            InitializeComponent();
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

        private void btn_modiriat_anbar_Click(object sender, EventArgs e)
        {
            ModiriatAnbar modiriatAnbar = new ModiriatAnbar();
            modiriatAnbar.Show();
        }

        private void btn_sefareshat_Click(object sender, EventArgs e)
        {
            MenuSefareshat menuSefareshat = new MenuSefareshat();
            menuSefareshat.Show();
        }

        private void btn_moshtarian_Click(object sender, EventArgs e)
        {
            MenuMoshtarian menuMoshtarian = new MenuMoshtarian();
            menuMoshtarian.Show();
        }

        private void btn_mahsolat_Click(object sender, EventArgs e)
        {
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.Show();
        }

        private void btn_panel_modiriat_Click(object sender, EventArgs e)
        {
            PanelModiriat panelModiriat = new PanelModiriat();
            panelModiriat.Show();
        }

        private void SafheAsli_Load(object sender, EventArgs e)
        {

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
            lb_date_time.Text = formattedDate;
        }
    }
}
