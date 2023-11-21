using DeweySystem;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;

namespace DeweySystem.ReplaceBooks
{
    public partial class ReplaceBooks : Form
    {
        private static Random generateRandom = new Random();
        ListClass listClass = new ListClass();
        DeweySystem.ReplaceBooks.Sort sort = new DeweySystem.ReplaceBooks.Sort();
        private static int points = 0;

        public ReplaceBooks()
        {
            InitializeComponent();
        }

        private void ReplaceBooks_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                string randomNumber = generateRandom.GenerateRandomNo(3);
                listBoxOriginal.Items.Add(randomNumber);
                listClass.GetNoList().Add(randomNumber);
            }

            listClass.GetSortList().AddRange(sort.performBubbleSort(listClass.GetNoList()));

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            //error handling
            if (listBoxUser.Items.Count == 0)
            {
                MessageBox.Show("Please Rearrange the Numbers");
                return;
            }

            listClass.GetUserList().Clear();
            foreach (var item in listBoxUser.Items)
            {
                listClass.GetUserList().Add(item.ToString());
            }

            bool equal = Enumerable.SequenceEqual(listClass.GetUserList(), listClass.GetSortList());

            if (equal)
            {
                //if user gets it right, they receive 5 points
                points += 5;
                lblScore.Text = Convert.ToString(points);

                listBoxUser.Items.Clear();
                listBoxCheck.Items.Clear();
                listClass.GetUserList().Clear();
                listClass.GetSortList().Clear();
                listClass.GetNoList().Clear();

                // correct sound when the answer is correct
                PlaySound(@"C:\Users\mishr\Dropbox\My PC (LAPTOP-B41IIIGC)\Downloads\correct-6033.mp3");

                //new 10 numbers
                for (int i = 0; i < 10; i++)
                {
                    string randomNumber = generateRandom.GenerateRandomNo(3);
                    listBoxOriginal.Items.Add(randomNumber);
                    listClass.GetNoList().Add(randomNumber);
                }

                //sort the original list
                listClass.GetSortList().AddRange(sort.performBubbleSort(listClass.GetNoList()));

                MessageBox.Show("Congratulations!\nYour order is correct\nHere are 5 points");
            }
            else
            {
                //user gets it wrong, they try again
                MessageBox.Show("Try Again!\nYour Call Numbers Are Not Ordered!");
                // incorrect answer sound
                PlaySound(@"C:\Users\mishr\Dropbox\My PC (LAPTOP-B41IIIGC)\Downloads\negative_beeps-6008.mp3");

                //displays the correct answer in listBoxCheck
                listBoxCheck.Items.Clear();
                listBoxCheck.Items.AddRange(listClass.GetSortList().ToArray());
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

        private void MoveSelectedItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void listBoxOriginal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoveSelectedItems(listBoxOriginal, listBoxUser);
        }

        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void labelCorrectAnswer_Click(object sender, EventArgs e)
        {
            //
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {
            //
        }

        //goes to identify areas
        private void nxtBtn_Click(object sender, EventArgs e)
        {
            DeweySystem.IdentifyAreas.IdentifyAreas identifyAreasForm = new DeweySystem.IdentifyAreas.IdentifyAreas();
            identifyAreasForm.Show();
            this.Hide();
        }

        private void backBtton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}


