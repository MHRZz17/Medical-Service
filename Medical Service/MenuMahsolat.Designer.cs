namespace Medical_Service
{
    partial class MenuMahsolat
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
            btn_sabt_mahsolat = new Button();
            btn_virayesh_mahsolat = new Button();
            btn_list_mahsolat = new Button();
            lb_mahsolat = new Label();
            SuspendLayout();
            // 
            // btn_sabt_mahsolat
            // 
            btn_sabt_mahsolat.BackColor = SystemColors.ControlLightLight;
            btn_sabt_mahsolat.BackgroundImageLayout = ImageLayout.None;
            btn_sabt_mahsolat.FlatAppearance.BorderSize = 0;
            btn_sabt_mahsolat.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sabt_mahsolat.Location = new Point(24, 118);
            btn_sabt_mahsolat.Name = "btn_sabt_mahsolat";
            btn_sabt_mahsolat.Size = new Size(448, 75);
            btn_sabt_mahsolat.TabIndex = 31;
            btn_sabt_mahsolat.Text = "ثبت محصول";
            btn_sabt_mahsolat.UseVisualStyleBackColor = false;
            btn_sabt_mahsolat.Click += btn_sabt_mahsolat_Click;
            // 
            // btn_virayesh_mahsolat
            // 
            btn_virayesh_mahsolat.BackColor = SystemColors.ControlLightLight;
            btn_virayesh_mahsolat.BackgroundImageLayout = ImageLayout.None;
            btn_virayesh_mahsolat.FlatAppearance.BorderSize = 0;
            btn_virayesh_mahsolat.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_virayesh_mahsolat.Location = new Point(24, 211);
            btn_virayesh_mahsolat.Name = "btn_virayesh_mahsolat";
            btn_virayesh_mahsolat.Size = new Size(448, 76);
            btn_virayesh_mahsolat.TabIndex = 34;
            btn_virayesh_mahsolat.Text = "ویرایش محصولات";
            btn_virayesh_mahsolat.UseVisualStyleBackColor = false;
            btn_virayesh_mahsolat.Click += btn_virayesh_mahsolat_Click;
            // 
            // btn_list_mahsolat
            // 
            btn_list_mahsolat.BackgroundImageLayout = ImageLayout.None;
            btn_list_mahsolat.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_list_mahsolat.Location = new Point(24, 304);
            btn_list_mahsolat.Name = "btn_list_mahsolat";
            btn_list_mahsolat.Size = new Size(448, 71);
            btn_list_mahsolat.TabIndex = 33;
            btn_list_mahsolat.Text = "لیست محصولات";
            btn_list_mahsolat.UseVisualStyleBackColor = true;
            btn_list_mahsolat.Click += btn_list_mahsolat_Click;
            // 
            // lb_mahsolat
            // 
            lb_mahsolat.AutoSize = true;
            lb_mahsolat.BackColor = SystemColors.ActiveCaption;
            lb_mahsolat.Font = new Font("Mj_Heritage Two Bold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_mahsolat.Location = new Point(66, 28);
            lb_mahsolat.Name = "lb_mahsolat";
            lb_mahsolat.Size = new Size(359, 52);
            lb_mahsolat.TabIndex = 38;
            lb_mahsolat.Text = " :گزینه مورد را انتخاب کنید";
            // 
            // MenuMahsolat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(498, 385);
            Controls.Add(lb_mahsolat);
            Controls.Add(btn_virayesh_mahsolat);
            Controls.Add(btn_list_mahsolat);
            Controls.Add(btn_sabt_mahsolat);
            Name = "MenuMahsolat";
            Text = "منو محصولات";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sabt_mahsolat;
        private Button btn_virayesh_mahsolat;
        private Button btn_list_mahsolat;
        private Label lb_mahsolat;
    }
}