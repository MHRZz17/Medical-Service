using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخوایید تمام کالا ها را حذف کنید؟", "حذف کالا",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection sc =
                        new SqlConnection(
                            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Program Files\Medical Service\Medical Service\MedicalService.mdf"";Integrated Security=True");
                    sc.Open();
                    string query = "DELETE FROM kala";
                    SqlCommand command = new SqlCommand(query, sc);
                    command.ExecuteNonQuery();
                    sc.Close();
                    MessageBox.Show("حذف کل با موفقیت انجام شد!!!");
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حذف کل با خطا مواجه شد!!!");
            }
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
            try
            {
                DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخوایید این کالا را حذف کنید؟", "حذف کالا",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kala = list_kala.SelectedItem.ToString();
                    SqlConnection sc =
                        new SqlConnection(
                            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Program Files\Medical Service\Medical Service\MedicalService.mdf"";Integrated Security=True");
                    sc.Open();
                    string query = "DELETE FROM kala WHERE k_nam='" + kala + "'";
                    SqlCommand command = new SqlCommand(query, sc);
                    command.ExecuteNonQuery();
                    sc.Close();
                    MessageBox.Show("حذف با موفقیت انجام شد!!!");
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حذف با خطا مواجه شد!!!");
            }

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Program Files\Medical Service\Medical Service\MedicalService.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT k_nam FROM kala";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nam = reader["k_nam"].ToString();
                list_kala.Items.Add(nam);
            }

            sc.Close();
        }
    }
}
