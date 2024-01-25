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

namespace Medical_Service
{
    public partial class SabtMahsol : Form
    {
        public SabtMahsol()
        {
            InitializeComponent();
        }

        private void SabtMahsol_Load(object sender, EventArgs e)
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

        private void reset_Click(object sender, EventArgs e)
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

        private void sabt_kala_Click(object sender, EventArgs e)
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
                        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Program Files\Medical Service\Medical Service\MedicalService.mdf"";Integrated Security=True");
                sc.Open();
                string query =
                    "INSERT INTO mahsolat (k_nam,k_code,k_gheymat,k_vahed,k_tedad,k_vazn,k_germaj,k_size,k_tol,k_arz,k_brand_parche,k_rang,k_tozihat,k_noye_kala) VALUES ('" + nam + "','" + code_ + "','" + gheymat_ + "','" + vahed + "','" + tedad_ + "','" + vazn_ + "','" + germaj_ + "','" + size + "','" + tol_ + "','" + arz_ + "','" + brand + "','" + rang + "','" + tozihat + "','" + noye + "')";
                SqlCommand command = new SqlCommand(query, sc);
                command.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("ثبت با موفقیت انجام شد!!!");
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
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
            }
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

        private void btn_bazgasht_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.Show();
        }

        private void btn_enseraf_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
