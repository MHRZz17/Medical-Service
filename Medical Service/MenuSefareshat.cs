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
    public partial class MenuSefareshat : Form
    {
        public MenuSefareshat()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sabt_moshtari_Click(object sender, EventArgs e)
        {
            SabtSefaresh sabtSefaresh = new SabtSefaresh();
            sabtSefaresh.Show();
        }
    }
}
