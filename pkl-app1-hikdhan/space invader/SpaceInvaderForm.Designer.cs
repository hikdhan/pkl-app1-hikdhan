
namespace pkl_app1_hikdhan.space_invader
{
    partial class SpaceInvaderForm
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
            this.SpaceBoard = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ActorMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceBoard
            // 
            this.SpaceBoard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SpaceBoard.Location = new System.Drawing.Point(13, 14);
            this.SpaceBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpaceBoard.Name = "SpaceBoard";
            this.SpaceBoard.Size = new System.Drawing.Size(1200, 615);
            this.SpaceBoard.TabIndex = 1;
            this.SpaceBoard.TabStop = false;
            this.SpaceBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceBoard_Paint);
            // 
            // enemy1
            // 
            this.enemy1.BackgroundImage = global::pkl_app1_hikdhan.Properties.Resources.enemy1green1;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Location = new System.Drawing.Point(13, 690);
            this.enemy1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(60, 49);
            this.enemy1.TabIndex = 2;
            this.enemy1.TabStop = false;
            this.enemy1.Visible = false;
            // 
            // player
            // 
            this.player.BackgroundImage = global::pkl_app1_hikdhan.Properties.Resources.player;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(217, 690);
            this.player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 49);
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // enemy3
            // 
            this.enemy3.BackgroundImage = global::pkl_app1_hikdhan.Properties.Resources.enemy3pink;
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3.Location = new System.Drawing.Point(149, 690);
            this.enemy3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(60, 49);
            this.enemy3.TabIndex = 4;
            this.enemy3.TabStop = false;
            this.enemy3.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.BackgroundImage = global::pkl_app1_hikdhan.Properties.Resources.enemy2blue;
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Location = new System.Drawing.Point(81, 690);
            this.enemy2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(60, 49);
            this.enemy2.TabIndex = 5;
            this.enemy2.TabStop = false;
            this.enemy2.Visible = false;
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
            // SpaceInvaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 753);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.SpaceBoard);
            this.Name = "SpaceInvaderForm";
            this.Text = "SpaceInvaderForm";
            this.Load += new System.EventHandler(this.SpaceInvaderForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaderForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaderForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SpaceInvaderForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
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
    }
}