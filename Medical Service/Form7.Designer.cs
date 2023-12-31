namespace Medical_Service
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bazgasht = new Button();
            hazf_kol = new Button();
            sabt_virayesh = new Button();
            list_kala = new ListBox();
            label7 = new Label();
            label6 = new Label();
            hazf_kala = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            cb_noye_kala = new ComboBox();
            noye_kala = new Label();
            tb_rang_kala = new TextBox();
            rang_kala = new Label();
            cb_size_kala = new ComboBox();
            tb_tozihat_kala = new TextBox();
            tozihat_kala = new Label();
            size_kala = new Label();
            tb_arze_kala = new TextBox();
            arze_kala = new Label();
            tb_brand_parche = new TextBox();
            tb_tole_kala = new TextBox();
            tole_kala = new Label();
            tb_vazn_kala = new TextBox();
            vazn_kala = new Label();
            tb_germaj_kala = new TextBox();
            germaj_kala = new Label();
            tb_tedad_kala = new TextBox();
            tedad_kala = new Label();
            cb_vahed_kala = new ComboBox();
            vahed_kala = new Label();
            tb_nam_kala = new TextBox();
            nam_kala = new Label();
            brand_parche = new Label();
            code_kala = new Label();
            tb_code_kala = new TextBox();
            tb_gheymat_kala = new TextBox();
            gheymat_kala = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bazgasht
            // 
            bazgasht.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bazgasht.Location = new Point(33, 567);
            bazgasht.Name = "bazgasht";
            bazgasht.Size = new Size(135, 66);
            bazgasht.TabIndex = 66;
            bazgasht.Text = "بازگشت";
            bazgasht.UseVisualStyleBackColor = true;
            bazgasht.Click += button4_Click;
            // 
            // hazf_kol
            // 
            hazf_kol.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            hazf_kol.Location = new Point(447, 567);
            hazf_kol.Name = "hazf_kol";
            hazf_kol.Size = new Size(140, 66);
            hazf_kol.TabIndex = 65;
            hazf_kol.Text = "حذف کل";
            hazf_kol.UseVisualStyleBackColor = true;
            hazf_kol.Click += button3_Click;
            // 
            // sabt_virayesh
            // 
            sabt_virayesh.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sabt_virayesh.Location = new Point(174, 567);
            sabt_virayesh.Name = "sabt_virayesh";
            sabt_virayesh.Size = new Size(133, 66);
            sabt_virayesh.TabIndex = 64;
            sabt_virayesh.Text = "ثبت ویرایش";
            sabt_virayesh.UseVisualStyleBackColor = true;
            sabt_virayesh.Click += button2_Click;
            // 
            // list_kala
            // 
            list_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            list_kala.FormattingEnabled = true;
            list_kala.ItemHeight = 35;
            list_kala.Location = new Point(21, 26);
            list_kala.Name = "list_kala";
            list_kala.RightToLeft = RightToLeft.Yes;
            list_kala.Size = new Size(492, 599);
            list_kala.TabIndex = 63;
            list_kala.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mj_Heritage Two Bold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1057, 25);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(204, 57);
            label7.TabIndex = 62;
            label7.Text = "اطلاعات کالا";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mj_Heritage Two Bold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(197, 25);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(161, 57);
            label6.TabIndex = 61;
            label6.Text = "لیست کالا";
            // 
            // hazf_kala
            // 
            hazf_kala.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            hazf_kala.Location = new Point(313, 567);
            hazf_kala.Name = "hazf_kala";
            hazf_kala.Size = new Size(128, 66);
            hazf_kala.TabIndex = 60;
            hazf_kala.Text = "حذف کالا";
            hazf_kala.UseVisualStyleBackColor = true;
            hazf_kala.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(list_kala);
            groupBox2.Location = new Point(32, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(537, 649);
            groupBox2.TabIndex = 68;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(cb_noye_kala);
            groupBox1.Controls.Add(noye_kala);
            groupBox1.Controls.Add(tb_rang_kala);
            groupBox1.Controls.Add(rang_kala);
            groupBox1.Controls.Add(bazgasht);
            groupBox1.Controls.Add(hazf_kala);
            groupBox1.Controls.Add(cb_size_kala);
            groupBox1.Controls.Add(hazf_kol);
            groupBox1.Controls.Add(tb_tozihat_kala);
            groupBox1.Controls.Add(tozihat_kala);
            groupBox1.Controls.Add(sabt_virayesh);
            groupBox1.Controls.Add(size_kala);
            groupBox1.Controls.Add(tb_arze_kala);
            groupBox1.Controls.Add(arze_kala);
            groupBox1.Controls.Add(tb_brand_parche);
            groupBox1.Controls.Add(tb_tole_kala);
            groupBox1.Controls.Add(tole_kala);
            groupBox1.Controls.Add(tb_vazn_kala);
            groupBox1.Controls.Add(vazn_kala);
            groupBox1.Controls.Add(tb_germaj_kala);
            groupBox1.Controls.Add(germaj_kala);
            groupBox1.Controls.Add(tb_tedad_kala);
            groupBox1.Controls.Add(tedad_kala);
            groupBox1.Controls.Add(cb_vahed_kala);
            groupBox1.Controls.Add(vahed_kala);
            groupBox1.Controls.Add(tb_nam_kala);
            groupBox1.Controls.Add(nam_kala);
            groupBox1.Controls.Add(brand_parche);
            groupBox1.Controls.Add(code_kala);
            groupBox1.Controls.Add(tb_code_kala);
            groupBox1.Controls.Add(tb_gheymat_kala);
            groupBox1.Controls.Add(gheymat_kala);
            groupBox1.Location = new Point(575, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(1147, 639);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cb_noye_kala
            // 
            cb_noye_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_noye_kala.FormattingEnabled = true;
            cb_noye_kala.Items.AddRange(new object[] { "البسه یکبار مصرف بیمارستانی" });
            cb_noye_kala.Location = new Point(697, 547);
            cb_noye_kala.Name = "cb_noye_kala";
            cb_noye_kala.RightToLeft = RightToLeft.Yes;
            cb_noye_kala.Size = new Size(293, 43);
            cb_noye_kala.TabIndex = 68;
            // 
            // noye_kala
            // 
            noye_kala.AutoSize = true;
            noye_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            noye_kala.Location = new Point(1029, 550);
            noye_kala.Name = "noye_kala";
            noye_kala.RightToLeft = RightToLeft.Yes;
            noye_kala.Size = new Size(84, 36);
            noye_kala.TabIndex = 67;
            noye_kala.Text = "نوع کالا";
            // 
            // tb_rang_kala
            // 
            tb_rang_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_rang_kala.Location = new Point(106, 345);
            tb_rang_kala.Name = "tb_rang_kala";
            tb_rang_kala.RightToLeft = RightToLeft.Yes;
            tb_rang_kala.Size = new Size(293, 42);
            tb_rang_kala.TabIndex = 55;
            // 
            // rang_kala
            // 
            rang_kala.AutoSize = true;
            rang_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            rang_kala.Location = new Point(468, 348);
            rang_kala.Name = "rang_kala";
            rang_kala.RightToLeft = RightToLeft.Yes;
            rang_kala.Size = new Size(50, 36);
            rang_kala.TabIndex = 54;
            rang_kala.Text = "رنگ";
            // 
            // cb_size_kala
            // 
            cb_size_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_size_kala.FormattingEnabled = true;
            cb_size_kala.Items.AddRange(new object[] { "لارج", "مدیوم", "اسمال" });
            cb_size_kala.Location = new Point(106, 38);
            cb_size_kala.Name = "cb_size_kala";
            cb_size_kala.Size = new Size(293, 43);
            cb_size_kala.TabIndex = 53;
            // 
            // tb_tozihat_kala
            // 
            tb_tozihat_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_tozihat_kala.Location = new Point(95, 411);
            tb_tozihat_kala.Name = "tb_tozihat_kala";
            tb_tozihat_kala.RightToLeft = RightToLeft.Yes;
            tb_tozihat_kala.Size = new Size(481, 42);
            tb_tozihat_kala.TabIndex = 52;
            // 
            // tozihat_kala
            // 
            tozihat_kala.AutoSize = true;
            tozihat_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tozihat_kala.Location = new Point(582, 417);
            tozihat_kala.Name = "tozihat_kala";
            tozihat_kala.RightToLeft = RightToLeft.Yes;
            tozihat_kala.Size = new Size(104, 36);
            tozihat_kala.TabIndex = 51;
            tozihat_kala.Text = "توضیحات";
            // 
            // size_kala
            // 
            size_kala.AutoSize = true;
            size_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            size_kala.Location = new Point(490, 38);
            size_kala.Name = "size_kala";
            size_kala.RightToLeft = RightToLeft.Yes;
            size_kala.Size = new Size(54, 36);
            size_kala.TabIndex = 49;
            size_kala.Text = "سایز";
            // 
            // tb_arze_kala
            // 
            tb_arze_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_arze_kala.Location = new Point(106, 199);
            tb_arze_kala.Name = "tb_arze_kala";
            tb_arze_kala.RightToLeft = RightToLeft.No;
            tb_arze_kala.Size = new Size(293, 42);
            tb_arze_kala.TabIndex = 48;
            // 
            // arze_kala
            // 
            arze_kala.AutoSize = true;
            arze_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            arze_kala.Location = new Point(429, 205);
            arze_kala.Name = "arze_kala";
            arze_kala.RightToLeft = RightToLeft.Yes;
            arze_kala.Size = new Size(181, 36);
            arze_kala.TabIndex = 47;
            arze_kala.Text = "عرض(سانتی متر)";
            // 
            // tb_brand_parche
            // 
            tb_brand_parche.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_brand_parche.Location = new Point(106, 275);
            tb_brand_parche.Name = "tb_brand_parche";
            tb_brand_parche.RightToLeft = RightToLeft.Yes;
            tb_brand_parche.Size = new Size(293, 42);
            tb_brand_parche.TabIndex = 46;
            // 
            // tb_tole_kala
            // 
            tb_tole_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_tole_kala.Location = new Point(106, 124);
            tb_tole_kala.Name = "tb_tole_kala";
            tb_tole_kala.RightToLeft = RightToLeft.No;
            tb_tole_kala.Size = new Size(293, 42);
            tb_tole_kala.TabIndex = 44;
            // 
            // tole_kala
            // 
            tole_kala.AutoSize = true;
            tole_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tole_kala.Location = new Point(429, 130);
            tole_kala.Name = "tole_kala";
            tole_kala.RightToLeft = RightToLeft.Yes;
            tole_kala.Size = new Size(176, 36);
            tole_kala.TabIndex = 43;
            tole_kala.Text = "طول(سانتی متر)";
            // 
            // tb_vazn_kala
            // 
            tb_vazn_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_vazn_kala.Location = new Point(697, 418);
            tb_vazn_kala.Name = "tb_vazn_kala";
            tb_vazn_kala.RightToLeft = RightToLeft.No;
            tb_vazn_kala.Size = new Size(293, 42);
            tb_vazn_kala.TabIndex = 42;
            // 
            // vazn_kala
            // 
            vazn_kala.AutoSize = true;
            vazn_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            vazn_kala.Location = new Point(1015, 408);
            vazn_kala.Name = "vazn_kala";
            vazn_kala.RightToLeft = RightToLeft.Yes;
            vazn_kala.Size = new Size(105, 36);
            vazn_kala.TabIndex = 41;
            vazn_kala.Text = "وزن(گرم)";
            // 
            // tb_germaj_kala
            // 
            tb_germaj_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_germaj_kala.Location = new Point(697, 485);
            tb_germaj_kala.Name = "tb_germaj_kala";
            tb_germaj_kala.RightToLeft = RightToLeft.No;
            tb_germaj_kala.Size = new Size(293, 42);
            tb_germaj_kala.TabIndex = 40;
            // 
            // germaj_kala
            // 
            germaj_kala.AutoSize = true;
            germaj_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            germaj_kala.Location = new Point(1051, 474);
            germaj_kala.Name = "germaj_kala";
            germaj_kala.RightToLeft = RightToLeft.Yes;
            germaj_kala.Size = new Size(62, 36);
            germaj_kala.TabIndex = 39;
            germaj_kala.Text = "گرماژ";
            // 
            // tb_tedad_kala
            // 
            tb_tedad_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_tedad_kala.Location = new Point(697, 348);
            tb_tedad_kala.Name = "tb_tedad_kala";
            tb_tedad_kala.RightToLeft = RightToLeft.No;
            tb_tedad_kala.Size = new Size(293, 42);
            tb_tedad_kala.TabIndex = 38;
            // 
            // tedad_kala
            // 
            tedad_kala.AutoSize = true;
            tedad_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tedad_kala.Location = new Point(1051, 348);
            tedad_kala.Name = "tedad_kala";
            tedad_kala.RightToLeft = RightToLeft.Yes;
            tedad_kala.Size = new Size(69, 36);
            tedad_kala.TabIndex = 37;
            tedad_kala.Text = "تعداد";
            // 
            // cb_vahed_kala
            // 
            cb_vahed_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_vahed_kala.FormattingEnabled = true;
            cb_vahed_kala.Items.AddRange(new object[] { "عدد" });
            cb_vahed_kala.Location = new Point(697, 268);
            cb_vahed_kala.Name = "cb_vahed_kala";
            cb_vahed_kala.Size = new Size(293, 43);
            cb_vahed_kala.TabIndex = 36;
            // 
            // vahed_kala
            // 
            vahed_kala.AutoSize = true;
            vahed_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            vahed_kala.Location = new Point(988, 271);
            vahed_kala.Name = "vahed_kala";
            vahed_kala.RightToLeft = RightToLeft.Yes;
            vahed_kala.Size = new Size(135, 36);
            vahed_kala.TabIndex = 35;
            vahed_kala.Text = "واحد شمارش";
            // 
            // tb_nam_kala
            // 
            tb_nam_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_nam_kala.Location = new Point(697, 29);
            tb_nam_kala.Name = "tb_nam_kala";
            tb_nam_kala.RightToLeft = RightToLeft.Yes;
            tb_nam_kala.Size = new Size(293, 42);
            tb_nam_kala.TabIndex = 26;
            // 
            // nam_kala
            // 
            nam_kala.AutoSize = true;
            nam_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            nam_kala.Location = new Point(1047, 35);
            nam_kala.Name = "nam_kala";
            nam_kala.RightToLeft = RightToLeft.Yes;
            nam_kala.Size = new Size(84, 36);
            nam_kala.TabIndex = 21;
            nam_kala.Text = " نام کالا";
            // 
            // brand_parche
            // 
            brand_parche.AutoSize = true;
            brand_parche.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            brand_parche.Location = new Point(468, 278);
            brand_parche.Name = "brand_parche";
            brand_parche.RightToLeft = RightToLeft.Yes;
            brand_parche.Size = new Size(108, 36);
            brand_parche.TabIndex = 33;
            brand_parche.Text = "برند پارچه";
            // 
            // code_kala
            // 
            code_kala.AutoSize = true;
            code_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            code_kala.Location = new Point(1080, 115);
            code_kala.Name = "code_kala";
            code_kala.RightToLeft = RightToLeft.Yes;
            code_kala.Size = new Size(40, 36);
            code_kala.TabIndex = 22;
            code_kala.Text = "کد";
            // 
            // tb_code_kala
            // 
            tb_code_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_code_kala.Location = new Point(697, 109);
            tb_code_kala.Name = "tb_code_kala";
            tb_code_kala.RightToLeft = RightToLeft.No;
            tb_code_kala.Size = new Size(293, 42);
            tb_code_kala.TabIndex = 27;
            // 
            // tb_gheymat_kala
            // 
            tb_gheymat_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_gheymat_kala.Location = new Point(697, 196);
            tb_gheymat_kala.Name = "tb_gheymat_kala";
            tb_gheymat_kala.RightToLeft = RightToLeft.No;
            tb_gheymat_kala.Size = new Size(293, 42);
            tb_gheymat_kala.TabIndex = 29;
            // 
            // gheymat_kala
            // 
            gheymat_kala.AutoSize = true;
            gheymat_kala.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            gheymat_kala.Location = new Point(988, 196);
            gheymat_kala.Name = "gheymat_kala";
            gheymat_kala.RightToLeft = RightToLeft.Yes;
            gheymat_kala.Size = new Size(143, 36);
            gheymat_kala.TabIndex = 24;
            gheymat_kala.Text = "قیمت(تومان)";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1764, 760);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bazgasht;
        private Button hazf_kol;
        private Button sabt_virayesh;
        private ListBox list_kala;
        private Label label7;
        private Label label6;
        private Button hazf_kala;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox tb_rang_kala;
        private Label rang_kala;
        private ComboBox cb_size_kala;
        private TextBox tb_tozihat_kala;
        private Label tozihat_kala;
        private Label size_kala;
        private TextBox tb_arze_kala;
        private Label arze_kala;
        private TextBox tb_brand_parche;
        private TextBox tb_tole_kala;
        private Label tole_kala;
        private TextBox tb_vazn_kala;
        private Label vazn_kala;
        private TextBox tb_germaj_kala;
        private Label germaj_kala;
        private TextBox tb_tedad_kala;
        private Label tedad_kala;
        private ComboBox cb_vahed_kala;
        private Label vahed_kala;
        private TextBox tb_nam_kala;
        private Label nam_kala;
        private Label brand_parche;
        private Label code_kala;
        private TextBox tb_code_kala;
        private TextBox tb_gheymat_kala;
        private Label gheymat_kala;
        private ComboBox cb_noye_kala;
        private Label noye_kala;
    }
}