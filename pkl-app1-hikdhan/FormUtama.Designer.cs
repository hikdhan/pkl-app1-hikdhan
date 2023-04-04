
namespace pkl_app1_hikdhan
{
    partial class FormUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.latihanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitungumurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sequentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tUGASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percabanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latihanToolStripMenuItem,
            this.tUGASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // latihanToolStripMenuItem
            // 
            this.latihanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringNamaToolStripMenuItem,
            this.numerikToolStripMenuItem,
            this.hitungumurToolStripMenuItem,
            this.sequentialToolStripMenuItem,
            this.percabanganToolStripMenuItem});
            this.latihanToolStripMenuItem.Name = "latihanToolStripMenuItem";
            this.latihanToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.latihanToolStripMenuItem.Text = "Latihan";
            // 
            // stringNamaToolStripMenuItem
            // 
            this.stringNamaToolStripMenuItem.Name = "stringNamaToolStripMenuItem";
            this.stringNamaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.stringNamaToolStripMenuItem.Text = "String Nama";
            this.stringNamaToolStripMenuItem.Click += new System.EventHandler(this.stringNamaToolStripMenuItem_Click);
            // 
            // numerikToolStripMenuItem
            // 
            this.numerikToolStripMenuItem.Name = "numerikToolStripMenuItem";
            this.numerikToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.numerikToolStripMenuItem.Text = "Numerik";
            this.numerikToolStripMenuItem.Click += new System.EventHandler(this.numerikToolStripMenuItem_Click);
            // 
            // hitungumurToolStripMenuItem
            // 
            this.hitungumurToolStripMenuItem.Name = "hitungumurToolStripMenuItem";
            this.hitungumurToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hitungumurToolStripMenuItem.Text = "hitungumur";
            this.hitungumurToolStripMenuItem.Click += new System.EventHandler(this.hitungumurToolStripMenuItem_Click);
            // 
            // sequentialToolStripMenuItem
            // 
            this.sequentialToolStripMenuItem.Name = "sequentialToolStripMenuItem";
            this.sequentialToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sequentialToolStripMenuItem.Text = "sequential";
            this.sequentialToolStripMenuItem.Click += new System.EventHandler(this.sequentialToolStripMenuItem_Click);
            // 
            // tUGASToolStripMenuItem
            // 
            this.tUGASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalkulatorToolStripMenuItem});
            this.tUGASToolStripMenuItem.Name = "tUGASToolStripMenuItem";
            this.tUGASToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.tUGASToolStripMenuItem.Text = "TUGAS";
            // 
            // kalkulatorToolStripMenuItem
            // 
            this.kalkulatorToolStripMenuItem.Name = "kalkulatorToolStripMenuItem";
            this.kalkulatorToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.kalkulatorToolStripMenuItem.Text = "kalkulator";
            this.kalkulatorToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorToolStripMenuItem_Click);
            // 
            // percabanganToolStripMenuItem
            // 
            this.percabanganToolStripMenuItem.Name = "percabanganToolStripMenuItem";
            this.percabanganToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.percabanganToolStripMenuItem.Text = "percabangan";
            this.percabanganToolStripMenuItem.Click += new System.EventHandler(this.percabanganToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem latihanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringNamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hitungumurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tUGASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sequentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percabanganToolStripMenuItem;
    }
}