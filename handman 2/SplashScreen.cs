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
    public partial class SplashScreen : Form
    {
        static bool state;
        public SplashScreen()
        {
            
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
         //   Timer timers = new Timer();
            timer1.Interval = 5000;
            if(state == false)
            {
                timer1.Start();
            }
            timer1.Tick += (timer1_Tick);

        }
         void timer1_Tick(object sender, EventArgs e)
        {
            Hangman h = new Hangman();
            if(state == false)
            {
                state = true;
                h.Show();
                this.Hide();
                timer1.Stop();
                timer1.Dispose();
                timer1.Enabled = false;
            }
            
        }

    }
}
