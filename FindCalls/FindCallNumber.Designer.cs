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
            newBtn = new Button();
            descLabel = new Label();
            choiceLabel = new Label();
            listBoxAnswer = new ListBox();
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
            subBtn.Location = new Point(86, 370);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(125, 41);
            subBtn.TabIndex = 16;
            subBtn.Text = "Submit";
            subBtn.UseVisualStyleBackColor = false;
            subBtn.Click += subBtn_Click;
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
            // newBtn
            // 
            newBtn.BackColor = Color.DarkOrange;
            newBtn.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            newBtn.ForeColor = SystemColors.ActiveCaptionText;
            newBtn.Location = new Point(302, 370);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(79, 41);
            newBtn.TabIndex = 18;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = false;
            newBtn.Click += newBtn_Click;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            descLabel.ForeColor = SystemColors.ButtonHighlight;
            descLabel.Location = new Point(43, 130);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(200, 21);
            descLabel.TabIndex = 19;
            descLabel.Text = "Call Number Description:";
            descLabel.Click += descLabel_Click;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            choiceLabel.ForeColor = SystemColors.ButtonHighlight;
            choiceLabel.Location = new Point(43, 222);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(64, 21);
            choiceLabel.TabIndex = 20;
            choiceLabel.Text = "Choice:";
            choiceLabel.Click += choiceLabel_Click;
            // 
            // listBoxAnswer
            // 
            listBoxAnswer.FormattingEnabled = true;
            listBoxAnswer.ItemHeight = 20;
            listBoxAnswer.Location = new Point(43, 261);
            listBoxAnswer.Name = "listBoxAnswer";
            listBoxAnswer.Size = new Size(459, 64);
            listBoxAnswer.TabIndex = 21;
            listBoxAnswer.SelectedIndexChanged += listBoxAnswer_SelectedIndexChanged;
            // 
            // FindCallNumber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxAnswer);
            Controls.Add(choiceLabel);
            Controls.Add(descLabel);
            Controls.Add(newBtn);
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
        private Button newBtn;
        private Label descLabel;
        private Label choiceLabel;
        private ListBox listBoxAnswer;
    }
}