using Medical_Service;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا مطمیین هستید که میخوایید خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 namayeshKala = new Form6();
            namayeshKala.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Form7 virayeshKala = new Form7();
            virayeshKala.ShowDialog();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MenuMahsolat menuMahsolat = new MenuMahsolat();
            menuMahsolat.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MenuMoshtarian menuMoshtarian = new MenuMoshtarian();
            menuMoshtarian.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MenuSefareshat menuSefareshat = new MenuSefareshat();
            menuSefareshat.ShowDialog();
        }

        private void btn_modiriat_anbar_Click(object sender, EventArgs e)
        {
            ModiriatAnbar modiriatAnbar = new ModiriatAnbar();
            modiriatAnbar.ShowDialog();
        }
    }
}