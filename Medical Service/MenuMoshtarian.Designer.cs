namespace Medical_Service
{
    partial class MenuMoshtarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMoshtarian));
            button9 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(296, 244);
            button9.Name = "button9";
            button9.Size = new Size(190, 57);
            button9.TabIndex = 35;
            button9.Text = "ویرایش مشتریان";
            button9.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(296, 283);
            button2.Name = "button2";
            button2.Size = new Size(190, 57);
            button2.TabIndex = 34;
            button2.Text = "نمایش مشتریان";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(342, 110);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(162, 90);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(369, 200);
            label5.Name = "label5";
            label5.Size = new Size(98, 29);
            label5.TabIndex = 36;
            label5.Text = "ثبت مشتری";
            // 
            // MenuMoshtarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Name = "MenuMoshtarian";
            Text = "MenuMoshtarian";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button9;
        private Button button2;
        private Button button1;
        private Label label5;
    }
}