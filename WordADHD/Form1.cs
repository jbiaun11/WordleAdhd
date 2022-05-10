using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordADHD
{
    public partial class Form1 : Form
    {
        public string secretWord { get; set; }

        public Form1()
        {
            InitializeComponent();
            setUpGame();
        }

        public string setUpGame()
        {
            secretWord = getWord();
            txtGuess.Text = "";
            txtWord0.Text = "";
            txtWord1.Text = "";
            txtWord2.Text = "";
            txtWord3.Text = "";
            txtWord4.Text = "";
            lstGuesses.Items.Clear();
            return secretWord;
        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            if (lstGuesses.Items.Count < 10)
            {
                string guess = txtGuess.Text;
                checkWord(guess);
                lstGuesses.Items.Add(guess);
            }
            else
            {
                MessageBox.Show("Oops you have no more chances... The secret word was " + secretWord);
            }

        } // end btnCheck

        public string getWord()
        {
            var random = new Random();
            var list = new List<string> { "plane", "crane", "frame", "point", "claim", "brain", "shake", "caulk" };
            int secretIndex = random.Next(list.Count);
            string secretWord = list[secretIndex];
            return secretWord;
        }

        public void checkWord(string guess)
        {
            TextBox[] txtBoxes = { txtWord0, txtWord1, txtWord2, txtWord3, txtWord4 };

            if (guess.Length == 5)
            {
                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == secretWord[i])
                    {
                        txtBoxes[i].Text = guess[i].ToString();
                    }
                    else if (guess.Contains(secretWord[i]))
                    {
                        MessageBox.Show(guess[i] + " is in the wrong position");
                    }
                    else
                    {
                        MessageBox.Show(guess[i] + " is not in the secret word");
                    }

                }
            }
            else
            {
                MessageBox.Show("Word must be 5 lettes long.");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setUpGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // end class
} // end namespace
