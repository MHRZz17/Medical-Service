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
    public partial class PanelModiriat : Form
    {
        public PanelModiriat()
        {
            InitializeComponent();
        }

        private void PanelModiriat_Load(object sender, EventArgs e)
        {
            Login2 login2 = new Login2();
            login2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
