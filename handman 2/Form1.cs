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
            if (val.GetInput == "" || val.GetInput == " ")
            {
                MessageBox.Show("Please enter a valid value");
                if(val.GetMatcher > 0)
                {
                    val.GetMatcher--;
                }
            }
            val.GetShowTo = str.ToString();
            Show_Word.Text = val.GetShowTo;
            if (!val.GetCurrentWord.Contains(val.GetInput))
            {
                val.GetMatcher++;
                pictureBox1 = Stage(pictureBox1);
            }
            UserInput.Clear();
            val.GetLetter = 0;
            if (!val.GetShowTo.Contains("*")) // Opens Win Screen and re-sets main scene
            {
                winning_screen w = new winning_screen();
                w.ShowDialog();
                button1.PerformClick();
            }
            if (val.GetMatcher > 8) // Opens Lose Screen and re-sets main scene
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
            val.GetWord = rnd.Next(0, wd.GetCurrentWord.Length);
            HintBox.Text = wd.GetCurrentHint[val.GetWord];
            val.GetCurrentWord = wd.GetCurrentWord[val.GetWord];
            do
            {
                str2.Append("*");
                val.GetLetter++;
            } while (val.GetCurrentWord.Length > val.GetLetter);
            val.GetLetter = 0;
            val.GetMatcher = 0;
           pictureBox1.Image = Properties.Resources.frame1; //Sets PictureBox back to Frame 1
            val.GetShowTo = str2.ToString();
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
        private static int matches;               // Determines How many words in the phrase have been correctly guessed.
        private static int WhatWord;             //  Determines which word has been selected by the program. [Int]
        private static int letter;              //   What letter is currently selected, also controls most 'do,while' loops.
        private static string input;           //    The parsed text from the input box, this is the guess from the user
        private static string currentword;    //     Determines which word has been selected by the program. [String]
        private static string ShowTo;        //      Determines the string that is presented to the user.

        // All get Set methods, these allow these above variables to passed through objects.
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
