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
    public partial class FaramoshiRamz : Form
    {
        public FaramoshiRamz()
        {
            InitializeComponent();
        }

        private void btn_bazyabi_ramz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("رمز عبور با موفقیت تغییر یافت!");
            this.Close();
        }

        private void btn_bazgasht_vorod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
