namespace GrafikaBeadando2d
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerBackground = new System.Windows.Forms.Timer(this.components);
            this.timerLeftMove = new System.Windows.Forms.Timer(this.components);
            this.timerRightMove = new System.Windows.Forms.Timer(this.components);
            this.timerUpMove = new System.Windows.Forms.Timer(this.components);
            this.timerDownMove = new System.Windows.Forms.Timer(this.components);
            this.timerFalconShot = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyShot = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.label_StartGame = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.Falcon = new System.Windows.Forms.PictureBox();
            this.label_score = new System.Windows.Forms.Label();
            this.label_hp = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.timerJudge = new System.Windows.Forms.Timer(this.components);
            this.label_GameOver = new System.Windows.Forms.Label();
            this.label_Paused = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Falcon)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBackground
            // 
            this.timerBackground.Interval = 10;
            this.timerBackground.Tick += new System.EventHandler(this.timerBackground_Tick);
            // 
            // timerLeftMove
            // 
            this.timerLeftMove.Interval = 5;
            this.timerLeftMove.Tick += new System.EventHandler(this.timerLeftMove_Tick);
            // 
            // timerRightMove
            // 
            this.timerRightMove.Interval = 5;
            this.timerRightMove.Tick += new System.EventHandler(this.timerRigthMove_Tick);
            // 
            // timerUpMove
            // 
            this.timerUpMove.Interval = 5;
            this.timerUpMove.Tick += new System.EventHandler(this.timerUpMove_Tick);
            // 
            // timerDownMove
            // 
            this.timerDownMove.Interval = 5;
            this.timerDownMove.Tick += new System.EventHandler(this.timerDownMove_Tick);
            // 
            // timerFalconShot
            // 
            this.timerFalconShot.Interval = 20;
            this.timerFalconShot.Tick += new System.EventHandler(this.timerFalconShot_Tick);
            // 
            // timerEnemyShot
            // 
            this.timerEnemyShot.Interval = 20;
            this.timerEnemyShot.Tick += new System.EventHandler(this.timerEnemyShot_Tick);
            // 
            // timerEnemyMove
            // 
            this.timerEnemyMove.Interval = 25;
            this.timerEnemyMove.Tick += new System.EventHandler(this.timerEnemyMove_Tick);
            // 
            // label_StartGame
            // 
            this.label_StartGame.AutoSize = true;
            this.label_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_StartGame.ForeColor = System.Drawing.Color.Gold;
            this.label_StartGame.Location = new System.Drawing.Point(156, 181);
            this.label_StartGame.Name = "label_StartGame";
            this.label_StartGame.Size = new System.Drawing.Size(99, 32);
            this.label_StartGame.TabIndex = 0;
            this.label_StartGame.Text = "label1";
            this.label_StartGame.Visible = false;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.BackColor = System.Drawing.Color.Transparent;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Description.ForeColor = System.Drawing.Color.Gold;
            this.label_Description.Location = new System.Drawing.Point(100, 242);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(70, 25);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "label1";
            this.label_Description.Visible = false;
            // 
            // Falcon
            // 
            this.Falcon.Image = global::GrafikaBeadando2d.Properties.Resources.falcon;
            this.Falcon.Location = new System.Drawing.Point(260, 400);
            this.Falcon.Name = "Falcon";
            this.Falcon.Size = new System.Drawing.Size(50, 50);
            this.Falcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Falcon.TabIndex = 2;
            this.Falcon.TabStop = false;
            this.Falcon.Visible = false;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_score.ForeColor = System.Drawing.Color.Gold;
            this.label_score.Location = new System.Drawing.Point(2, 1);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(53, 20);
            this.label_score.TabIndex = 3;
            this.label_score.Text = "label1";
            this.label_score.Visible = false;
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_hp.ForeColor = System.Drawing.Color.Gold;
            this.label_hp.Location = new System.Drawing.Point(257, 1);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(53, 20);
            this.label_hp.TabIndex = 4;
            this.label_hp.Text = "label2";
            this.label_hp.Visible = false;
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.BackColor = System.Drawing.Color.Transparent;
            this.label_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_level.ForeColor = System.Drawing.Color.Gold;
            this.label_level.Location = new System.Drawing.Point(500, 7);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(53, 20);
            this.label_level.TabIndex = 5;
            this.label_level.Text = "label3";
            this.label_level.Visible = false;
            // 
            // timerJudge
            // 
            this.timerJudge.Interval = 10;
            this.timerJudge.Tick += new System.EventHandler(this.timerJudge_Tick);
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.label_GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_GameOver.ForeColor = System.Drawing.Color.Red;
            this.label_GameOver.Location = new System.Drawing.Point(115, 292);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(79, 29);
            this.label_GameOver.TabIndex = 6;
            this.label_GameOver.Text = "label1";
            this.label_GameOver.Visible = false;
            // 
            // label_Paused
            // 
            this.label_Paused.AutoSize = true;
            this.label_Paused.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Paused.ForeColor = System.Drawing.Color.Gold;
            this.label_Paused.Location = new System.Drawing.Point(64, 210);
            this.label_Paused.Name = "label_Paused";
            this.label_Paused.Size = new System.Drawing.Size(458, 32);
            this.label_Paused.TabIndex = 7;
            this.label_Paused.Text = "Paused, Press Enter to Contunie";
            this.label_Paused.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.label_Paused);
            this.Controls.Add(this.label_GameOver);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_hp);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.Falcon);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_StartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Falcon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Falcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerBackground;
        private System.Windows.Forms.Timer timerLeftMove;
        private System.Windows.Forms.Timer timerRightMove;
        private System.Windows.Forms.Timer timerUpMove;
        private System.Windows.Forms.Timer timerDownMove;
        private System.Windows.Forms.Timer timerFalconShot;
        private System.Windows.Forms.Timer timerEnemyShot;
        private System.Windows.Forms.Timer timerEnemyMove;
        private System.Windows.Forms.Label label_StartGame;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.PictureBox Falcon;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Timer timerJudge;
        private System.Windows.Forms.Label label_GameOver;
        private System.Windows.Forms.Label label_Paused;
    }
}

