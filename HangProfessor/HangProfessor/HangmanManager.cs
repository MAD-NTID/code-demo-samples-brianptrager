using System;
using System.Collections.Generic;
using System.Text;

namespace HangProfessor
{
    class HangmanManager
    {
        //store the hidden word
        private string hiddenString;
        //A public read only auto property to store the string of correctly guessed characters and asterisks.
        public string DisplayString { get; private set; }

        //A public read only property to indicate if the game is over.
        public bool GameOver {
            get
            {
                return DisplayString == hiddenString;
            }
        }

        //A constructor that accepts the hidden word to display.
        public HangmanManager(string word)
        {
            hiddenString = word;

            CreateDisplayString();
        }

        public void CreateDisplayString()
        {
            for (int i = 0; i < hiddenString.Length; i++)
                DisplayString += "*";
        }

        public bool Guess(char c)
        {
            bool flag = false;
            for(int i = 0; i < hiddenString.Length; i++)
            {
                if(c == hiddenString[i])
                {
                    DisplayString = DisplayString.Remove(i, 1);
                    DisplayString = DisplayString.Insert(i, c.ToString());
                    flag = true;
                }
            }

            return flag;
        }
    }
}
