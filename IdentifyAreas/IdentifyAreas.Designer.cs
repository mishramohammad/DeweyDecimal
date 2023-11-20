namespace DeweySystem.IdentifyAreas
{
    partial class IdentifyAreas
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
            lblHeading = new Label();
            listBoxNo = new ListBox();
            listBoxDesc = new ListBox();
            nxtBtn2 = new Button();
            lbelMatch = new Label();
            submitBtn = new Button();
            newBtn = new Button();
            labelScore = new Label();
            lblScores = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.ForeColor = Color.LavenderBlush;
            lblHeading.Location = new Point(272, 34);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(273, 42);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Identify Areas";
            lblHeading.Click += lblHeading_Click;
            // 
            // listBoxNo
            // 
            listBoxNo.FormattingEnabled = true;
            listBoxNo.ItemHeight = 20;
            listBoxNo.Location = new Point(41, 133);
            listBoxNo.Name = "listBoxNo";
            listBoxNo.Size = new Size(224, 224);
            listBoxNo.TabIndex = 1;
            listBoxNo.SelectedIndexChanged += listBoxNo_SelectedIndexChanged;
            // 
            // listBoxDesc
            // 
            listBoxDesc.FormattingEnabled = true;
            listBoxDesc.ItemHeight = 20;
            listBoxDesc.Location = new Point(321, 133);
            listBoxDesc.Name = "listBoxDesc";
            listBoxDesc.Size = new Size(224, 224);
            listBoxDesc.TabIndex = 2;
            listBoxDesc.SelectedIndexChanged += listBoxDesc_SelectedIndexChanged;
            // 
            // nxtBtn2
            // 
            nxtBtn2.BackColor = Color.Pink;
            nxtBtn2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nxtBtn2.Location = new Point(710, 400);
            nxtBtn2.Name = "nxtBtn2";
            nxtBtn2.Size = new Size(78, 38);
            nxtBtn2.TabIndex = 9;
            nxtBtn2.Text = "Next";
            nxtBtn2.UseVisualStyleBackColor = false;
            nxtBtn2.Click += nxtBtn2_Click;
            // 
            // lbelMatch
            // 
            lbelMatch.AutoSize = true;
            lbelMatch.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbelMatch.ForeColor = Color.LavenderBlush;
            lbelMatch.Location = new Point(187, 85);
            lbelMatch.Name = "lbelMatch";
            lbelMatch.Size = new Size(442, 21);
            lbelMatch.TabIndex = 10;
            lbelMatch.Text = "Play Matchmaker! Connect the number to the description";
            lbelMatch.Click += lbelMatch_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Gold;
            submitBtn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.Location = new Point(387, 377);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(93, 40);
            submitBtn.TabIndex = 11;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // newBtn
            // 
            newBtn.BackColor = Color.PowderBlue;
            newBtn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newBtn.Location = new Point(106, 377);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(93, 40);
            newBtn.TabIndex = 12;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = false;
            newBtn.Click += newBtn_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.ForeColor = Color.LavenderBlush;
            labelScore.Location = new Point(585, 221);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(111, 31);
            labelScore.TabIndex = 13;
            labelScore.Text = "Score: ";
            labelScore.Click += labelScore_Click;
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblScores.ForeColor = Color.LavenderBlush;
            lblScores.Location = new Point(692, 221);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(34, 31);
            lblScores.TabIndex = 14;
            lblScores.Text = "0";
            // 
            // IdentifyAreas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblScores);
            Controls.Add(labelScore);
            Controls.Add(newBtn);
            Controls.Add(submitBtn);
            Controls.Add(lbelMatch);
            Controls.Add(nxtBtn2);
            Controls.Add(listBoxDesc);
            Controls.Add(listBoxNo);
            Controls.Add(lblHeading);
            Name = "IdentifyAreas";
            Text = "Identify Areas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private ListBox listBoxNo;
        private ListBox listBoxDesc;
        private Button nxtBtn2;
        private Label lbelMatch;
        private Button submitBtn;
        private Button newBtn;
        private Label labelScore;
        private Label lblScores;
    }
}