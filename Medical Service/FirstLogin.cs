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
    public partial class FirstLogin : Form
    {
        public FirstLogin()
        {
            InitializeComponent();
        }

        private void lb_mahsolat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstLogin_Load(object sender, EventArgs e)
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

        private void btn_vorod1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string pass = tb_pass.Text;
            try
            {
                SqlConnection sc =
    new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Program Files\Medical Service\Medical Service\MedicalService.mdf;Integrated Security=True");
                sc.Open();
                string query = "SELECT ad_username,ad_ramz FROM admin";
                SqlCommand command = new SqlCommand(query, sc);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nam_karbari = reader["ad_username"].ToString();
                    string ramz = reader["ad_ramz"].ToString();
                    if (nam_karbari == username && ramz == pass)
                    {
                        this.Hide();
                        SafheAsli safheAsli = new SafheAsli();
                        safheAsli.Show();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است!!!");
                        tb_username.Clear(); tb_pass.Clear();
                        return;
                    }
                }

                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داده است!!!");
                tb_username.Clear(); tb_pass.Clear();
                return;
            }
        }

        private void btn_faramoshi_Click(object sender, EventArgs e)
        {
            FaramoshiRamz faramoshiRamz = new FaramoshiRamz();
            faramoshiRamz.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
