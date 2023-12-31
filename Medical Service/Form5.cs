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
            try
            {
                string nam_kala = tb_nam_kala.Text;
                string arze_kala = tb_arze_kala.Text;
                int arze_kala_ = int.Parse(arze_kala);
                string brand_parche = tb_brand_parche.Text;
                string code_kala = tb_code_kala.Text;
                int code_kala_ = int.Parse(code_kala);
                string germaj_kala = tb_germaj_kala.Text;
                int germaj_kala_ = int.Parse(germaj_kala);
                string gheymat_kala = tb_gheymat_kala.Text;
                int gheymat_kala_ = int.Parse(gheymat_kala);
                string rang_kala = tb_rang_kala.Text;
                string tedad_kala = tb_tedad_kala.Text;
                int tedad_kala_ = int.Parse(tedad_kala);
                string tole_kala = tb_tole_kala.Text;
                int tole_kala_ = int.Parse(tole_kala);
                string vazn_kala = tb_vazn_kala.Text;
                int vazn_kala_ = int.Parse(vazn_kala);
                string tozihat_kala = tb_tozihat_kala.Text;
                string noye_kala = cb_noye_kala.SelectedItem.ToString();
                string size_kala = cb_size_kala.SelectedItem.ToString();
                string vahed_kala = cb_vahed_kala.SelectedItem.ToString();
                SqlConnection sc =
                    new SqlConnection(
                        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Program Files\Medical Service\Medical Service\MedicalService.mdf"";Integrated Security=True");
                sc.Open();
                string query =
                    "INSERT INTO kala (k_nam,k_code,k_gheymat,k_vahed,k_tedad,k_vazn,k_germaj,k_size,k_tol,k_arz,k_brand_parche,k_rang,k_tozihat,k_noye_kala) VALUES ('\" + nam_kala + \"'+'\" + code_kala_ + \"'+'\" + gheymat_kala_ + \"'+'\" + vahed_kala + \"'+'\" + tedad_kala_ + \"'+'\" + vazn_kala_ + \"'+'\" + germaj_kala_ + \"'+'\" + size_kala + \"'+'\" + tole_kala_ + \"'+'\" + arze_kala_ + \"'+'\" + brand_parche + \"'+'\" + rang_kala + \"'+'\" + tozihat_kala + \"'+'\" + noye_kala + \"')";
                SqlCommand command = new SqlCommand(query, sc);
                command.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("ثبت با موفقیت انجام شد!!!");
                tb_nam_kala.Text = cb_vahed_kala.Text = cb_size_kala.Text = cb_noye_kala.Text = tb_tozihat_kala.Text =
                    tb_vazn_kala.Text = tb_tole_kala.Text = tb_tedad_kala.Text = tb_rang_kala.Text =
                        tb_gheymat_kala.Text = tb_arze_kala.Text =
                            tb_brand_parche.Text = tb_code_kala.Text = tb_germaj_kala.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_nam_kala.Text = string.Empty;
            tb_arze_kala.Text = string.Empty;
            tb_brand_parche.Text = string.Empty;
            tb_code_kala.Text = string.Empty;
            tb_germaj_kala.Text = string.Empty;
            tb_gheymat_kala.Text = string.Empty;
            tb_rang_kala.Text = string.Empty;
            tb_tedad_kala.Text = string.Empty;
            tb_tole_kala.Text = string.Empty;
            tb_vazn_kala.Text = string.Empty;
            tb_tozihat_kala.Text = string.Empty;
            cb_noye_kala.Text = string.Empty;
            cb_size_kala.Text = string.Empty;
            cb_vahed_kala.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
