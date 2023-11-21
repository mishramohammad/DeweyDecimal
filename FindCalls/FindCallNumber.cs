using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweySystem.FindCalls
{
    public partial class FindCallNumber : Form
    {
        private Random random = new Random();
        private CallNumbers correctAnswer;
        private int score = 0;

        private CreateTree createTree;
        private CallNumbers root;
        private List<CallNumbers> currentOptions;


        //call numbers used
        private static List<string> callNos = new List<string>
        { "000","100", "200", "300", "400", "500", "600", "700", "800", "900" };

        public FindCallNumber()
        {
            InitializeComponent();
            InitializeComponent();

            createTree = new CreateTree();
            root = createTree.Create();
        }


        private void lblHeading2_Click(object sender, EventArgs e)
        {
            //
        }

        private void lbelScore_Click(object sender, EventArgs e)
        {
            //
        }

        private void ScoreNo_Click(object sender, EventArgs e)
        {
            //
        }

        private void FindCallNumber_Load(object sender, EventArgs e)
        {
            var dataLoad = new DataLoad();
            root = dataLoad.LoadDataFromFile("C:\\Users\\mishr\\source\\repos\\DeweySystem\\data\\datafile.json");
            GenerateNewQuestion();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (listBoxAnswer.SelectedItem != null && listBoxAnswer.SelectedItem.ToString() == correctAnswer.Code + " " + correctAnswer.Description)
            {
                score += 5;
                ScoreNo.Text = score.ToString();
                MessageBox.Show("Correct! Moving to the next level.");
                GenerateNewQuestion();
            }
            else
            {
                MessageBox.Show("Wrong answer! Try Again");
            }
        }

        private void GenerateNewQuestion()
        {
            //random third-level entry
            var thirdLevelNodes = root.Children.SelectMany(c => c.Children).SelectMany(c => c.Children).ToList();
            correctAnswer = thirdLevelNodes[random.Next(thirdLevelNodes.Count)];

            descLabel.Text = correctAnswer.Description;

            currentOptions = new List<CallNumbers> { correctAnswer.Parent };
            while (currentOptions.Count < 4)
            {
                var randomOption = root.Children[random.Next(root.Children.Count)].Children[random.Next(root.Children[random.Next(root.Children.Count)].Children.Count)];
                if (!currentOptions.Contains(randomOption))
                {
                    currentOptions.Add(randomOption);
                }
            }

            currentOptions = currentOptions.OrderBy(_ => random.Next()).ToList();

            listBoxAnswer.Items.Clear();
            foreach (var option in currentOptions)
            {
                listBoxAnswer.Items.Add(option.Code + " " + option.Description);
            }
        }


        private void listBoxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks if choice is correct 
            string selectedItem = listBoxAnswer.SelectedItem.ToString();
            if (selectedItem == correctAnswer.CallNum + " " + correctAnswer.Description)
            {
                score += 5; //update the score by 5 points
                ScoreNo.Text = score.ToString();
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong answer! Try Again");
            }
        }

        private void choiceLabel_Click(object sender, EventArgs e)
        {
            //
        }

        private void descLabel_Click(object sender, EventArgs e)
        {
            //
        }
    }
}

//reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1501