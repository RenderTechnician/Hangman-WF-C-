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
            UserInput.Clear(); // might get rid of this when we push input to a stack
            val.GetLetter = 0;
            if (!val.GetShowTo.Contains("*"))
            {
                winning_screen w = new winning_screen();
                w.ShowDialog();
                button1.PerformClick();
            //go to win screen
            }
            if (val.GetMatcher > 8)
            {
                Lose_Screen lose = new Lose_Screen();
                lose.ShowDialog();
                button1.PerformClick();
            }
            }
        public void button1_Click(object sender, EventArgs e)
        {
            variables.values val = new variables.values();
            Whatword wd = new Whatword();
            Random rnd = new Random();
            StringBuilder str2 = new StringBuilder();
            val.GetWord = rnd.Next(0, wd.GetCurrentWord.Length); // unnecessary?
            HintBox.Text = wd.GetCurrentHint[val.GetWord];
            val.GetCurrentWord = wd.GetCurrentWord[val.GetWord];
            val.GetWordlength = val.GetCurrentWord.Length; //unnecessary?
            do
            {
                str2.Append("*");
                val.GetLetter++;
            } while (val.GetCurrentWord.Length > val.GetLetter);
            val.GetLetter = 0;
            val.GetMatcher = 0;
           pictureBox1.Image = Properties.Resources.frame1; //sets back to frame 1
            val.GetShowTo = str2.ToString(); // unnecessary?
            Show_Word.Text = val.GetShowTo;
        }
        static PictureBox Stage (PictureBox setframe)
            {
            variables.values val = new variables.values();
            //Frame1
            if (val.GetMatcher == 0)
            {
                setframe.Image = Properties.Resources.frame1;
                setframe.Refresh();
            }
            //Frame2
            if (val.GetMatcher == 1)
            {
              setframe.Image = Properties.Resources.frame2;
                setframe.Refresh();
            }
            //Frame3
            if (val.GetMatcher == 2)
            {
                setframe.Image = Properties.Resources.frame3;
                setframe.Refresh();
            }
            //Frame4
            if (val.GetMatcher == 3)
            {
                setframe.Image = Properties.Resources.frame4;
                setframe.Refresh();
            }
            //Frame5
            if (val.GetMatcher == 4)
            {
                setframe.Image = Properties.Resources.frame5;
                setframe.Refresh();
            }
            //Frame6
            if (val.GetMatcher == 5)
            {
                setframe.Image = Properties.Resources.frame6;
                setframe.Refresh();
            }
            //Frame7
            if (val.GetMatcher == 6)
            {
                setframe.Image = Properties.Resources.frame7;
                setframe.Refresh();
            }
            //Frame8
            if (val.GetMatcher == 7)
            {
                setframe.Image = Properties.Resources.frame8;
                setframe.Refresh();
            }
            //Frame9
            if (val.GetMatcher == 8)
            {
                setframe.Image = Properties.Resources.frame9;
                setframe.Refresh();
            }
            //Frame10
            if (val.GetMatcher == 9)
            {
                setframe.Image = Properties.Resources.frame10;
                setframe.Refresh();
            }
            return setframe;
            }
    }

    public class Whatword
    {
        private string[] currentword = System.IO.File.ReadAllLines(@"C:\Users\willr\source\repos\handman 2\handman 2\Words.txt");
        private string[] currenthint = System.IO.File.ReadAllLines(@"C:\Users\willr\source\repos\handman 2\handman 2\Hints.txt");

        public string[] GetCurrentWord
        {
            get { return currentword; }
            set { currentword = value; }
        }
        public string[] GetCurrentHint
        {
            get { return currenthint; }
            set { currenthint = value; }
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
