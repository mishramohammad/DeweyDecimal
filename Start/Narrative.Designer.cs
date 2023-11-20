namespace DeweySystem.Start
{
    partial class Narrative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Narrative));
            startbtn = new Button();
            welcometxt = new Label();
            conText = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // startbtn
            // 
            startbtn.BackColor = Color.MediumPurple;
            startbtn.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            startbtn.ForeColor = Color.Indigo;
            startbtn.Location = new Point(383, 317);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(197, 50);
            startbtn.TabIndex = 0;
            startbtn.Text = "Let's Get Started";
            startbtn.UseVisualStyleBackColor = false;
            startbtn.Click += startbtn_Click;
            // 
            // welcometxt
            // 
            welcometxt.AutoSize = true;
            welcometxt.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            welcometxt.ForeColor = SystemColors.ActiveCaptionText;
            welcometxt.Location = new Point(201, 61);
            welcometxt.Name = "welcometxt";
            welcometxt.Size = new Size(587, 46);
            welcometxt.TabIndex = 1;
            welcometxt.Text = "Welcome to Dewey's Library Training ";
            // 
            // conText
            // 
            conText.AutoSize = true;
            conText.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            conText.ForeColor = Color.MidnightBlue;
            conText.Location = new Point(287, 184);
            conText.Name = "conText";
            conText.Size = new Size(378, 44);
            conText.TabIndex = 2;
            conText.Text = "In this enchanting library, you'll embark on a \r\njourney to bring order to our collection!";
            conText.TextAlign = ContentAlignment.TopCenter;
            conText.Click += conText_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 454);
            panel1.TabIndex = 3;
            // 
            // Narrative
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(conText);
            Controls.Add(welcometxt);
            Controls.Add(startbtn);
            Name = "Narrative";
            Text = "Narrative";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startbtn;
        private Label welcometxt;
        private Label conText;
        private Panel panel1;
    }
}