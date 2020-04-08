using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOver.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            enemy(gameSpeed);
            gameover();
            coins(gameSpeed);
            coinCount();
        }

        Random r = new Random();
        int x, y;
        int gameSpeed = 0;
        int coinCollect = 0;
        void gameover()
        {
            if (carBox.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }
            if (carBox.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }
            if (carBox.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }
        }

        void coinCount()
        {
            if (carBox.Bounds.IntersectsWith(Coin1.Bounds))
            {
                coinCollect++;
                label1.Text = "Count = " + coinCollect;
                Coin1.Location = new Point(x, 0);

            }
            if (carBox.Bounds.IntersectsWith(Coin2.Bounds))
            {
                coinCollect++;
                label1.Text = "Count = " + coinCollect;
                Coin2.Location = new Point(x, 0);

            }
            if (carBox.Bounds.IntersectsWith(Coin3.Bounds))
            {
                coinCollect++;
                label1.Text = "Count = " + coinCollect;
                Coin3.Location = new Point(x, 0);
            }
            if (carBox.Bounds.IntersectsWith(Coin4.Bounds))
            {
                coinCollect++;
                label1.Text = "Count = " + coinCollect;
                Coin4.Location = new Point(x, 0);
            }
        }

        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(10, 70);

                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(75,150);

                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = r.Next(150, 220);

                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }


        }
        
        void coins(int speed)
        {
            if (Coin1.Top >= 500)
            {
                x = r.Next(10, 59);

                Coin1.Location = new Point(x, 0);
            }
            else { Coin1.Top += speed; }

            if (Coin2.Top >= 500)
            {
                x = r.Next(100, 150);

                Coin2.Location = new Point(x, 0);
            }
            else { Coin2.Top += speed; }

            if (Coin3.Top >= 500)
            {
                x = r.Next(60, 90);

                Coin3.Location = new Point(x, 0);
            }
            else { Coin3.Top += speed; }

            if (Coin4.Top >= 500)
            {
                x = r.Next(150, 200);

                Coin4.Location = new Point(x, 0);
            }
            else { Coin4.Top += speed; }
        }

        void moveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else { pictureBox4.Top += speed; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(carBox.Left > 0)
                carBox.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(carBox.Right < 250)
                carBox.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 8)
                {
                    gameSpeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }


        }
    }
}
