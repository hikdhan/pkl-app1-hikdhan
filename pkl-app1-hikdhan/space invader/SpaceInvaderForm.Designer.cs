
namespace pkl_app1_hikdhan.space_invader
{
    partial class background
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
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ActorMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruActorTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemyTembakTimer = new System.Windows.Forms.Timer(this.components);
            this.pelorenemy = new System.Windows.Forms.PictureBox();
            this.latarbelakang = new System.Windows.Forms.PictureBox();
            this.meledak = new System.Windows.Forms.PictureBox();
            this.pelor = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.SpaceBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pelorenemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latarbelakang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meledak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 500;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick);
            // 
            // ActorMoveTimer
            // 
            this.ActorMoveTimer.Enabled = true;
            this.ActorMoveTimer.Interval = 50;
            this.ActorMoveTimer.Tick += new System.EventHandler(this.ActorMoveTimer_Tick);
            // 
            // PeluruActorTimer
            // 
            this.PeluruActorTimer.Enabled = true;
            this.PeluruActorTimer.Interval = 1;
            this.PeluruActorTimer.Tick += new System.EventHandler(this.PeluruActorTimer_Tick);
            // 
            // PeluruEnemyMoveTimer
            // 
            this.PeluruEnemyMoveTimer.Enabled = true;
            this.PeluruEnemyMoveTimer.Interval = 200;
            this.PeluruEnemyMoveTimer.Tick += new System.EventHandler(this.PeluruEnemyMoveTimer_Tick);
            // 
            // PeluruEnemyTembakTimer
            // 
            this.PeluruEnemyTembakTimer.Enabled = true;
            this.PeluruEnemyTembakTimer.Interval = 4000;
            this.PeluruEnemyTembakTimer.Tick += new System.EventHandler(this.PeluruEnemyTembakTimer_Tick);
            // 
            // pelorenemy
            // 
            this.pelorenemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pelorenemy.Image = global::pkl_app1_hikdhan.Properties.Resources.enemyBullet;
            this.pelorenemy.Location = new System.Drawing.Point(546, 665);
            this.pelorenemy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pelorenemy.Name = "pelorenemy";
            this.pelorenemy.Size = new System.Drawing.Size(71, 74);
            this.pelorenemy.TabIndex = 9;
            this.pelorenemy.TabStop = false;
            this.pelorenemy.Visible = false;
            // 
            // latarbelakang
            // 
            this.latarbelakang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.latarbelakang.Image = global::pkl_app1_hikdhan.Properties.Resources.Outer_Space_Desktop_Backgrounds___Wallpaper_Cave;
            this.latarbelakang.Location = new System.Drawing.Point(467, 665);
            this.latarbelakang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latarbelakang.Name = "latarbelakang";
            this.latarbelakang.Size = new System.Drawing.Size(71, 74);
            this.latarbelakang.TabIndex = 8;
            this.latarbelakang.TabStop = false;
            this.latarbelakang.Visible = false;
            // 
            // meledak
            // 
            this.meledak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.meledak.Image = global::pkl_app1_hikdhan.Properties.Resources.pngwing_com__2_;
            this.meledak.Location = new System.Drawing.Point(388, 665);
            this.meledak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meledak.Name = "meledak";
            this.meledak.Size = new System.Drawing.Size(71, 74);
            this.meledak.TabIndex = 7;
            this.meledak.TabStop = false;
            this.meledak.Visible = false;
            // 
            // pelor
            // 
            this.pelor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pelor.Image = global::pkl_app1_hikdhan.Properties.Resources.pelor;
            this.pelor.Location = new System.Drawing.Point(309, 665);
            this.pelor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pelor.Name = "pelor";
            this.pelor.Size = new System.Drawing.Size(71, 74);
            this.pelor.TabIndex = 6;
            this.pelor.TabStop = false;
            this.pelor.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Image = global::pkl_app1_hikdhan.Properties.Resources.enemy2;
            this.enemy2.Location = new System.Drawing.Point(81, 665);
            this.enemy2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(60, 74);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 5;
            this.enemy2.TabStop = false;
            this.enemy2.Visible = false;
            // 
            // enemy3
            // 
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3.Image = global::pkl_app1_hikdhan.Properties.Resources.enemy3;
            this.enemy3.Location = new System.Drawing.Point(149, 665);
            this.enemy3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(73, 74);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 4;
            this.enemy3.TabStop = false;
            this.enemy3.Visible = false;
            // 
            // player
            // 
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Image = global::pkl_app1_hikdhan.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(230, 665);
            this.player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 74);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Image = global::pkl_app1_hikdhan.Properties.Resources.enemy1;
            this.enemy1.Location = new System.Drawing.Point(13, 665);
            this.enemy1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(60, 74);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 2;
            this.enemy1.TabStop = false;
            this.enemy1.Visible = false;
            // 
            // SpaceBoard
            // 
            this.SpaceBoard.BackColor = System.Drawing.Color.Black;
            this.SpaceBoard.Location = new System.Drawing.Point(13, 14);
            this.SpaceBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpaceBoard.Name = "SpaceBoard";
            this.SpaceBoard.Size = new System.Drawing.Size(1200, 615);
            this.SpaceBoard.TabIndex = 1;
            this.SpaceBoard.TabStop = false;
            this.SpaceBoard.Click += new System.EventHandler(this.SpaceBoard_Click);
            this.SpaceBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceBoard_Paint);
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 753);
            this.Controls.Add(this.pelorenemy);
            this.Controls.Add(this.latarbelakang);
            this.Controls.Add(this.meledak);
            this.Controls.Add(this.pelor);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.SpaceBoard);
            this.Name = "background";
            this.Text = "SpaceInvaderForm";
            this.Load += new System.EventHandler(this.SpaceInvaderForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaderForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaderForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SpaceInvaderForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pelorenemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latarbelakang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meledak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceBoard;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Timer EnemyMoveTimer;
        private System.Windows.Forms.Timer ActorMoveTimer;
        private System.Windows.Forms.PictureBox pelor;
        private System.Windows.Forms.Timer PeluruActorTimer;
        private System.Windows.Forms.PictureBox meledak;
        private System.Windows.Forms.PictureBox latarbelakang;
        private System.Windows.Forms.PictureBox pelorenemy;
        private System.Windows.Forms.Timer PeluruEnemyMoveTimer;
        private System.Windows.Forms.Timer PeluruEnemyTembakTimer;
    }
}