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
    public partial class ListMoshtarian : Form
    {
        public ListMoshtarian()
        {
            InitializeComponent();
        }

        private void gb_list_mahsolat_Enter(object sender, EventArgs e)
        {

        }

        private void btn_bazgasht_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMoshtarian menuMoshtarian = new MenuMoshtarian();
            menuMoshtarian.Show();
        }

        private void ListMoshtarian_Load(object sender, EventArgs e)
        {
            SqlConnection sc =
                new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT mo_nam,mo_famil FROM moshtarian";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nam = reader["mo_nam"].ToString();
                string famil = reader["mo_famil"].ToString();
                list_moshtarian.Items.Add(nam + " " + famil);
            }
            sc.Close();
        }

        private void list_moshtarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sc =
    new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT * FROM moshtarian";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            
            string fullname = list_moshtarian.SelectedItem.ToString();
            string[] fullname_array = fullname.Split(" ");
            while(reader.Read())
            {
                if (fullname_array[0] == reader["mo_nam"].ToString() && fullname_array[1] == reader["mo_famil"].ToString())
                {
                    tb_nam_moshtari.Text = fullname_array[0];
                    tb_famil_moshtari.Text = fullname_array[1];
                    tb_codemeli_moshtari.Text = reader["mo_code_meli"].ToString();
                    tb_adres_moshtari.Text = reader["mo_adres"].ToString();
                    tb_codeposti_moshtari.Text = reader["mo_code_posti"].ToString();
                    tb_email_moshtari.Text = reader["mo_email"].ToString();
                    tb_shomarecart_moshtari.Text = reader["mo_shomare_cart"].ToString();
                    tb_shomarehesab_moshtari.Text = reader["mo_shomare_hesab"].ToString();
                    tb_shomaresheba_moshtari.Text = reader["mo_shomare_sheba"].ToString();
                    tb_tel_moshtari.Text = reader["mo_tel"].ToString();
                    tb_tozihat_moshtari.Text = reader["mo_tozihat"].ToString();
                    cb_jensiat_moshtari.Text = reader["mo_jensiat"].ToString();
                    //rb_moshtari_vijhe.Checked = reader["mo_vijhe"];
                }
            }
            sc.Close();
        }
    }
}
