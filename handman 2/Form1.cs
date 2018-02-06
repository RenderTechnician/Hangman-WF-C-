using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace handman_2
{

    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Validate_Click(object sender, EventArgs e)
        {
            variables.values val = new variables.values();
            StringBuilder str = new StringBuilder();
            Stack PreviousWords = new Stack(); // move to a constructor?
            do
            {
                val.GetInput = UserInput.Text.ToLower();
                if (val.GetCurrentWord[val.GetLetter].ToString() == val.GetInput.ToString())
                {
                    str.Append(val.GetInput);
                }
                else if (val.GetShowTo[val.GetLetter].ToString() != "*")
                {
                    str.Append(val.GetShowTo[val.GetLetter]);
                }
                else
                {
                    str.Append("*");
                    val.GetMatcher++;
                }
                    val.GetLetter++;
            } while (val.GetCurrentWord.Length > val.GetLetter);
            val.GetShowTo = str.ToString();
            Show_Word.Text = val.GetShowTo;
            UserInput.Clear(); // might get rid of this when we push input to a stack
            val.GetLetter = 0;
            if (!val.GetShowTo.Contains("*"))
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variables.values val = new variables.values();
            Whatword wd = new Whatword();
            Random rnd = new Random();
            StringBuilder str2 = new StringBuilder();
            val.GetWord = rnd.Next(0,7); // unnecessary?
            val.GetCurrentWord = wd.GetCurrentWord[val.GetWord];
            Debug_Label.Text = val.GetCurrentWord;
            val.GetWordlength = Debug_Label.Text.Length; //unnecessary?
            do
            {
                str2.Append("*");
                val.GetLetter++;
            } while (Debug_Label.Text.Length > val.GetLetter);
            val.GetLetter = 0;
            val.GetShowTo = str2.ToString(); // unnecessary?
            Show_Word.Text = val.GetShowTo;
        }
    }
    
    public class Whatword
    {
        private string[] currentword = 
            {
            "instantiate",
            "asymmetric",
            "dot",
            "animatronic",
            "swordfish",
            "detrimental",
            "organisation"};

        public string[] GetCurrentWord
        {
            get { return currentword; }
            set { currentword = value; }
        }
    }
    public class Hangmanstage
    {
        public Hangmanstage()
        {



        } 
    }
}
namespace variables
{
    public class values
    {
        private static int matches;
        private static int WhatWord;
        private static int wordlength;
        private static int letter;
        private static string input;
        private static string currentword;
        private static string ShowTo;
        //get set
        public int GetMatcher
        {
            get { return matches; }
            set { matches = value; }
        }
        public int GetWord
        {
            get { return WhatWord; }
            set { WhatWord = value; }
        }
        public int GetWordlength
        {
            get { return wordlength; }
            set { wordlength = value; }
        }
        public int GetLetter
        {
            get { return letter; }
            set { letter = value; }
        }
        public string GetInput
        {
            get { return input; }
            set { input = value; }
        }
        public string GetCurrentWord
        {
            get { return currentword; }
            set { currentword = value; }
        }
        public string GetShowTo
        {
            get { return ShowTo; }
            set { ShowTo = value; }
        }
    }
}
