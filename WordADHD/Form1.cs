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
        // getter and setter
        public string secretWord { get; set; }

        public Form1()
        {
            InitializeComponent();
            setUpGame();
        }

        // initialize game by getting a secret word and clearing the form
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
            // check if user completed their 10 guesses
            if (lstGuesses.Items.Count < 10)
            {
                // get user input, then call checkWord, and add it to list of guesses
                string guess = txtGuess.Text;
                checkWord(guess);
                lstGuesses.Items.Add(guess);
            }
            // else print message
            else
            {
                MessageBox.Show("Oops you have no more chances... The secret word was " + secretWord);
            }

        } // end btnCheck

        // get secret word from list
        public string getWord()
        {
            var random = new Random();
            var list = new List<string> { "plane", "crane", "frame", "point", "claim", "brain", "shake", "caulk" };
            int secretIndex = random.Next(list.Count);
            string secretWord = list[secretIndex];
            return secretWord;
        }

        // check if user guess is the secret word
        public void checkWord(string guess)
        {
            TextBox[] txtBoxes = { txtWord0, txtWord1, txtWord2, txtWord3, txtWord4 };

            // if word is accurate lenght (5), check letters
            if (guess.Length == 5)
            {
                for (int i = 0; i < guess.Length; i++)
                {
                    // if letter well placed, display it
                    if (guess[i] == secretWord[i])
                    {
                        txtBoxes[i].Text = guess[i].ToString();
                    }
                    // if letter is in secret word, warn the user
                    else if (guess.Contains(secretWord[i]))
                    {
                        MessageBox.Show(guess[i] + " is in the wrong position");
                    }
                    // else warn the user that the letter is not in the secret word
                    else
                    {
                        MessageBox.Show(guess[i] + " is not in the secret word");
                    }

                }
            }
            // if word is not 5 letter long, display message
            else
            {
                MessageBox.Show("Word must be 5 lettes long.");
            }
            
        }

        // reset game
        private void btnReset_Click(object sender, EventArgs e)
        {
            setUpGame();
        }

        // exit game
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // end class
} // end namespace
