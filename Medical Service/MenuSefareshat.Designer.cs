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
            button5.Location = new Point(268, 131);
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
            label2.Location = new Point(251, 208);
            label2.Name = "label2";
            label2.Size = new Size(99, 29);
            label2.TabIndex = 31;
            label2.Text = "ثبت سفارش";
            // 
            // MenuSefareshat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 404);
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
    }
}