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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("Customer.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
