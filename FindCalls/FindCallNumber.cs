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

        private CreateTree createTree;
        private CallNumbers root;
        private List<CallNumbers> currentOptions;


        //call numbers used
        private static List<string> callNos = new List<string>
        { "000","100", "200", "300", "400", "500", "600", "700", "800", "900" };

        public FindCallNumber()
        {
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
            if (choiceBox.SelectedItem != null && choiceBox.SelectedItem.ToString() == correctAnswer.Id + " " + correctAnswer.Label)
            {
                score += 5;
                ScoreNo.Text = score.ToString();
                MessageBox.Show("Correct! Moving to the next level.");

                //correct sound when the answer is correct
                PlaySound(@"C:\Users\mishr\Dropbox\My PC (LAPTOP-B41IIIGC)\Downloads\correct-6033.mp3");
            }
            else
            {
                MessageBox.Show("Wrong answer! Try Again");

                //incorrect answer sound
                PlaySound(@"C:\Users\mishr\Dropbox\My PC (LAPTOP-B41IIIGC)\Downloads\negative_beeps-6008.mp3");
            }
        }

        private void PlaySound(string filePath)
        {
            try
            {
                using (var reader = new Mp3FileReader(filePath))
                using (var waveOut = new WaveOutEvent())
                {
                    waveOut.Init(reader);
                    waveOut.Play();
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}");
            }
        }


        private void GenerateNewQuestion()
        {
            // random third-level entry
            var thirdLevelNodes = root?.Children?.SelectMany(c => c.Children)?.SelectMany(c => c.Children)?.ToList();

            if (thirdLevelNodes != null && thirdLevelNodes.Any())
            {
                correctAnswer = thirdLevelNodes[random.Next(thirdLevelNodes.Count)];

                descLabel.Text = correctAnswer?.Label;

                currentOptions = new List<CallNumbers> { correctAnswer?.Parent };
                while (currentOptions.Count < 4)
                {
                    var randomOption = root?.Children?[random.Next(root.Children.Count)]?.Children?[random.Next(root.Children?[random.Next(root.Children.Count)]?.Children?.Count ?? 0)] ?? null;
                    if (randomOption != null && !currentOptions.Contains(randomOption))
                    {
                        currentOptions.Add(randomOption);
                    }
                }

                //takes first one as correct
                currentOptions = currentOptions?.OrderBy(_ => random.Next()).ToList();

                choiceBox.Items.Clear();
                foreach (var option in currentOptions)
                {
                    choiceBox.Items.Add(option?.Id + " " + option?.Label);
                }
            }
            else
            {
                MessageBox.Show("Error");
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

        }

 

    }
}

//reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1501
//reference: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-play-a-sound-from-a-windows-form?view=netframeworkdesktop-4.8