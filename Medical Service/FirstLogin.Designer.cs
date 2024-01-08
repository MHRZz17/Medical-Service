namespace Medical_Service
{
    partial class FirstLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLogin));
            gb_login1 = new GroupBox();
            btn_vorod1 = new Button();
            btn_faramoshi = new Button();
            tb_username = new TextBox();
            tb_pass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lb_khoroj = new Label();
            btn_khoroj = new Button();
            gb_login1.SuspendLayout();
            SuspendLayout();
            // 
            // gb_login1
            // 
            gb_login1.BackColor = SystemColors.GradientInactiveCaption;
            gb_login1.Controls.Add(btn_vorod1);
            gb_login1.Controls.Add(btn_faramoshi);
            gb_login1.Controls.Add(tb_username);
            gb_login1.Controls.Add(tb_pass);
            gb_login1.Controls.Add(label2);
            gb_login1.Controls.Add(label1);
            gb_login1.Font = new Font("Mj_Heritage Two Bold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gb_login1.Location = new Point(358, 176);
            gb_login1.Name = "gb_login1";
            gb_login1.RightToLeft = RightToLeft.Yes;
            gb_login1.Size = new Size(664, 378);
            gb_login1.TabIndex = 40;
            gb_login1.TabStop = false;
            gb_login1.Text = "ورود";
            // 
            // btn_vorod1
            // 
            btn_vorod1.BackColor = SystemColors.ControlLightLight;
            btn_vorod1.BackgroundImageLayout = ImageLayout.None;
            btn_vorod1.FlatAppearance.BorderSize = 0;
            btn_vorod1.Font = new Font("Mj_Heritage Two Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_vorod1.Location = new Point(122, 278);
            btn_vorod1.Name = "btn_vorod1";
            btn_vorod1.Size = new Size(189, 60);
            btn_vorod1.TabIndex = 48;
            btn_vorod1.Text = "ورود";
            btn_vorod1.UseVisualStyleBackColor = false;
            btn_vorod1.Click += btn_vorod1_Click;
            // 
            // btn_faramoshi
            // 
            btn_faramoshi.BackColor = SystemColors.GradientInactiveCaption;
            btn_faramoshi.BackgroundImageLayout = ImageLayout.None;
            btn_faramoshi.FlatAppearance.BorderSize = 0;
            btn_faramoshi.FlatStyle = FlatStyle.Flat;
            btn_faramoshi.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_faramoshi.Location = new Point(407, 288);
            btn_faramoshi.Name = "btn_faramoshi";
            btn_faramoshi.Size = new Size(170, 44);
            btn_faramoshi.TabIndex = 47;
            btn_faramoshi.Text = "فراموشی رمز عبور؟";
            btn_faramoshi.UseVisualStyleBackColor = false;
            btn_faramoshi.Click += btn_faramoshi_Click;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_username.Location = new Point(76, 120);
            tb_username.Name = "tb_username";
            tb_username.RightToLeft = RightToLeft.No;
            tb_username.Size = new Size(293, 42);
            tb_username.TabIndex = 46;
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_pass.Location = new Point(76, 204);
            tb_pass.Name = "tb_pass";
            tb_pass.RightToLeft = RightToLeft.No;
            tb_pass.Size = new Size(293, 42);
            tb_pass.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Mj_Heritage Two Bold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(426, 110);
            label2.Name = "label2";
            label2.Size = new Size(151, 52);
            label2.TabIndex = 41;
            label2.Text = "نام کاربری";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Mj_Heritage Two Bold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(450, 194);
            label1.Name = "label1";
            label1.Size = new Size(127, 52);
            label1.TabIndex = 40;
            label1.Text = "رمز ورود";
            label1.Click += label1_Click;
            // 
            // lb_khoroj
            // 
            lb_khoroj.AutoSize = true;
            lb_khoroj.BackColor = SystemColors.ActiveCaption;
            lb_khoroj.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_khoroj.Location = new Point(1256, 126);
            lb_khoroj.Name = "lb_khoroj";
            lb_khoroj.Size = new Size(55, 29);
            lb_khoroj.TabIndex = 42;
            lb_khoroj.Text = "خروج";
            // 
            // btn_khoroj
            // 
            btn_khoroj.BackColor = SystemColors.ActiveCaption;
            btn_khoroj.BackgroundImage = (Image)resources.GetObject("btn_khoroj.BackgroundImage");
            btn_khoroj.BackgroundImageLayout = ImageLayout.Center;
            btn_khoroj.FlatAppearance.BorderSize = 0;
            btn_khoroj.FlatStyle = FlatStyle.Flat;
            btn_khoroj.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_khoroj.Location = new Point(1228, 21);
            btn_khoroj.Name = "btn_khoroj";
            btn_khoroj.RightToLeft = RightToLeft.Yes;
            btn_khoroj.Size = new Size(111, 102);
            btn_khoroj.TabIndex = 41;
            btn_khoroj.UseVisualStyleBackColor = false;
            btn_khoroj.Click += btn_khoroj_Click;
            // 
            // FirstLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1351, 722);
            ControlBox = false;
            Controls.Add(lb_khoroj);
            Controls.Add(btn_khoroj);
            Controls.Add(gb_login1);
            Name = "FirstLogin";
            ShowInTaskbar = false;
            Text = "صفحه ورود";
            Load += FirstLogin_Load;
            gb_login1.ResumeLayout(false);
            gb_login1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gb_login1;
        private Label label2;
        private Label label1;
        private TextBox tb_username;
        private TextBox tb_pass;
        private Button btn_vorod1;
        private Button btn_faramoshi;
        private Label lb_khoroj;
        private Button btn_khoroj;
    }
}