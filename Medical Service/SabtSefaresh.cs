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
    public partial class SabtSefaresh : Form
    {
        public SabtSefaresh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_khoroj_Click(object sender, EventArgs e)
        {
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
