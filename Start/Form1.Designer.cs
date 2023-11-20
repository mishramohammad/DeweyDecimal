namespace DeweySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            findcallbtn = new Button();
            identifyareasbtn = new Button();
            replacebooksbtn = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(findcallbtn);
            panel1.Controls.Add(identifyareasbtn);
            panel1.Controls.Add(replacebooksbtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 451);
            panel1.TabIndex = 0;
            // 
            // findcallbtn
            // 
            findcallbtn.BackColor = Color.SteelBlue;
            findcallbtn.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            findcallbtn.ForeColor = SystemColors.ActiveCaptionText;
            findcallbtn.Location = new Point(12, 296);
            findcallbtn.Name = "findcallbtn";
            findcallbtn.Size = new Size(155, 50);
            findcallbtn.TabIndex = 2;
            findcallbtn.Text = "Find Call #s";
            findcallbtn.UseVisualStyleBackColor = false;
            findcallbtn.Click += findcallbtn_Click;
            // 
            // identifyareasbtn
            // 
            identifyareasbtn.BackColor = Color.DeepPink;
            identifyareasbtn.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            identifyareasbtn.ForeColor = SystemColors.ActiveCaptionText;
            identifyareasbtn.Location = new Point(12, 200);
            identifyareasbtn.Name = "identifyareasbtn";
            identifyareasbtn.Size = new Size(155, 50);
            identifyareasbtn.TabIndex = 1;
            identifyareasbtn.Text = "Identify Areas";
            identifyareasbtn.UseVisualStyleBackColor = false;
            identifyareasbtn.Click += identifyareasbtn_Click;
            // 
            // replacebooksbtn
            // 
            replacebooksbtn.BackColor = Color.DarkSeaGreen;
            replacebooksbtn.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            replacebooksbtn.ForeColor = SystemColors.ActiveCaptionText;
            replacebooksbtn.Location = new Point(12, 106);
            replacebooksbtn.Name = "replacebooksbtn";
            replacebooksbtn.Size = new Size(155, 50);
            replacebooksbtn.TabIndex = 0;
            replacebooksbtn.Text = "Replace Books";
            replacebooksbtn.UseVisualStyleBackColor = false;
            replacebooksbtn.Click += replacebooksbtn_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(178, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 451);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Home";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button replacebooksbtn;
        private Button findcallbtn;
        private Button identifyareasbtn;
        private Panel panel2;
    }
}