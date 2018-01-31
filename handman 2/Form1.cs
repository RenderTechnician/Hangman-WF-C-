using System;
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
            values val = new values();
            InitializeComponent();
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            values val = new values();
            Whatword wd = new Whatword();
            do
            {
                val.GetInput = UserInput.Text.ToLower();
                UserInput.Clear();
                if (val.GetCurrentWord[val.GetLetter].Equals(val.GetInput) && val.GetInput.Length > 0)
                {
                }
                else
                {
                    val.GetMatcher++;
                }
                    val.GetLetter++;
            } while (Debug_Label.Text.Length  > val.GetLetter);
            val.GetLetter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            values val = new values();
            Whatword wd = new Whatword();
            Random rnd = new Random();
            val.GetWord = rnd.Next(0,7);
            val.GetCurrentWord = wd.GetCurrentWord[val.GetWord];
            Debug_Label.Text = val.GetCurrentWord;
            val.GetWordlength = Debug_Label.Text.Length;
            val.GetShowTo = new string('*', Debug_Label.Text.Length);
            Show_Word.Text = val.GetShowTo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
    public class values
    {
        private int matches;
        private int WhatWord;
        private int wordlength;
        private int letter;
        private string input;
        private static string currentword;
        private string ShowTo;
        //get set
        public int GetMatcher
        {
            get { return matches; }
            set { matches = value;}
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
            values val = new values();



        } 
    }
}
