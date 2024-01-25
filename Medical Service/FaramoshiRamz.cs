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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Medical_Service
{
    public partial class FaramoshiRamz : Form
    {
        public FaramoshiRamz()
        {
            InitializeComponent();
        }

        private void btn_bazyabi_ramz_Click(object sender, EventArgs e)
        {

            try
            {
                string nam = tb_nam.Text;
                string famil = tb_famil.Text;
                string codemeli = tb_codemeli.Text;
                uint codemeli_ = uint.Parse(codemeli);
                string tel = tb_tel.Text;
                long tel_ = long.Parse(tel);
                string codekarmandi = tb_codekarmandi.Text;
                int codekarmandi_ = int.Parse(codekarmandi);
                string newpass = tb_newpass.Text;
                string repass = tb_repass.Text;
                if (repass == newpass)
                {
                    SqlConnection sc =
new SqlConnection(
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
                    sc.Open();
                    string query = "SELECT * FROM admin";
                    SqlCommand command = new SqlCommand(query, sc);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string nam_karbari = reader["ad_username"].ToString();
                        string ramz = reader["ad_ramz"].ToString();
                        string ad_nam = reader["ad_nam"].ToString();
                        string ad_famil = reader["ad_famil"].ToString();
                        string ad_codekarmandi = reader["ad_codekarmandi"].ToString();
                        int ad_codekarmandi_ = int.Parse(ad_codekarmandi);
                        string ad_codemeli = reader["ad_codemeli"].ToString();
                        uint ad_codemeli_ = uint.Parse(ad_codemeli);
                        string ad_tel = reader["ad_tel"].ToString();
                        long ad_tel_ = long.Parse(ad_tel);

                        if ((ad_nam == nam) && (ad_famil == famil) && (ad_codekarmandi_ == codekarmandi_) && (ad_codemeli_ == codemeli_) && (ad_tel_ == tel_))
                        {

                            string query_ = "UPDATE admin SET ad_ramz='" + newpass + "'";
                            SqlCommand command_ = new SqlCommand(query_, sc);
                            command_.ExecuteNonQuery();
                            sc.Close();
                            MessageBox.Show("رمز عبور با موفقیت تغییر یافت!");
                            this.Hide();
                            FirstLogin firstLogin = new FirstLogin();
                            firstLogin.Show();
                        }
                        else
                        {
                            MessageBox.Show("اطلاعات وارد شده اشتباه می باشد!!!");
                            tb_codekarmandi.Clear(); tb_codemeli.Clear(); tb_famil.Clear(); tb_nam.Clear(); tb_newpass.Clear(); tb_repass.Clear(); tb_tel.Clear();
                            return;
                        }
                    }

                    sc.Close();
                }
                else
                {
                    MessageBox.Show("تکرار رمز عبور با رمز جدید وارد شده یکسان نمی باشد!!!");
                    tb_newpass.Clear(); tb_repass.Clear();
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
                tb_codekarmandi.Clear(); tb_codemeli.Clear(); tb_famil.Clear(); tb_nam.Clear(); tb_newpass.Clear(); tb_repass.Clear(); tb_tel.Clear();
                return;
            }
        }

        private void btn_bazgasht_vorod_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstLogin firstLogin = new FirstLogin();
            firstLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_khoroj_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخوایید خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
