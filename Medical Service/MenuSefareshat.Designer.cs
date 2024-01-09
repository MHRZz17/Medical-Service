namespace Medical_Service
{
    partial class MenuSefareshat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSefareshat));
            button5 = new Button();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.Orange;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(200, 76);
            button5.Name = "button5";
            button5.Size = new Size(82, 64);
            button5.TabIndex = 30;
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(313, 94);
            label2.Name = "label2";
            label2.Size = new Size(99, 29);
            label2.TabIndex = 31;
            label2.Text = "ثبت سفارش";
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(200, 193);
            button2.Name = "button2";
            button2.Size = new Size(82, 64);
            button2.TabIndex = 32;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Mj_Heritage Two Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 211);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 33;
            label1.Text = "لیست سفارشات";
            // 
            // MenuSefareshat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 404);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label2);
            Name = "MenuSefareshat";
            Text = "MenuSefareshat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label2;
        private Button button2;
        private Label label1;
    }
}