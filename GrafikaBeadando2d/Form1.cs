using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GrafikaBeadando2d
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer sound_intro;
        WindowsMediaPlayer sound_music;
        WindowsMediaPlayer sound_explosion;
        WindowsMediaPlayer sound_shot;
        Random rnd;
        PictureBox[] background;
        PictureBox[] Enemy;
        PictureBox[] shotFalcon;
        PictureBox[] shotEnemy;
        int speedbackground;
        int speedFalcon;
        int speedEnemy;
        int speedShotFalcon;
        int speedShotEnemy;
        int enemyshots;
        int score;
        int level;
        int hp;
        bool started;
        bool paused;
        int step;
        private void Form1_Load(object sender, EventArgs e)
        {
            step = 10;
            speedFalcon = 4;
            speedEnemy = 1;
            speedShotFalcon = 20;
            speedShotEnemy = 4;
            enemyshots = 1;
            started = false;
            paused = false;
            rnd = new Random();
            soundsUpload();
            enemyUpload();
            shotsUpload();
            backGround();
            intro();            
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((!started)&&(!paused)&&(e.KeyCode == Keys.Enter))
            {
                gameNew();
            }
            if ((started) && (!paused))
            {
                if (e.KeyCode == Keys.Left)
                {
                    timerLeftMove.Start();
                }
                if (e.KeyCode == Keys.Right)
                {
                    timerRightMove.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    timerUpMove.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    timerDownMove.Start();
                }
                if (e.KeyCode == Keys.Space)
                {
                    gamePause();
                }
            }
            if ((started) && (paused) && (e.KeyCode == Keys.Enter))
            {
                gameContinue();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                timerLeftMove.Stop();
            }
            if (e.KeyCode == Keys.Right)
            {
                timerRightMove.Stop();
            }
            if (e.KeyCode == Keys.Up)
            {
                timerUpMove.Stop();
            }
            if (e.KeyCode == Keys.Down)
            {
                timerDownMove.Stop();
            }
        }
        private void intro()
        {
            
            label_StartGame.Text = "Press Enter to Start";
            label_StartGame.Visible = true;
            label_Description.Text = "use arrows to move, Space to pause";
            label_Description.Visible = true;
            sound_intro.controls.play();
        }
        private void backGround()
        {
            background = new PictureBox[30];
            speedbackground = 4;
            for (int i = 0; i < background.Length; i++)
            {
                background[i] = new PictureBox();
                background[i].BorderStyle = BorderStyle.None;
                background[i].Location = new Point(rnd.Next(5, 580), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    background[i].Size = new Size(2, 2);
                    background[i].BackColor = Color.Wheat;
                }
                else
                {
                    background[i].Size = new Size(3, 3);
                    background[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(background[i]);
            }
            timerBackground.Enabled = true;
        }
        private void gameNew()
        {
            started = true;
            paused = false;
            sound_intro.controls.stop();
            sound_music.controls.play();
            label_StartGame.Visible = false;
            label_Description.Visible = false;
            label_GameOver.Visible = false;
            Falcon.Visible = true;
            Falcon.Location = new Point(200, 310);
            timerFalconShot.Start();
            timerEnemyMove.Start();
            timerEnemyShot.Start();
            timerJudge.Start();
            level = 1;
            score = 0;
            hp = 3;
            enemyshots = level;
            label_score.Visible = true;
            label_hp.Visible = true;
            label_level.Visible = true;
            refresh_score();
            refresh_level();
            refresh_hp();
        }
        private void gameOver()
        {
            started = false;
            label_GameOver.Text = "Game Over, your score was: " + score;
            label_GameOver.Visible = true;
            label_Description.Visible = true;
            label_StartGame.Visible = true;
            sound_music.controls.stop();
            timerFalconShot.Stop();
            timerEnemyShot.Stop();
            timerEnemyMove.Stop();
            for (int i = 0; i < Enemy.Length; i++)
            {
                Enemy[i].Top += 500;
            }
            for (int i = 0; i < shotEnemy.Length; i++)
            {
                shotEnemy[i].Top += 500;
            }
            for (int i = 0; i < shotFalcon.Length; i++)
            {
                shotFalcon[i].Top -= 500;
            }
            Falcon.Visible = false;
        }
        private void gamePause()
        {
            sound_music.controls.pause();
            timerFalconShot.Stop();
            timerEnemyShot.Stop();
            timerEnemyMove.Stop();
            paused = true;
            label_Paused.Visible = true;
        }
        private void gameContinue()
        {
            sound_music.controls.play();
            timerFalconShot.Start();
            timerEnemyShot.Start();
            timerEnemyMove.Start();
            paused = false;
            label_Paused.Visible = false;
        }
        private void judging()
        {
            for (int i = 0; i < Enemy.Length; i++)
            {
                if (shotFalcon[0].Bounds.IntersectsWith(Enemy[i].Bounds) || shotFalcon[1].Bounds.IntersectsWith(Enemy[i].Bounds))
                {
                    Enemy[i].Location = new Point((i + 1) * 60 - 30, -100);
                    score++;
                    refresh_score();
                    if (score % step == 0)
                    {
                        level++;
                        refresh_level();
                        if (level <= 7)
                        {
                            enemyshots = level;
                        }
                        else
                        {
                            speedShotEnemy++;
                        }
                    }
                }
            }
            for (int i = 0; i < shotEnemy.Length; i++)
            {
                if (shotEnemy[i].Bounds.IntersectsWith(Falcon.Bounds))
                {
                    shotEnemy[i].Top += 500;
                    if (hp > 0)
                    {
                        hp--;
                        refresh_hp();
                    }
                }
            }
            for (int i = 0; i < Enemy.Length; i++)
            {
                if (Enemy[i].Bounds.IntersectsWith(Falcon.Bounds))
                {
                    gameOver();
                    Enemy[i].Top += 500;
                }
            }
            if (hp == 0)
            {
                gameOver();
            }
            
        }
        private void enemyUpload()
        {
            Enemy = new PictureBox[7];
            Image tie1 = Image.FromFile("pics\\tie1.png");
            Image tie2 = Image.FromFile("pics\\tie2.png");
            Image tie3 = Image.FromFile("pics\\tie3.png");
            Image destroyer = Image.FromFile("pics\\destroyer.png");
            Image star = Image.FromFile("pics\\star.png");
            for (int i = 0; i < Enemy.Length; i++)
            {
                Enemy[i] = new PictureBox();
                Enemy[i].Size = new Size(40, 40);
                Enemy[i].SizeMode = PictureBoxSizeMode.Zoom;
                Enemy[i].BorderStyle = BorderStyle.None;
                Enemy[i].Visible = false;
                this.Controls.Add(Enemy[i]);
                Enemy[i].Location = new Point((i + 1) * 60 - 30, -50);
            }
            Enemy[0].Image = tie3;
            Enemy[1].Image = tie1;
            Enemy[2].Image = tie2;
            Enemy[3].Image = star;
            Enemy[4].Image = tie3;
            Enemy[5].Image = destroyer;
            Enemy[6].Image = tie3;
        }
        private void soundsUpload()
        {
            sound_intro = new WindowsMediaPlayer();
            sound_intro.URL = "sounds\\intro.mp3";
            sound_intro.settings.setMode("loop", true);
            sound_intro.settings.volume = 6;
            sound_intro.controls.stop();
            sound_music = new WindowsMediaPlayer();
            sound_music.URL = "sounds\\music.mp3";
            sound_music.settings.setMode("loop", true);
            sound_music.settings.volume = 6;
            sound_music.controls.stop();
            sound_explosion = new WindowsMediaPlayer();
            sound_explosion.URL = "sounds\\explosion.mp3";
            sound_explosion.settings.volume = 6;
            sound_explosion.controls.stop();
            sound_shot = new WindowsMediaPlayer();
            sound_shot.URL = "sounds\\shot.mp3";
            sound_shot.settings.volume = 1;
            sound_shot.controls.stop();
        }
        private void shotsUpload()
        {
            shotFalcon = new PictureBox[2];
            shotEnemy = new PictureBox[7];
            for (int i = 0; i < shotFalcon.Length; i++)
            {
                shotFalcon[i] = new PictureBox();
                shotFalcon[i].Size = new Size(2, 10);
                shotFalcon[i].Visible = false;
                shotFalcon[i].BackColor = Color.Red;
                this.Controls.Add(shotFalcon[i]);
            }
            for (int i = 0; i < shotEnemy.Length; i++)
            {
                shotEnemy[i] = new PictureBox();
                shotEnemy[i].Size = new Size(2, 10);
                shotEnemy[i].Visible = false;
                shotEnemy[i].BackColor = Color.GreenYellow;
                this.Controls.Add(shotEnemy[i]);
            }
        }
        private void refresh_score()
        {
            label_score.Text = "Score: " + score;
        }
        private void refresh_hp()
        {
            label_hp.Text = "HP: " + hp;
        }
        private void refresh_level()
        {
            label_level.Text = "Level: " + level;
        }
        private void timerBackground_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < background.Length / 2; i++)
            {
                background[i].Top += speedbackground;
                if (background[i].Top >= this.Height)
                {
                    background[i].Top = -background[i].Height;
                }
            }
            for (int i = background.Length / 2; i < background.Length; i++)
            {
                background[i].Top += speedbackground - 2;
                if (background[i].Top >= this.Height)
                {
                    background[i].Top = -background[i].Height;
                }
            }
        }
        private void timerLeftMove_Tick(object sender, EventArgs e)
        {
            if (Falcon.Left > 10)
            {
                Falcon.Left -= speedFalcon;
            }
        }
        private void timerRigthMove_Tick(object sender, EventArgs e)
        {
            if (Falcon.Right < 430)
            {
                Falcon.Left += speedFalcon;
            }
        }
        private void timerUpMove_Tick(object sender, EventArgs e)
        {
            if (Falcon.Top > 10)
            {
                Falcon.Top -= speedFalcon;
            }
        }
        private void timerDownMove_Tick(object sender, EventArgs e)
        {
            if (Falcon.Top < 320)
            {
                Falcon.Top += speedFalcon;
            }
        }
        private void timerFalconShot_Tick(object sender, EventArgs e)
        {
            sound_shot.controls.play();
            for (int i = 0; i < shotFalcon.Length; i++)
            {
                if (shotFalcon[i].Top > 0)
                {
                    shotFalcon[i].Visible = true;
                    shotFalcon[i].Top -= speedShotFalcon;
                }
                else
                {
                    shotFalcon[i].Visible = false;
                    shotFalcon[i].Location = new Point(Falcon.Location.X + 20, Falcon.Location.Y - i * 30);
                }
            }
        }
        private void timerEnemyMove_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Enemy.Length; i++)
            {
                Enemy[i].Visible = true;
                Enemy[i].Top += speedEnemy;
                if (Enemy[i].Top > this.Height)
                {
                    Enemy[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        private void timerEnemyShot_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyshots; i++)
            {
                if (shotEnemy[i].Top < this.Height)
                {
                    shotEnemy[i].Visible = true;
                    shotEnemy[i].Top += speedShotEnemy;
                }
                else
                {
                    shotEnemy[i].Visible = false;
                    int x = rnd.Next(0, 7);
                    shotEnemy[i].Location = new Point(Enemy[x].Location.X + 20, Enemy[x].Location.Y + 30);
                }
            }
        }
        private void timerJudge_Tick(object sender, EventArgs e)
        {
            judging();
        }
    }
}
