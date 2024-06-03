namespace ITEC_103_ROSAL___MAKASAYAN
{
    partial class Robo
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
            this.progressHealth = new System.Windows.Forms.ProgressBar();
            this.textKills = new System.Windows.Forms.Label();
            this.textAmmo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameStart = new System.Windows.Forms.Timer(this.components);
            this.backgroundPause = new DevExpress.XtraEditors.PanelControl();
            this.backPause = new System.Windows.Forms.PictureBox();
            this.playPause = new System.Windows.Forms.PictureBox();
            this.pauseLabel = new DevExpress.XtraEditors.LabelControl();
            this.pauseButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.robotController = new System.Windows.Forms.PictureBox();
            this.playerController = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerController)).BeginInit();
            this.SuspendLayout();
            // 
            // progressHealth
            // 
            this.progressHealth.Location = new System.Drawing.Point(125, 15);
            this.progressHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressHealth.Name = "progressHealth";
            this.progressHealth.Size = new System.Drawing.Size(173, 28);
            this.progressHealth.TabIndex = 11;
            this.progressHealth.Value = 100;
            // 
            // textKills
            // 
            this.textKills.AutoSize = true;
            this.textKills.BackColor = System.Drawing.Color.Transparent;
            this.textKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textKills.ForeColor = System.Drawing.Color.White;
            this.textKills.Location = new System.Drawing.Point(861, 15);
            this.textKills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textKills.Name = "textKills";
            this.textKills.Size = new System.Drawing.Size(29, 31);
            this.textKills.TabIndex = 10;
            this.textKills.Text = "0";
            // 
            // textAmmo
            // 
            this.textAmmo.AutoSize = true;
            this.textAmmo.BackColor = System.Drawing.Color.Transparent;
            this.textAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textAmmo.ForeColor = System.Drawing.Color.White;
            this.textAmmo.Location = new System.Drawing.Point(536, 15);
            this.textAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textAmmo.Name = "textAmmo";
            this.textAmmo.Size = new System.Drawing.Size(29, 31);
            this.textAmmo.TabIndex = 9;
            this.textAmmo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(677, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Annihilations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Health:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ammo: ";
            // 
            // gameStart
            // 
            this.gameStart.Enabled = true;
            this.gameStart.Interval = 10;
            this.gameStart.Tick += new System.EventHandler(this.gameStartEvent);
            // 
            // backgroundPause
            // 
            this.backgroundPause.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backgroundPause.Appearance.Options.UseBackColor = true;
            this.backgroundPause.Controls.Add(this.backPause);
            this.backgroundPause.Controls.Add(this.playPause);
            this.backgroundPause.Controls.Add(this.pauseLabel);
            this.backgroundPause.Location = new System.Drawing.Point(468, 102);
            this.backgroundPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backgroundPause.Name = "backgroundPause";
            this.backgroundPause.Size = new System.Drawing.Size(351, 437);
            this.backgroundPause.TabIndex = 16;
            this.backgroundPause.Visible = false;
            // 
            // backPause
            // 
            this.backPause.BackColor = System.Drawing.Color.Gray;
            this.backPause.Image = global::ITEC_103_ROSAL___MAKASAYAN.Properties.Resources.Back3;
            this.backPause.Location = new System.Drawing.Point(63, 272);
            this.backPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPause.Name = "backPause";
            this.backPause.Size = new System.Drawing.Size(224, 146);
            this.backPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPause.TabIndex = 2;
            this.backPause.TabStop = false;
            this.backPause.Click += new System.EventHandler(this.backPause_Click);
            // 
            // playPause
            // 
            this.playPause.Image = global::ITEC_103_ROSAL___MAKASAYAN.Properties.Resources.Start_11;
            this.playPause.Location = new System.Drawing.Point(63, 92);
            this.playPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(224, 146);
            this.playPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playPause.TabIndex = 1;
            this.playPause.TabStop = false;
            this.playPause.Click += new System.EventHandler(this.playPause_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.Appearance.Options.UseFont = true;
            this.pauseLabel.Location = new System.Drawing.Point(95, 22);
            this.pauseLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(147, 53);
            this.pauseLabel.TabIndex = 0;
            this.pauseLabel.Text = "PAUSE";
            // 
            // pauseButton
            // 
            this.pauseButton.Image = global::ITEC_103_ROSAL___MAKASAYAN.Properties.Resources.pause_icon;
            this.pauseButton.InitialImage = global::ITEC_103_ROSAL___MAKASAYAN.Properties.Resources.pause_icon;
            this.pauseButton.Location = new System.Drawing.Point(1143, 8);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(49, 40);
            this.pauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseButton.TabIndex = 15;
            this.pauseButton.TabStop = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITEC_103_ROSAL___MAKASAYAN.Properties.Resources.rl;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 393);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "robot";
            // 
            // robotController
            // 
            this.robotController.Image = global::ITEC_103_ROSAL___MAKASAYAN.Properties.Resources.rl;
            this.robotController.Location = new System.Drawing.Point(800, 160);
            this.robotController.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.robotController.Name = "robotController";
            this.robotController.Size = new System.Drawing.Size(49, 43);
            this.robotController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.robotController.TabIndex = 13;
            this.robotController.TabStop = false;
            this.robotController.Tag = "robot";
            // 
            // playerController
            // 
            this.playerController.BackColor = System.Drawing.Color.Transparent;
            this.playerController.Image = global::ITEC_103_ROSAL___MAKASAYAN.Properties.Resources.mr;
            this.playerController.Location = new System.Drawing.Point(145, 263);
            this.playerController.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerController.Name = "playerController";
            this.playerController.Size = new System.Drawing.Size(49, 43);
            this.playerController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerController.TabIndex = 12;
            this.playerController.TabStop = false;
            this.playerController.Tag = "player";
            // 
            // Robo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1216, 607);
            this.Controls.Add(this.backgroundPause);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.robotController);
            this.Controls.Add(this.playerController);
            this.Controls.Add(this.progressHealth);
            this.Controls.Add(this.textKills);
            this.Controls.Add(this.textAmmo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Robo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressHealth;
        private System.Windows.Forms.Label textKills;
        private System.Windows.Forms.Label textAmmo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox robotController;
        private System.Windows.Forms.PictureBox playerController;
        private System.Windows.Forms.Timer gameStart;
        private System.Windows.Forms.PictureBox pauseButton;
        private DevExpress.XtraEditors.PanelControl backgroundPause;
        private DevExpress.XtraEditors.LabelControl pauseLabel;
        private System.Windows.Forms.PictureBox playPause;
        private System.Windows.Forms.PictureBox backPause;
    }
}