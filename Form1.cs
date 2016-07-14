using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Morse_Code_Converter
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void convertButton_Click(object sender, EventArgs e)
        {
            
            // Initialize array of chars for the characters
            char[] lettersNumbers = 
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4',
                '5', '6', '7', '8', '9', '0', ' ', ',', '.', '?'
            };

            // Initialize array of string for the morse code 
            string[] morseCodeList = 
            {
               ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                ".---", "-.-", ".-..", "--", "-.", "---", ".---.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----",
                "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                "-----", " ", "--..--", ".-.-.-", "..--.."
             };

            // Set string for user input 
            string userInputText = userInputTextBox.Text;
            // Convert user text to lowercase
            userInputText = userInputText.ToLower();
            // Set user text to char array 
            char[] chars = userInputText.ToCharArray();
            // Set empty string to hold output 
            string str = "";
            // Loop thru the chars array 
            for (int i = 0; i < chars.Length; i++)
            {
                // Loop thru the lettersNumbers array
                for (int t = 0; t <lettersNumbers.Length; t++)
                {
                    // Compare the the arrays
                    if (lettersNumbers[t] == chars[i])
                    {
                        // Set string with morsecode  
                        str = morseCodeList[t];
                    }
                }
                // Output the morsecode to the label 
                morseCodeOutput.Text += str;
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the fields for input and output 
            morseCodeOutput.Text = "";
            userInputTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
