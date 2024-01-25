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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Service
{
    public partial class VirayeshMoshtarian : Form
    {
        public VirayeshMoshtarian()
        {
            InitializeComponent();
        }

        private void btn_enseraf_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMoshtarian menuMoshtarian = new MenuMoshtarian();
            menuMoshtarian.Show();
        }

        private void btn_bazgasht_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMoshtarian menuMoshtarian = new MenuMoshtarian();
            menuMoshtarian.Show();
        }

        private void VirayeshMoshtarian_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخواهید تمام مشتریان را حذف کنید؟", "حذف کل", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection sc =
    new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
                    sc.Open();
                    string query = "DELETE FROM moshtarian";
                    SqlCommand command = new SqlCommand(query, sc);
                    command.ExecuteNonQuery();
                    sc.Close();
                    MessageBox.Show("حذف کل با موفقیت انجام شد");
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخواهید مشتری مورد نظر را حذف کنید؟", "حذف کل", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string fullname = list_moshtarian.SelectedItem.ToString();
                    string[] fullname_array = fullname.Split(" ");
                    SqlConnection sc =
    new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
                    sc.Open();
                    string query = "DELETE FROM moshtarian WHERE mo_nam='" + fullname_array[0] + "'";
                    SqlCommand command = new SqlCommand(query, sc);
                    command.ExecuteNonQuery();
                    sc.Close();
                    MessageBox.Show("حذف با موفقیت انجام شد");
                    list_moshtarian.Items.RemoveAt(list_moshtarian.SelectedIndex);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
            }
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
            while (reader.Read())
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

        private void btn_sabt_taghirat_Click(object sender, EventArgs e)
        {
            try
            {
                string nam = tb_nam_moshtari.Text;
                string famil = tb_famil_moshtari.Text;
                string codemeli = tb_codemeli_moshtari.Text;
                uint codemeli_ = uint.Parse(codemeli);
                string codeposti = tb_codeposti_moshtari.Text;
                long codeposti_ = long.Parse(codeposti);
                string adres = tb_adres_moshtari.Text;
                string email = tb_email_moshtari.Text;
                string shomarecart = tb_shomarecart_moshtari.Text;
                long shomarecart_ = long.Parse(shomarecart);
                string shomarehesab = tb_shomarehesab_moshtari.Text;
                long shomarehesab_ = long.Parse(shomarehesab);
                string shomaresheba = tb_shomaresheba_moshtari.Text;
                long shomaresheba_ = long.Parse(shomaresheba);
                string tel = tb_tel_moshtari.Text;
                long tel_ = long.Parse(tel);
                string tozihat = tb_tozihat_moshtari.Text;
                string jensiat = cb_jensiat_moshtari.SelectedItem.ToString();
                bool vijhe = rb_moshtari_vijhe.Checked;
                SqlConnection sc =
                    new SqlConnection(
                        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
                sc.Open();
                string query =
                    "UPDATE moshtarian SET mo_nam='" + nam + "',mo_famil='" + famil + "',mo_code_meli='" + codemeli_ + "',mo_code_posti='" + codeposti_ + "',mo_adres='" + adres + "',mo_email='" + email + "',mo_shomare_cart='" + shomarecart_ + "',mo_shomare_hesab='" + shomarehesab_ + "',mo_shomare_sheba='" + shomaresheba_ + "',mo_tel='" + tel_ + "',mo_tozihat='" + tozihat + "',mo_jensiat='" + jensiat + "',mo_vijhe='" + vijhe + "' WHERE mo_nam='" + nam + "'"; 
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
    }
}
