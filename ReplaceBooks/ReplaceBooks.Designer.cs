namespace DeweySystem.ReplaceBooks
{
    partial class ReplaceBooks
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private ListBox listBoxOriginal;
        private ListBox listBoxUser;
        private Button buttonSort;
        private Label labelCorrectAnswer;
        private Label labelPoints;
        private ListBox listBoxCorrect;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            listBoxOriginal = new ListBox();
            listBoxUser = new ListBox();
            buttonSort = new Button();
            labelCorrectAnswer = new Label();
            labelPoints = new Label();
            listBoxCorrect = new ListBox();
            listBoxCheck = new ListBox();
            lblPoints = new Label();
            lblScore = new Label();
            nxtBtn = new Button();
            backBtton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(233, 30);
            label1.Name = "label1";
            label1.Size = new Size(287, 43);
            label1.TabIndex = 0;
            label1.Text = "Replace Books";
            // 
            // listBoxOriginal
            // 
            listBoxOriginal.ItemHeight = 20;
            listBoxOriginal.Location = new Point(28, 146);
            listBoxOriginal.Name = "listBoxOriginal";
            listBoxOriginal.Size = new Size(200, 184);
            listBoxOriginal.TabIndex = 1;
            listBoxOriginal.SelectedIndexChanged += listBoxOriginal_SelectedIndexChanged;
            // 
            // listBoxUser
            // 
            listBoxUser.ItemHeight = 20;
            listBoxUser.Location = new Point(268, 146);
            listBoxUser.Name = "listBoxUser";
            listBoxUser.Size = new Size(200, 184);
            listBoxUser.TabIndex = 2;
            // 
            // buttonSort
            // 
            buttonSort.BackColor = Color.Gold;
            buttonSort.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSort.Location = new Point(196, 371);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(116, 42);
            buttonSort.TabIndex = 3;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // labelCorrectAnswer
            // 
            labelCorrectAnswer.AutoSize = true;
            labelCorrectAnswer.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectAnswer.ForeColor = Color.DarkGreen;
            labelCorrectAnswer.Location = new Point(538, 101);
            labelCorrectAnswer.Name = "labelCorrectAnswer";
            labelCorrectAnswer.Size = new Size(250, 31);
            labelCorrectAnswer.TabIndex = 4;
            labelCorrectAnswer.Text = "Correct answer: ";
            labelCorrectAnswer.Click += labelCorrectAnswer_Click;
            // 
            // labelPoints
            // 
            labelPoints.Location = new Point(0, 0);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(100, 23);
            labelPoints.TabIndex = 0;
            // 
            // listBoxCorrect
            // 
            listBoxCorrect.Location = new Point(0, 0);
            listBoxCorrect.Name = "listBoxCorrect";
            listBoxCorrect.Size = new Size(120, 96);
            listBoxCorrect.TabIndex = 0;
            // 
            // listBoxCheck
            // 
            listBoxCheck.ItemHeight = 20;
            listBoxCheck.Location = new Point(553, 146);
            listBoxCheck.Name = "listBoxCheck";
            listBoxCheck.Size = new Size(200, 184);
            listBoxCheck.TabIndex = 5;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoints.ForeColor = Color.DarkGreen;
            lblPoints.Location = new Point(570, 349);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(103, 31);
            lblPoints.TabIndex = 6;
            lblPoints.Text = "Score:";
            lblPoints.Click += lblPoints_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.DarkGreen;
            lblScore.Location = new Point(689, 349);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(34, 31);
            lblScore.TabIndex = 7;
            lblScore.Text = "0";
            // 
            // nxtBtn
            // 
            nxtBtn.BackColor = Color.PaleGreen;
            nxtBtn.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nxtBtn.Location = new Point(710, 400);
            nxtBtn.Name = "nxtBtn";
            nxtBtn.Size = new Size(78, 38);
            nxtBtn.TabIndex = 8;
            nxtBtn.Text = "Next";
            nxtBtn.UseVisualStyleBackColor = false;
            nxtBtn.Click += nxtBtn_Click;
            // 
            // backBtton
            // 
            backBtton.BackColor = Color.PaleGreen;
            backBtton.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backBtton.Location = new Point(12, 12);
            backBtton.Name = "backBtton";
            backBtton.Size = new Size(78, 38);
            backBtton.TabIndex = 9;
            backBtton.Text = "Back";
            backBtton.UseVisualStyleBackColor = false;
            backBtton.Click += backBtton_Click;
            // 
            // ReplaceBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtton);
            Controls.Add(nxtBtn);
            Controls.Add(lblScore);
            Controls.Add(lblPoints);
            Controls.Add(listBoxCheck);
            Controls.Add(labelCorrectAnswer);
            Controls.Add(label1);
            Controls.Add(listBoxOriginal);
            Controls.Add(listBoxUser);
            Controls.Add(buttonSort);
            Name = "ReplaceBooks";
            Text = "Replacing Books";
            Load += ReplaceBooks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxCheck;
        private Label lblPoints;
        private Label lblScore;
        private Button nxtBtn;
        private Button backBtton;
    }
}
