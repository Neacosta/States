using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
/* Project 4
  Due Date 2/5/2018
  Programmer: Nelson Acosta
  Class: CIS 122
  known bugs none
*/


namespace State
{
    public partial class statesForm : Form
    {
        public statesForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oregonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            statePictureBox.Image = Image.FromFile("oregon.bmp");
            stateInformationGroupBox.BackColor = Color.Green;
            label3.Text = "State of Oregon";
            label5.Text = "State of Oregon has about" + Environment.NewLine + "2 million population";
            label7.Text = "State of washington has" + Environment.NewLine + "mild climate";
            label9.Text = "Beaver State";

            if (oregonRadioButton.Checked)
            {
                stateInformationGroupBox.Visible = true;

            }
            else
            {
                stateInformationGroupBox.Visible = false;
            }
        }

        private void washingtonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            statePictureBox.Image = Image.FromFile("washington.bmp");
            stateInformationGroupBox.BackColor = Color.Blue;
            label3.Text = "State of Washington";
            label5.Text = "State of Washington has about" + Environment.NewLine + "2 million population";
            label7.Text = "State of washington has" + Environment.NewLine + "medium mild climate";
            label9.Text = "Salmon";

            if (washingtonRadioButton.Checked)
            {
                stateInformationGroupBox.Visible = true;

            }
            else
            {
                stateInformationGroupBox.Visible = false;
            }
        }

        private void californiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            statePictureBox.Image = Image.FromFile("california.bmp");
            stateInformationGroupBox.BackColor = Color.Orange;
            label3.Text = "State of California";
            label5.Text = "State of California has about" + Environment.NewLine + "34 million population";
            label7.Text = "State of California has" + Environment.NewLine + "worm climate";
            label9.Text = "Golden State";

            if (californiaRadioButton.Checked)
            {
                stateInformationGroupBox.Visible = true;

            }
            else
            {
                stateInformationGroupBox.Visible = false;
            }
        }

        private void phoneNumberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneNumberCheckBox.Checked)
            {
                phoneNumberMaskedTextBox.Visible = true;
            }
            else
            {
                phoneNumberMaskedTextBox.Visible = false;
            }

        }

        private void screenColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (screenColorCheckBox.Checked)
            {
                colorGroupBox.Visible = true;
            }
            else
            {
                colorGroupBox.Visible = false;
            }

        }

        private void oregonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oregonRadioButton.PerformClick();

        }

        private void washigntonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            washingtonRadioButton.PerformClick();

        }

        private void californiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            californiaRadioButton.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = default(Color);
            insertColorTextBox.Clear();
            phoneNumberMaskedTextBox.Clear();
            statePictureBox.Image = null;

            label3.Text = null;
            label5.Text = null;
            label7.Text = null;
            label9.Text = null;

            stateInformationGroupBox.Visible = false;

        }

        private void backGroundColorButton_Click(object sender, EventArgs e)
        {
            switch (insertColorTextBox.Text.ToLower())
            {
                case "green":
                    this.BackColor = Color.Green;
                    break;
                case "blue":
                    this.BackColor = Color.Blue;
                    break;
                case "red":
                    this.BackColor = Color.Red;
                    break;
                case "reset":
                    clearButton.PerformClick();
                    break;
                default:
                    MessageBox.Show("Wrong Input");
                    break;
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton.PerformClick();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            string inputResponse = null;

            inputResponse =

            Interaction.InputBox
            ("Do you plan to go to one of these states?" + Environment.NewLine + "Answer Yes or No", "Your input needed"); 

            string myAnswer = inputResponse.ToLower();
            if (myAnswer == "yes")
            {
                MessageBox.Show("Maybe I'll see you there!", "That's great");

            }
            else
            {
                MessageBox.Show("I problably won't see you there", "Too bad");
            }
        }
    }

}
