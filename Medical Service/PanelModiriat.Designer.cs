namespace Medical_Service
{
    partial class PanelModiriat
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
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button8
            // 
            button8.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(44, 415);
            button8.Name = "button8";
            button8.Size = new Size(181, 80);
            button8.TabIndex = 9;
            button8.Text = "شرکت";
            button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(44, 292);
            button1.Name = "button1";
            button1.Size = new Size(181, 80);
            button1.TabIndex = 10;
            button1.Text = "مدیر";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(44, 165);
            button2.Name = "button2";
            button2.Size = new Size(181, 80);
            button2.TabIndex = 11;
            button2.Text = "ادمین";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(44, 42);
            button3.Name = "button3";
            button3.Size = new Size(181, 80);
            button3.TabIndex = 12;
            button3.Text = "کارمندان";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(44, 539);
            button4.Name = "button4";
            button4.Size = new Size(181, 80);
            button4.TabIndex = 13;
            button4.Text = "انبار";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Mj_Heritage Two Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(532, 307);
            button5.Name = "button5";
            button5.Size = new Size(181, 80);
            button5.TabIndex = 14;
            button5.Text = "بازگشت";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // PanelModiriat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 694);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button8);
            Name = "PanelModiriat";
            Text = "PanelModiriat";
            Load += PanelModiriat_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}