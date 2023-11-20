using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweySystem.IdentifyAreas
{
    public partial class IdentifyAreas : Form
    {
        AreaDictionary areaDictionary = new AreaDictionary();
        bool isCallNumberToDescription = true;
        int score = 0;
        public IdentifyAreas()
        {
            InitializeComponent();
            areaDictionary.AddAreas();
            GenerateQuestion();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {
            //
        }

        private void listBoxNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void listBoxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void lbelMatch_Click(object sender, EventArgs e)
        {
            //
        }

        private void GenerateQuestion()
        {
            listBoxNo.Items.Clear();
            listBoxDesc.Items.Clear();

            var question = areaDictionary.GenerateQuestion();
            if (isCallNumberToDescription)
            {
                foreach (var item in question.Item1)
                {
                    listBoxNo.Items.Add(item);
                }

                foreach (var item in question.Item2)
                {
                    listBoxDesc.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in question.Item2)
                {
                    listBoxNo.Items.Add(item);
                }

                foreach (var item in question.Item1)
                {
                    listBoxDesc.Items.Add(item);
                }
            }

            isCallNumberToDescription = !isCallNumberToDescription;
        }
        private void CheckAnswer()
        {
            string key = listBoxNo.SelectedItem.ToString();
            string value = listBoxDesc.SelectedItem.ToString();

            if (areaDictionary.GetAreaDict().TryGetValue(key, out var correctValue))
            {
                if (correctValue == value)
                {
                    score++;
                }
            }

            GenerateQuestion();
        }


        private void nxtBtn2_Click(object sender, EventArgs e)
        {
            //
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (listBoxNo.SelectedItem != null && listBoxDesc.SelectedItem != null)
            {
                string key = listBoxNo.SelectedItem.ToString();
                string value = listBoxDesc.SelectedItem.ToString();

                if (areaDictionary.GetAreaDict().TryGetValue(key, out var correctValue))
                {
                    if (correctValue == value)
                    {
                        //answer is correct
                        score++;
                        MessageBox.Show("Correct answer! Your score is now " + score, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //answer is incorrect
                        MessageBox.Show("Incorrect answer. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //selected does not exist
                    MessageBox.Show("Incorrect answer. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //no item is selected
                MessageBox.Show("Please select an item in both columns.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void newBtn_Click(object sender, EventArgs e)
        {
            GenerateQuestion();
        }

        private void labelScore_Click(object sender, EventArgs e)
        {
            //
        }
    }
}


