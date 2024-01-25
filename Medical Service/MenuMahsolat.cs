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
    public partial class MenuMahsolat : Form
    {
        public MenuMahsolat()
        {
            InitializeComponent();
        }

        private void btn_sabt_mahsolat_Click(object sender, EventArgs e)
        {

        }

        private void btn_virayesh_mahsolat_Click(object sender, EventArgs e)
        {

        }

        private void btn_list_mahsolat_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sabt_moshtari_Click(object sender, EventArgs e)
        {
            SabtMahsol sabtMahsol = new SabtMahsol();
            sabtMahsol.Show();
        }

        private void btn_virayesh_moshtari_Click(object sender, EventArgs e)
        {
            Form7 virayeshMahsolat = new Form7();
            virayeshMahsolat.Show();
        }

        private void btn_list_moshtari_Click(object sender, EventArgs e)
        {
            Form6 listMahsolat = new Form6();
            listMahsolat.Show();
        }
    }
}
