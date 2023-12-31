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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Service
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT name FROM products";
            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                comboBox1.Items.Add(name);
            }

            sc.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string name = comboBox1.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM products WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string name = txtB_name_update.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "UPDATE products SET sale_price='" + sale + "',buy_price='" + buy + "' WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Changes have been saved!!!!");
            txtB_name_update.Text = txtB_update_buy.Text = txtB_update_sale.Text = "";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string name = comboBox1.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM products WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();*/
        }
    }
}
