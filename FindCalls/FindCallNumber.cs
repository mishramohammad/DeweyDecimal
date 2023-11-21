﻿using System;
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

        private void GenerateNewQuestion()
        {
            if (root?.Children == null)
            {
                MessageBox.Show("Error: Data not loaded correctly.");
                return;
            }

            //randomly select a third-level entry.
            var thirdLevelNodes = root.Children.SelectMany(c => c.Children).SelectMany(c => c.Children).ToList();
            correctAnswer = thirdLevelNodes[random.Next(thirdLevelNodes.Count)];

            //check if correctAnswer or correctAnswer.Parent is null.
            if (correctAnswer?.Parent?.Parent == null)
            {
                MessageBox.Show("Error: Data not loaded correctly.");
                return;
            }

            // Select the correct top-level category and three incorrect ones.
            currentOptions = new List<CallNumbers> { correctAnswer.Parent.Parent };
            while (currentOptions.Count < 4)
            {
                var randomOption = root.Children[random.Next(root.Children.Count)];
                if (!currentOptions.Contains(randomOption))
                {
                    currentOptions.Add(randomOption);
                }
            }

            // Shuffle the options and display them.
            currentOptions = currentOptions.OrderBy(_ => random.Next()).ToList();
            foreach (var option in currentOptions)
            {
                choiceBox.Items.Add(option.Id + " " + option.Label);
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (choiceBox.SelectedItem.ToString() == correctAnswer.Parent.Parent.Id + " " + correctAnswer.Parent.Parent.Label)
            {
                score += 5;
                ScoreNo.Text = score.ToString();
                MessageBox.Show("Correct! Moving to the next level.");

                // correct sound when the answer is correct
                PlaySound(@"C:\Users\mishr\Dropbox\My PC (LAPTOP-B41IIIGC)\Downloads\correct-6033.mp3");

                // Generate next question.
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