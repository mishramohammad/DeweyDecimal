using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NAudio.Wave;

namespace DeweySystem.FindCalls
{
    public partial class FindCallNumber : Form
    {
        private Random random = new Random();
        private CallNumbers correctAnswer;
        private int score = 0;

        private CallNumbers root;
        private List<CallNumbers> currentOptions;


        //call numbers used
        private static List<string> callNos = new List<string>
        { "000","100", "200", "300", "400", "500", "600", "700", "800", "900" };


        public FindCallNumber()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var dataLoad = new DataLoad();
            root = dataLoad.LoadDataFromFile("C:\\Users\\mishr\\source\\repos\\DeweySystem\\data\\datafile.json");
            GenerateNewQuestion();
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
            LoadData();
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

        private int level = 0;  // The current level of the quiz
        private List<CallNumbers> currentLevelOptions;  // The options at the current level

        //reference: https://stackoverflow.com/questions/12957125/quiz-game-application

        private void GenerateNewQuestion()
        {
            if (root?.Children == null)
            {
                MessageBox.Show("Error: Data not loaded correctly.");
                return;
            }

            //random call number to be the correct answer
            correctAnswer = root.Children[random.Next(root.Children.Count)];

            //description label
            descLabel.Text = correctAnswer.Label;

            //three random call numbers to be the incorrect answers
            var incorrectAnswers = new List<CallNumbers>();
            while (incorrectAnswers.Count < 3)
            {
                var incorrectAnswer = root.Children[random.Next(root.Children.Count)];
                if (incorrectAnswer != correctAnswer && !incorrectAnswers.Contains(incorrectAnswer))
                {
                    incorrectAnswers.Add(incorrectAnswer);
                }
            }

            //correct answer and the incorrect answers
            currentLevelOptions = new List<CallNumbers> { correctAnswer }.Concat(incorrectAnswers).ToList();

            //current level options
            choiceBox.Items.Clear();
            foreach (var option in currentLevelOptions)
            {
                choiceBox.Items.Add(option.Id + " " + option.Label);
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (choiceBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            var selectedOptionString = (string)choiceBox.SelectedItem;
            var selectedOptionParts = selectedOptionString.Split(' ');
            var selectedOptionId = selectedOptionParts[0];
            var selectedOptionLabel = string.Join(' ', selectedOptionParts.Skip(1));
            var selectedOption = currentOptions?.FirstOrDefault(op => op.Id == selectedOptionId && op.Label == selectedOptionLabel);

            if (selectedOption != null && selectedOption.Id == correctAnswer.Id && selectedOption.Label == correctAnswer.Label)
            {
                score += 5;
                ScoreNo.Text = score.ToString();
                MessageBox.Show("Correct! Moving to the next level.");

                // correct sound when the answer is correct
                PlaySound(@"C:\Users\mishr\Dropbox\My PC (LAPTOP-B41IIIGC)\Downloads\correct-6033.mp3");

                GenerateNewQuestion();
            }
            else
            {
                MessageBox.Show("Wrong answer! Try Again");

                // incorrect answer sound
                PlaySound(@"C:\Users\mishr\Dropbox\My PC (LAPTOP-B41IIIGC)\Downloads\negative_beeps-6008.mp3");
            }
        }



        private void PlaySound(string filePath)
        {
            try
            {
                using (var reader = new AudioFileReader(filePath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(reader);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}");
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

        private void choiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void labeldesc_Click(object sender, EventArgs e)
        {
            //
        }
    }
}

//reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1501
//reference: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-play-a-sound-from-a-windows-form?view=netframeworkdesktop-4.8