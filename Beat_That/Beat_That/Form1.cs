using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Beat_That
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int onInList = 0;
        List<int> pattern = new List<int>();
        Random randy = new Random();
        bool play_Back = false;

        private void Red_Click(object sender, EventArgs e)
        {
            testCorrect(0);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            testCorrect(1);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            testCorrect(2);
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            testCorrect(3);
        }

        void testCorrect(int x)
        {
            if (play_Back) return;
            if (pattern[onInList] == x)
            {   
                onInList++;
            }
            else
            {
                MessageBox.Show("eat a dick Satnam, it's like Platinum with an S. Final Score: " + pattern.Count.ToString());
                onInList = 0;
                pattern = new List<int>();
                new Thread(playBack).Start();
            }
            if(onInList >= pattern.Count)
            {
                Thread.Sleep(600);
                pattern.Add(randy.Next(0, 4));
                onInList = 0;
                new Thread(playBack).Start();
            }
            Score.Text = ("Score: " + pattern.Count.ToString());
            PatternLabel.Text = ("In Pattern: " + onInList.ToString());

        }

        void playBack()
        {
            play_Back = true;
            foreach(int color in pattern)
            {
                switch (color)
                {
                    case 0:
                        Red.BackColor = Color.White;
                        Thread.Sleep(400);
                        Red.BackColor = Color.Red;
                        break;
                    case 1:
                        Green.BackColor = Color.White;
                        Thread.Sleep(400);
                        Green.BackColor = Color.Green;
                        break;
                    case 2:
                        Yellow.BackColor = Color.White;
                        Thread.Sleep(400);
                        Yellow.BackColor = Color.Yellow;
                        break;
                    case 3:
                        Blue.BackColor = Color.White;
                        Thread.Sleep(400);
                        Blue.BackColor = Color.Blue;
                        break;
                }
                Thread.Sleep(600);
            }
            play_Back = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pattern.Add(randy.Next(0, 4));
            new Thread(playBack).Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
