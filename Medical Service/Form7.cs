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
            SqlConnection sc =
new SqlConnection(
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT * FROM mahsolat";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();

            string kala = list_mahsolat.SelectedItem.ToString();
            while (reader.Read())
            {
                if (kala == reader["k_nam"].ToString())
                {
                    tb_arze_kala.Text = reader["k_arz"].ToString();
                    tb_brand_parche.Text = reader["k_brand_parche"].ToString();
                    tb_code_kala.Text = reader["k_code"].ToString();
                    tb_germaj_kala.Text = reader["k_germaj"].ToString();
                    tb_gheymat_kala.Text = reader["k_gheymat"].ToString();
                    tb_nam_kala.Text = reader["k_nam"].ToString();
                    tb_rang_kala.Text = reader["k_rang"].ToString();
                    tb_tole_kala.Text = reader["k_tol"].ToString();
                    tb_tozihat_kala.Text = reader["k_tozihat"].ToString();
                    tb_vazn_kala.Text = reader["k_vazn"].ToString();
                    cb_size_kala.Text = reader["k_size"].ToString();
                    cb_vahed_kala.Text = reader["k_vahed"].ToString();
                    nud_tedad_kala.Text = reader["k_tedad"].ToString();

                }
            }
            sc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection sc =
new SqlConnection(
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT k_nam FROM kala";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nam = reader["k_nam"].ToString();
                list_mahsolat.Items.Add(nam);
            }

            sc.Close();
        }

        private void btn_enseraf_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.Show();
        }

        private void btn_bazgasht_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخوایید این کالا را حذف کنید؟", "حذف کالا",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kala = list_mahsolat.SelectedItem.ToString();
                    SqlConnection sc =
        new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخوایید تمام کالا ها را حذف کنید؟", "حذف کالا",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection sc =
        new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nam = tb_nam_kala.Text;
                string arz = tb_arze_kala.Text;
                int arz_ = int.Parse(arz);
                string brand = tb_brand_parche.Text;
                string code = tb_code_kala.Text;
                int code_ = int.Parse(code);
                string germaj = tb_germaj_kala.Text;
                int germaj_ = int.Parse(germaj);
                string gheymat = tb_gheymat_kala.Text;
                long gheymat_ = long.Parse(gheymat);
                string rang = tb_rang_kala.Text;
                string tedad = nud_tedad_kala.Text;
                int tedad_ = int.Parse(tedad);
                string tol = tb_tole_kala.Text;
                int tol_ = int.Parse(tol);
                string vazn = tb_vazn_kala.Text;
                int vazn_ = int.Parse(vazn);
                string tozihat = tb_tozihat_kala.Text;
                string noye = cb_noye_kala.SelectedItem.ToString();
                string size = cb_size_kala.SelectedItem.ToString();
                string vahed = cb_vahed_kala.SelectedItem.ToString();
                SqlConnection sc =
    new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
                sc.Open();
                string query =
                    "UPDATE moshtarian SET k_nam='" + nam + "',k_tol='" + tol_ + "',k_code='" + code_ + "',k_arz='" + arz_ + "',k_tozihat='" + tozihat + "',k_size='" + size + "',k_noye_kala='" + noye + "',k_vahed='" + vahed + "',k_vazn='" + vazn_ + "',k_tedad='" + tedad_ + "',k_tozihat='" + tozihat + "',k_rang='" + rang + "',k_gheymat='" + gheymat_ + "',k_brand='" + brand + "' WHERE k_nam='" + nam + "'";
                SqlCommand command = new SqlCommand(query, sc);
                command.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("تغییرات با موفقیت انجام شد!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
            }
        }

        private void btn_khoroj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
