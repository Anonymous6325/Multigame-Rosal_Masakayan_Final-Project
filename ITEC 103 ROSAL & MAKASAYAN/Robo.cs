using ITEC_103_ROSAL___MAKASAYAN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_103_ROSAL___MAKASAYAN
{
    public partial class Robo : Form
    {
         
        bool keyup;
        bool keydown;
        bool keyleft;
        bool keyright;
        string playerDirection = "right";

        
        bool gameOver = false;

         
        double health = 100;
        int movementSpeed = 8;
        int ammoLevel = 5;
        int robotSpeed = 2;
        int annihilations = 0;
        Random random = new Random();

        public Robo()
        {
            InitializeComponent();
            InitializeGame();
        }

        
        private void InitializeGame()
        {
            gameOver = false;
            health = 100;
            movementSpeed = 8;
            ammoLevel = 5;
            robotSpeed = 2;
            annihilations = 0;
            keyup = keydown = keyleft = keyright = false;
            playerDirection = "right";

            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (x.Tag == "robot" || x.Tag == "bullet" || x.Tag == "ammo"))
                {
                    this.Controls.Remove(x);
                    x.Dispose();
                }
            }

            playerController.Left = this.ClientSize.Width / 2;
            playerController.Top = this.ClientSize.Height / 2;
            playerController.Image = Properties.Resources.mr;
            progressHealth.Value = 100;
            progressHealth.ForeColor = Color.Green;

            textAmmo.Text = ammoLevel.ToString();
            textKills.Text = annihilations.ToString();

            
            for (int i = 0; i < 2; i++)  
            {
                spawnRobots();
            }

            gameStart.Start();
        }

        
        private void RestartGame()
        {
            InitializeGame();
        }

         
        private void keyDown(object sender, KeyEventArgs e)
        {
            
            if (gameOver)
            {
                return;
            }

             
            if (e.KeyCode == Keys.Left)
            {
                keyleft = true;
                playerDirection = "left";
                playerController.Image = Properties.Resources.ml;
            }

             
            if (e.KeyCode == Keys.Right)
            {
                keyright = true;
                playerDirection = "right";
                playerController.Image = Properties.Resources.mr;
            }

            
            if (e.KeyCode == Keys.Down)
            {
                keydown = true;
                playerDirection = "down";
                playerController.Image = Properties.Resources.md;
            }

            
            if (e.KeyCode == Keys.Up)
            {
                keyup = true;
                playerDirection = "up";
                playerController.Image = Properties.Resources.mu;
            }
        }

         
        private void keyUp(object sender, KeyEventArgs e)
        {
            
            if (gameOver)
            {
                return;
            }

             
            if (e.KeyCode == Keys.Left)
            {
                keyleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                keyright = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                keydown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                keyup = false;
            }

            if (e.KeyCode == Keys.Space && ammoLevel > 0)
            {
                 
                ammoLevel--;
                shootMain(playerDirection);

                
                if (ammoLevel < 1)
                {
                    spawnAmmo();
                }
            }
        }

        private void GameOver()
        {
            gameStart.Stop();
            gameOver = true;
            DialogResult result = MessageBox.Show("You have lost the game! Do you want to restart?", "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                
                this.Hide();
                Sub_Menu subMenu = new Sub_Menu();
                subMenu.Show();
            }
        }

         
        private void gameStartEvent(object sender, EventArgs e)
        {
             
            if (health > 1)
            {
                progressHealth.Value = Convert.ToInt32(health);
            }
            
            else
            {
                playerController.Image = Properties.Resources.death;
                gameStart.Stop();
                gameOver = true;
                GameOver();
            }

            
            textAmmo.Text = ammoLevel.ToString();
            textKills.Text = annihilations.ToString();

            
            if (health < 20)
            {
                progressHealth.ForeColor = Color.Red;
            }

           
            if (keyleft && playerController.Left > 0)
            {
                playerController.Left -= movementSpeed;
            }

            if (keyright && playerController.Left + playerController.Width < 910)
            {
                playerController.Left += movementSpeed;
            }

            if (keyup && playerController.Top > 60)
            {
                playerController.Top -= movementSpeed;
            }

            if (keydown && playerController.Top + playerController.Height < 490)
            {
                playerController.Top += movementSpeed;
            }

            foreach (Control x in this.Controls)
            {
                
                if (x is PictureBox && x.Tag == "ammo")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(playerController.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));  
                        ((PictureBox)x).Dispose();
                        ammoLevel += 5;
                    }
                }

              
                if (x is PictureBox && x.Tag == "bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }
                }

                 
                if (x is PictureBox && x.Tag == "robot")
                {
                     
                    if (((PictureBox)x).Bounds.IntersectsWith(playerController.Bounds) && gameOver == false)
                    {
                        health -= 1;
                        playerController.BackColor = Color.Red;
                    }
                    else
                    {
                        playerController.BackColor = Color.Transparent;
                    }

                     
                    if (((PictureBox)x).Left > playerController.Left)
                    {
                        ((PictureBox)x).Left -= robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rl;
                    }

                    if (((PictureBox)x).Top > playerController.Top)
                    {
                        ((PictureBox)x).Top -= robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ru;
                    }

                    if (((PictureBox)x).Left < playerController.Left)
                    {
                        ((PictureBox)x).Left += robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rr;
                    }

                    if (((PictureBox)x).Top < playerController.Top)
                    {
                        ((PictureBox)x).Top += robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rd;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "robot"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            
                            annihilations++;

                            
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();

                             
                            spawnRobots();
                        }
                    }
                }

                 
                foreach (Control i in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "robot")
                    {
                        foreach (Control j in this.Controls)
                        {
                            if (i != j && j is PictureBox && j.Tag == "robot")
                            {
                                if (i.Bounds.IntersectsWith(j.Bounds))
                                {
                                    
                                    if (((PictureBox)i).Left < ((PictureBox)j).Left)
                                    {
                                        ((PictureBox)i).Left -= robotSpeed;
                                        ((PictureBox)i).Image = Properties.Resources.rl;  
                                        ((PictureBox)j).Left += robotSpeed;
                                        ((PictureBox)j).Image = Properties.Resources.rr;  
                                    }
                                    else
                                    {
                                        ((PictureBox)i).Left += robotSpeed;
                                        ((PictureBox)i).Image = Properties.Resources.rr;  
                                        ((PictureBox)j).Left -= robotSpeed;
                                        ((PictureBox)j).Image = Properties.Resources.rl;  
                                    }

                                    if (((PictureBox)i).Top < ((PictureBox)j).Top)
                                    {
                                        ((PictureBox)i).Top -= robotSpeed;
                                        ((PictureBox)i).Image = Properties.Resources.ru;  
                                        ((PictureBox)j).Top += robotSpeed;
                                        ((PictureBox)j).Image = Properties.Resources.rd;  
                                    }
                                    else
                                    {
                                        ((PictureBox)i).Top += robotSpeed;
                                        ((PictureBox)i).Image = Properties.Resources.rd;  
                                        ((PictureBox)j).Top -= robotSpeed;
                                        ((PictureBox)j).Image = Properties.Resources.ru;  
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

         
        private void spawnAmmo()
        {
            
            if (!this.Controls.ContainsKey("ammo"))
            {
                
                PictureBox ammo = new PictureBox();
                ammo.BringToFront();
                ammo.Image = Properties.Resources.ammo;
                ammo.SizeMode = PictureBoxSizeMode.AutoSize;
                ammo.BackColor = Color.Transparent;
                ammo.Left = random.Next(10, 900);
                ammo.Top = random.Next(50, 480);
                ammo.Tag = "ammo";

                 
                this.Controls.Add(ammo);
                playerController.BringToFront();
            }
        }

         
        private void shootMain(string direction)
        {
            bullet shoot = new bullet();
            shoot.direction = direction;
            shoot.bulletLeft = playerController.Left + (playerController.Width / 2);
            shoot.bulletTop = playerController.Top + (playerController.Height / 2);
            shoot.spawnBullets(this);
        }

        
        private void spawnRobots()
        {
            PictureBox robots = new PictureBox();
            robots.Tag = "robot";
            robots.Image = Properties.Resources.rl;
            robots.Left = random.Next(0, 900);
            robots.Top = random.Next(0, 800);
            robots.SizeMode = PictureBoxSizeMode.AutoSize;
            robots.BackColor = Color.Transparent;
            this.Controls.Add(robots);
            playerController.BringToFront();
            robots.BringToFront();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            gameStart.Stop();
            backgroundPause.BringToFront();
            backgroundPause.Visible = true;
        }

        private void playPause_Click(object sender, EventArgs e)
        {
            gameStart.Start();
            backgroundPause.Visible = false;
        }

        private void backPause_Click(object sender, EventArgs e)
        {
            Sub_Menu sub = new Sub_Menu();
            sub.Show();
            this.Hide();
        }
    }
}
