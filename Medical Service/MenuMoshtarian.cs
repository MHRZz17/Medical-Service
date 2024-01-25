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
    public partial class MenuMoshtarian : Form
    {
        public MenuMoshtarian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SabtMoshtari sabtMoshtari = new SabtMoshtari();
            sabtMoshtari.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            VirayeshMoshtarian virayeshMoshtarian = new VirayeshMoshtarian();
            virayeshMoshtarian.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListMoshtarian listMoshtari = new ListMoshtarian();
            listMoshtari.Show();
        }

        private void btn_bazgasht_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
