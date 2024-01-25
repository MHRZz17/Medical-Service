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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            nud_tedad_kala.Text = string.Empty;
            tb_tole_kala.Text = string.Empty;
            tb_vazn_kala.Text = string.Empty;
            tb_tozihat_kala.Text = string.Empty;
            cb_noye_kala.Text = string.Empty;
            cb_size_kala.Text = string.Empty;
            cb_vahed_kala.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
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

        private void list_mahsolat_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btn_bazgasht_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.Show();
        }

        private void btn_khoroj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

