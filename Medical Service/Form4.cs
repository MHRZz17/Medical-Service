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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("Customer.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string line = "";
            File.WriteAllText("Customer.txt", line);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
