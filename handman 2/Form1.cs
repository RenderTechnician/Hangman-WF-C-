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
            button1.FlatAppearance.BorderSize = 0;
            Validate.FlatAppearance.BorderSize = 0;
        }
        private void Validate_Click(object sender, EventArgs e)
        {
            variables.values val = new variables.values();
            StringBuilder str = new StringBuilder();
            do
            {
                val.GetInput = UserInput.Text.ToLower();
                if (val.GetStack != null && val.GetStack.Contains(val.GetInput))
                {
                    MessageBox.Show("hello");
                }
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
                  
                }
                    val.GetLetter++;
            } while (val.GetCurrentWord.Length > val.GetLetter);
            val.GetShowTo = str.ToString();
            Show_Word.Text = val.GetShowTo;
            if (!val.GetCurrentWord.Contains(val.GetInput))
            {
                val.GetMatcher++;
                pictureBox1 = Stage(pictureBox1);
            }
           // val.GetStack.Push(val.GetInput);
            UserInput.Clear(); // might get rid of this when we push input to a stack
            val.GetLetter = 0;
            if (!val.GetShowTo.Contains("*"))
            {
                winning_screen w = new winning_screen();
                w.ShowDialog();
            //go to win screen
            }
            if (val.GetMatcher > 9)
            {
            //player loses
            }
            }
        public void button1_Click(object sender, EventArgs e)
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
            val.GetMatcher = 0;
           pictureBox1.Image = Properties.Resources.frame1; //sets back to frame 1
            val.GetShowTo = str2.ToString(); // unnecessary?
            Show_Word.Text = val.GetShowTo;
        }
        static PictureBox Stage (PictureBox setframe)
            {
            variables.values val = new variables.values();
            if (val.GetMatcher == 0) // frame1
            {
                setframe.Image = Properties.Resources.frame1;
                setframe.Refresh();
            }
            if (val.GetMatcher == 1) // frame1
            {
              setframe.Image = Properties.Resources.frame2;
                setframe.Refresh();
            }
            return setframe;
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
        private Stack PreviousWords = null;
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
        public Stack GetStack
        {
            get { return PreviousWords; }
            set { PreviousWords = value; }
        }

    }
}
