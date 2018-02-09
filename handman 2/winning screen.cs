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
    public partial class winning_screen : Form
    {
        public winning_screen()
        {
            Hangman h = new Hangman();
            InitializeComponent();
            h.Enabled = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {

            Hangman h = new Hangman();
            h.Enabled = true;
            h.button1.PerformClick();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
