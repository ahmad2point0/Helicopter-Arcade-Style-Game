using System.Media;
namespace HelicopterFlyingGame
{
    public partial class Form1 : Form
    {
        bool goUP, goDown, gameOver,prescreen=false;
        int score = 0;
        int speed = 4;
        int playerSpeed = 3;
        int count = 0;
        int bscore = 0;
        SoundPlayer hs = new SoundPlayer(@"E:\Projects\HelicopterFlyingGame\Assets\helicopterSound.wav");
        SoundPlayer bs = new SoundPlayer(@"E:\Projects\HelicopterFlyingGame\Assets\backgroundmusic.wav");
        SoundPlayer cs = new SoundPlayer(@"E:\Projects\HelicopterFlyingGame\Assets\crash.wav");
        public Form1()
        {
            InitializeComponent();
            GameTimer.Interval = 30;
            GameTimer.Tick += MainTimeEvent;
            bs.PlayLooping();
            
        }

        private void MainTimeEvent(object sender, EventArgs e)
        { 
            if (prescreen==false)
            {
                PreScreen();
            }
            else
            {
                pillar1.Show();
                pillar2.Show();
                lb_startgame.Text = "";
                lb_gameOver.Text = "";
                score++;
                lb_score.Text = "Score :" + score;
                if (goUP == true && Helicopter.Top > 0)
                {
                    Helicopter.Top -= playerSpeed;
                }
                if (goDown == true && Helicopter.Top + Helicopter.Height < this.ClientSize.Height)
                {
                    Helicopter.Top += playerSpeed;
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "pillar")
                    {
                        x.Left -= speed;

                        if (x.Left < -200)
                        {
                            x.Left = 800;
                        }
                        if (Helicopter.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOver();
                        }
                    }
                    if (x is PictureBox && (string)x.Tag == "border")
                    {
                        if (Helicopter.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOver();
                        }
                    }
                    if(score>500)
                    {
                        speed = 6;
                        playerSpeed = 5;
                    }
                    if(score>1000)
                    {
                        speed += 2;
                        playerSpeed += 2;
                    }
                    if(score>1500)
                    {
                        speed += 2;
                        playerSpeed += 2;
                    }
                    if(score>2000)
                    {
                        speed += 2;
                        playerSpeed += 2;
                    }
                }
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                goUP = true;
                goDown = false;
                if(prescreen==false)
                {
                    prescreen = true;
                    bs.Stop();
                    if (count == 0)
                    {
                        hs.PlayLooping();
                        count++;
                    }
                    GameTimer.Start();
                }
                
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                prescreen = true;
                goUP =false;
                goDown = true;
            }
            if(e.KeyCode==Keys.Enter && gameOver==true)
            {
                RestartGame();

            }
        }

        private void MouseIsDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                goUP = true;
                goDown = false;
                if (prescreen == false)
                {
                    prescreen = true;
                    bs.Stop();
                    if (count == 0)
                    {
                        hs.PlayLooping();
                        count++;
                    }
                    GameTimer.Start();
                }

            }
        }

        private void MouseIsUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                prescreen = true;
                goUP = false;
                goDown = true;
            }
        }

        private void PreScreen()
        {
            lb_startgame.Text = "Press Space key Or Mouse left Button To Start The Game";
            pillar1.Hide();
            pillar2.Hide();
            goUP = false;
            goDown = false;
            gameOver = false;
            score = 0;
            speed = 4;
            lb_score.Text = "Score :" + score;
            lb_gameOver.Text = "";
            Helicopter.Top = 103;
            pillar1.Left = 141;
            pillar2.Left = 701;
            GameTimer.Stop();
        }

        private void RestartGame()
        {
            hs.PlayLooping();
            goUP = false;
            goDown = true;
            gameOver = false;
            score = 0;
            speed = 4;
            lb_score.Text = "Score :" + score;
            lb_gameOver.Text = "";
            Helicopter.Top = 103;
            pillar1.Left = 141;
            pillar2.Left = 701;
            GameTimer.Start();
           
        }
        private void GameOver()
        {
            GameTimer.Stop();
            hs.Stop();
            cs.Play();
            lb_gameOver.Text = "Game Over Your Score is " + score + " Press Enter To Restart The Game";
            if(score>bscore)
            {
                bscore = score;
            }
            lb_best.Text = "Best : " + bscore;
            gameOver = true;
        }
    }
}