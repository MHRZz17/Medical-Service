using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Service
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlConnection sc = new SqlConnection("@\"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\Program Files\\Medical Service\\Medical Service\\MedicalService.mdf; Integrated Security = True\"");
            sc.Open();
            string query = "INSERT INTO kala (name) VALUES ('" + name + "')";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Changes have been saved!!!!");
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
