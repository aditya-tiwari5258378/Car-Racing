namespace CarRacing
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form1" />.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Over.Visible = false;
        }

        /// <summary>
        /// The pictureBox3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Form1_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The pictureBox6_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Defines the totalCoins.
        /// </summary>
        internal int totalCoins = 0;

        /// <summary>
        /// The timer1_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            enemy(gameSpeed);
            gameOver();
            coins(gameSpeed);
            total_coins();
        }

        /// <summary>
        /// The total_coins.
        /// </summary>
        internal void total_coins()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                totalCoins++;
                label1.Text = "Coins=" + totalCoins.ToString();
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                totalCoins++;
                label1.Text = "Coins=" + totalCoins.ToString();
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                totalCoins++;
                label1.Text = "Coins=" + totalCoins.ToString();
                x = r.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                totalCoins++;
                label1.Text = "Coins=" + totalCoins.ToString();
                x = r.Next(0, 200);
                coin4.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin5.Bounds))
            {
                totalCoins++;
                label1.Text = "Coins=" + totalCoins.ToString();
                x = r.Next(0, 200);
                coin5.Location = new Point(x, 0);
            }
        }

        /// <summary>
        /// The coins.
        /// </summary>
        /// <param name="speed">The speed<see cref="int"/>.</param>
        internal void coins(int speed)
        {
            if (coin1.Top >= 699)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }



            if (coin2.Top >= 699)
            {
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }




            if (coin3.Top >= 699)
            {
                x = r.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }





            if (coin4.Top >= 699)
            {
                x = r.Next(0, 200);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }


            if (coin5.Top >= 699)
            {
                x = r.Next(0, 200);
                coin5.Location = new Point(x, 0);
            }
            else
            {
                coin5.Top += speed;
            }
        }

        /// <summary>
        /// Defines the r.
        /// </summary>
        internal Random r = new Random();

        /// <summary>
        /// Defines the x, y..
        /// </summary>
        internal int x, y;

        /// <summary>
        /// The enemy.
        /// </summary>
        /// <param name="speed">The speed<see cref="int"/>.</param>
        internal void enemy(int speed)
        {

            if (enemy1.Top >= 699)
            {
                x = r.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 699)
            {
                x = r.Next(0, 200);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 699)
            {
                x = r.Next(210, 400);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }

            if (enemy4.Top >= 699)
            {
                x = r.Next(210, 400);
                enemy4.Location = new Point(x, 0);
            }
            else
            {
                enemy4.Top += speed;
            }
        }

        /// <summary>
        /// The gameOver.
        /// </summary>
        internal void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
        }

        /// <summary>
        /// The moveLine.
        /// </summary>
        /// <param name="speed">The speed<see cref="int"/>.</param>
        internal void moveLine(int speed)
        {
            if (pictureBox1.Top >= 699)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 699)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 699)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 699)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 699)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
        }

        /// <summary>
        /// The pictureBox8_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The pictureBox8_PreviewKeyDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="PreviewKeyDownEventArgs"/>.</param>
        private void pictureBox8_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        /// <summary>
        /// Defines the gameSpeed.
        /// </summary>
        internal int gameSpeed = 0;

        /// <summary>
        /// The Form1_KeyDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 20)
                {
                    car.Left += -gameSpeed;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 470)
                {
                    car.Left += gameSpeed;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21)
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
