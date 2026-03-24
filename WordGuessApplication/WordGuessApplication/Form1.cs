using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string secretWord = "computer";
        private StringBuilder maskedWord;

        public Form1()
        {
            InitializeComponent();
            BuildMaskedWord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim();

            if (userGuess.Length == 0)
            {
                MessageBox.Show("Please enter a word.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userGuess.Equals(secretWord, StringComparison.CurrentCultureIgnoreCase))
            {
                maskedWord.Clear();
                maskedWord.Append(secretWord);
                lblWordToGuess.Text = maskedWord.ToString();
                MessageBox.Show("Correct guess!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuess.Enabled = false;
                txtGuess.Enabled = false;
            }
            else
            {
                if (!lstWrongGuesses.Items.Contains(userGuess))
                    lstWrongGuesses.Items.Add(userGuess);

                MessageBox.Show("Wrong guess!\nTry again.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuess.Clear();
                txtGuess.Focus();
            }
        }

        private void BuildMaskedWord()
        {
            maskedWord = new StringBuilder();
            maskedWord.Append(secretWord[0]);

            for (int i = 1; i < secretWord.Length - 1; i++)
            {
                maskedWord.Append('?');
            }

            maskedWord.Append(secretWord[secretWord.Length - 1]);
            lblWordToGuess.Text = maskedWord.ToString();
        }
    }
}
