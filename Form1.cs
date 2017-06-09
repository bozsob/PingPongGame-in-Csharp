using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {

        public int xSpeed = 7;
        public int ySpeed = 7;        // Ball speed
        public int score = 0;           // Score

        
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;    // Remove border
            this.TopMost = true;                            // Form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      // Fullscreen

            player.Top = gameBackGround.Bottom - (gameBackGround.Bottom / 10);  // Set position of player

            gameOver.Left = (gameBackGround.Width / 2) - (gameOver.Width / 2);  // Textbox of gameOver position to center
            gameOver.Top = (gameBackGround.Height / 2) - (gameOver.Height / 2);
            gameOver.Visible = false;                                           // Textbox of gameOver hide

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Left = Cursor.Position.X - (player.Width / 2);       // Set the center of the player to the position of the cursor

            ball.Left += xSpeed;         // Move the ball
            ball.Top += ySpeed;

            if (ball.Bottom >= player.Top &&
                ball.Bottom >= player.Bottom &&
                ball.Left >= player.Left &&
                ball.Right <= player.Right)     // Collision
            {
                ySpeed = -ySpeed;           // Change direction
                score += 1;
                scorePoints.Text = score.ToString();
            }

            if (ball.Left <= gameBackGround.Left)
            {
                xSpeed = -xSpeed;
            }

            if (ball.Right >= gameBackGround.Right)
            {
                xSpeed = -xSpeed;
            }

            if (ball.Top <= gameBackGround.Top)
            {
                ySpeed = -ySpeed;
            }

            if (ball.Bottom >= gameBackGround.Bottom)
            {
                timer1.Enabled = false;         // Ball is out, stop the game
                gameOver.Visible = true;        // Show textbox of gameOver
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();               // Esc to stop the game
            }
            
            if (e.KeyCode == Keys.F1)       // Restart game in EASY mode
            {
                ball.Top = 10;
                ball.Left = 10;
                xSpeed = 7;
                ySpeed = 7;
                score = 0;
                scorePoints.Text = "0";
                timer1.Enabled = true;
                gameOver.Visible = false;
            }

            if (e.KeyCode == Keys.F2)       // Restart game in HARD mode
            {
                ball.Top = 10;
                ball.Left = 10;
                xSpeed = 15;
                ySpeed = 15;
                score = 0;
                scorePoints.Text = "0";
                timer1.Enabled = true;
                gameOver.Visible = false;
            }
        }
    }
}
