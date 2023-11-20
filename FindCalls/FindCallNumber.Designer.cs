namespace DeweySystem.FindCalls
{
    partial class FindCallNumber
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
            lblHeading2 = new Label();
            lbelScore = new Label();
            ScoreNo = new Label();
            subBtn = new Button();
            mainBtn = new Button();
            SuspendLayout();
            // 
            // lblHeading2
            // 
            lblHeading2.AutoSize = true;
            lblHeading2.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading2.ForeColor = Color.Lavender;
            lblHeading2.Location = new Point(242, 35);
            lblHeading2.Name = "lblHeading2";
            lblHeading2.Size = new Size(319, 42);
            lblHeading2.TabIndex = 1;
            lblHeading2.Text = "Find Call Number";
            lblHeading2.Click += lblHeading2_Click;
            // 
            // lbelScore
            // 
            lbelScore.AutoSize = true;
            lbelScore.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbelScore.ForeColor = Color.MidnightBlue;
            lbelScore.Location = new Point(582, 130);
            lbelScore.Name = "lbelScore";
            lbelScore.Size = new Size(111, 31);
            lbelScore.TabIndex = 14;
            lbelScore.Text = "Score: ";
            lbelScore.Click += lbelScore_Click;
            // 
            // ScoreNo
            // 
            ScoreNo.AutoSize = true;
            ScoreNo.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreNo.ForeColor = Color.MidnightBlue;
            ScoreNo.Location = new Point(680, 130);
            ScoreNo.Name = "ScoreNo";
            ScoreNo.Size = new Size(34, 31);
            ScoreNo.TabIndex = 15;
            ScoreNo.Text = "0";
            ScoreNo.Click += ScoreNo_Click;
            // 
            // subBtn
            // 
            subBtn.BackColor = Color.Gold;
            subBtn.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            subBtn.ForeColor = SystemColors.ActiveCaptionText;
            subBtn.Location = new Point(117, 349);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(125, 41);
            subBtn.TabIndex = 16;
            subBtn.Text = "Submit";
            subBtn.UseVisualStyleBackColor = false;
            // 
            // mainBtn
            // 
            mainBtn.BackColor = Color.AliceBlue;
            mainBtn.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mainBtn.ForeColor = SystemColors.ActiveCaptionText;
            mainBtn.Location = new Point(711, 401);
            mainBtn.Name = "mainBtn";
            mainBtn.Size = new Size(77, 37);
            mainBtn.TabIndex = 17;
            mainBtn.Text = "Main";
            mainBtn.UseVisualStyleBackColor = false;
            mainBtn.Click += mainBtn_Click;
            // 
            // FindCallNumber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(mainBtn);
            Controls.Add(subBtn);
            Controls.Add(ScoreNo);
            Controls.Add(lbelScore);
            Controls.Add(lblHeading2);
            Name = "FindCallNumber";
            Text = "Find Call Number";
            Load += FindCallNumber_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading2;
        private Label lbelScore;
        private Label ScoreNo;
        private Button subBtn;
        private Button mainBtn;
    }
}