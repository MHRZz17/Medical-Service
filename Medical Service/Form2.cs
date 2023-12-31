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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string famil = textBox2.Text;
                string tel = textBox3.Text;
                string address = textBox4.Text;
                string code_posti = textBox5.Text;
                string line = name + " " + famil + " , " + tel + " , " + address + " , " + code_posti + "\n";
                File.AppendAllText("Customer.txt", line);
                File.AppendAllText("Customer.csv", line);
                MessageBox.Show("ثبت با موفقیت انجام شد", "ثبت مشتری");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
