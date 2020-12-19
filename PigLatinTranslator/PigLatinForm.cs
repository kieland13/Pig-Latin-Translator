using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinTranslator
{
    public partial class PigLatinForm : Form
    {
        //create a variable for the user to type in
        string userWord;

        //create a list for all the translated words to show
        //what words have been translated so far
        List<string> translatedWords = new List<string>();

        //this will start the form
        public PigLatinForm()
        {
            InitializeComponent();
        }

        //this method changes every word to pig latin
        public string GetPigLatin(string word)
        {
            //create a blank string
            string wordWithoutFirstLetter = "";

            //take the word from the second character to the end of the word
            wordWithoutFirstLetter += word.Substring(1);

            //take the first letter and add it to the end of each word
            string wordWithLetterAtEnd = wordWithoutFirstLetter + word.Substring(0, 1);

            //add "ay" to the end of the word
            return wordWithLetterAtEnd + "ay";
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            //take the user input and add it to the User Input Box
            userWord = UserInputBox.Text;

            //this checks to see if the user has typed in a word with
            //at least one letter per word
            if (userWord.Length <= 0)
            {
                //if nothing is typed in, present this message to user
                //and have them type it in again
                MessageBox.Show("Word must be 1 letter or more", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                userWord = UserInputBox.Text;
            }
            else
            {
                //checks to see if anything besides a letter is typed in
                //and if not present message to user
                if ((userWord.Any(Char.IsDigit)) || (userWord.Any(Char.IsSymbol)) || (userWord.Any(Char.IsPunctuation)))
                {
                    MessageBox.Show("The word can only contain letters. Please choose another word.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    //create an array for all the words
                    //with each word being set to every index of array
                    string[] words = userWord.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    string wordsWithAy = "";

                    //for every word in the array
                    //use the GetPigLatin method
                    for (int x = 0; x < words.Length; x++ )
                    {
                        wordsWithAy += GetPigLatin(words[x]);
                        if (words.Length > 1)
                        {
                            wordsWithAy += " ";
                        }
                    }

                    //this will set the words to the Translation box
                    TranslationBox.Text = wordsWithAy;
                    //adds the translated words to the List
                    translatedWords.Add(wordsWithAy);
                    //adds the translated words list to the Translated words box
                    TranslatedWordsBox.Text = string.Join(", ", translatedWords);
                    UserInputBox.Text = "";
                    //shows what word they were trying to translate originally
                    wordToTranslateBox.Text = userWord;
                }
            }
        }

        //this will clear all the boxes and list
        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = "";
            wordToTranslateBox.Text = "";
            TranslationBox.Text = "";
            TranslatedWordsBox.Text = "";
            translatedWords.Clear();
        }

        //This will exit the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
