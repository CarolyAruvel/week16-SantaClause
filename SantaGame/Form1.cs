using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaGame
{
    public partial class Form1 : Form
    {

        int gravity = 10;
        int santaSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            snowflake.Left -= santaSpeed;
            moon.Left -= santaSpeed;
            hut.Left -= santaSpeed;
            scoreLabel.Text = $"score: {score}";

            if(moon.Left < -80)
            {
                moon.Left = 500;
                score++;
            }

            if(hut.Left < -100)
            {
                hut.Left = 600;
                score++;
            }

            if (santa.Top < -25)
            {
                gameOver();
            }

            if (santa.Bounds.IntersectsWith(moon.Bounds) || santa.Bounds.IntersectsWith(hut.Bounds) || santa.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }

           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5; 
            }
        }

        private void gameOver()
        {
            timer1.Stop(); 
            scoreLabel.Text = $"Game over!";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
