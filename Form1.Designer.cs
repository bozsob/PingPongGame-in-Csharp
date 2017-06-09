namespace PingPongGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameBackGround = new System.Windows.Forms.Panel();
            this.gameOver = new System.Windows.Forms.Label();
            this.scorePoints = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.gameBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBackGround
            // 
            this.gameBackGround.BackColor = System.Drawing.Color.Transparent;
            this.gameBackGround.Controls.Add(this.gameOver);
            this.gameBackGround.Controls.Add(this.scorePoints);
            this.gameBackGround.Controls.Add(this.scoreLabel);
            this.gameBackGround.Controls.Add(this.ball);
            this.gameBackGround.Controls.Add(this.player);
            this.gameBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBackGround.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameBackGround.Location = new System.Drawing.Point(0, 0);
            this.gameBackGround.Name = "gameBackGround";
            this.gameBackGround.Size = new System.Drawing.Size(681, 365);
            this.gameBackGround.TabIndex = 0;
            
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Location = new System.Drawing.Point(354, 13);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(197, 148);
            this.gameOver.TabIndex = 4;
            this.gameOver.Text = "Game Over\r\nF1 - Easy\r\nF2 - Hard\r\nEsc - Exit";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scorePoints
            // 
            this.scorePoints.AutoSize = true;
            this.scorePoints.Location = new System.Drawing.Point(129, 13);
            this.scorePoints.Name = "scorePoints";
            this.scorePoints.Size = new System.Drawing.Size(35, 37);
            this.scorePoints.TabIndex = 3;
            this.scorePoints.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(13, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(143, 37);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = global::PingPongGame.Properties.Resources.ping_pong_ball;
            this.ball.Image = global::PingPongGame.Properties.Resources.ping_pong_ball;
            this.ball.Location = new System.Drawing.Point(244, 125);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(35, 35);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DimGray;
            this.player.Location = new System.Drawing.Point(168, 279);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(200, 20);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 365);
            this.Controls.Add(this.gameBackGround);
            this.Name = "Form1";
            this.Text = "PongGame";
           
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gameBackGround.ResumeLayout(false);
            this.gameBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameBackGround;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scorePoints;
        private System.Windows.Forms.Label gameOver;
    }
}

