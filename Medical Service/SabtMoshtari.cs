using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Service
{
    public partial class SabtMoshtari : Form
    {
        public SabtMoshtari()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_enseraf_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMoshtarian menuMoshtarian = new MenuMoshtarian();
            menuMoshtarian.Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_adres_moshtari.Text = string.Empty;
            tb_codemeli_moshtari.Text = string.Empty;
            tb_codeposti_moshtari.Text = string.Empty;
            tb_email_moshtari.Text = string.Empty;
            tb_famil_moshtari.Text = string.Empty;
            tb_nam_moshtari.Text = string.Empty;
            tb_shomarecart_moshtari.Text = string.Empty;
            tb_shomarehesab_moshtari.Text = string.Empty;
            tb_shomaresheba_moshtari.Text = string.Empty;
            tb_tel_moshtari.Text = string.Empty;
            tb_tozihat_moshtari.Text = string.Empty;
            cb_jensiat_moshtari.Text = string.Empty;
            //rb_moshtari_vijhe.Checked = bool.Empty;
        }

        private void btn_sabt_moshtari_Click(object sender, EventArgs e)
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
                    "INSERT INTO moshtarian (mo_nam,mo_famil,mo_tel,mo_adres,mo_email,mo_code_posti,mo_jensiat,mo_shomare_hesab,mo_shomare_cart,mo_shomare_sheba,mo_code_meli,mo_tozihat,mo_vijhe) VALUES ('" + nam + "','" + famil + "','" + tel_ + "','" + adres + "','" + email + "','" + codeposti + "','" + jensiat + "','" + shomarehesab_ + "','" + shomarecart_ + "','" + shomaresheba_ + "','" + codemeli_ + "','" + tozihat + "','" + vijhe + "')";
                SqlCommand command = new SqlCommand(query, sc);
                command.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("ثبت با موفقیت انجام شد!!!");
                tb_adres_moshtari.Text = string.Empty;
                tb_codemeli_moshtari.Text = string.Empty;
                tb_codeposti_moshtari.Text = string.Empty;
                tb_email_moshtari.Text = string.Empty;
                tb_famil_moshtari.Text = string.Empty;
                tb_nam_moshtari.Text = string.Empty;
                tb_shomarecart_moshtari.Text = string.Empty;
                tb_shomarehesab_moshtari.Text = string.Empty;
                tb_shomaresheba_moshtari.Text = string.Empty;
                tb_tel_moshtari.Text = string.Empty;
                tb_tozihat_moshtari.Text = string.Empty;
                cb_jensiat_moshtari.Text = string.Empty;
                //rb_moshtari_vijhe.Checked = bool.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SabtMoshtari_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
            lb_date_time.Text = formattedDate;
        }

        private void btn_bazgasht_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMoshtarian menuMoshtarian = new MenuMoshtarian();
            menuMoshtarian.Show();
        }

        private void gb_sabt_mahsolat_Enter(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
