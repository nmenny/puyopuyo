namespace PuyoPuyo
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.AfficherScore = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.pieceDeux = new System.Windows.Forms.Panel();
            this.pieceTrois = new System.Windows.Forms.Panel();
            this.EcranJeu = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.temps = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.secondes = new System.Windows.Forms.Label();
            this.Timer_time = new System.Windows.Forms.Timer(this.components);
            this.affichageControles = new System.Windows.Forms.Label();
            this.commencer = new System.Windows.Forms.Button();
            this.Reglage = new System.Windows.Forms.Button();
            this.Timer_secret = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(262, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 544);
            this.label1.TabIndex = 0;
            // 
            // AfficherScore
            // 
            this.AfficherScore.AutoSize = true;
            this.AfficherScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficherScore.Location = new System.Drawing.Point(278, 497);
            this.AfficherScore.Name = "AfficherScore";
            this.AfficherScore.Size = new System.Drawing.Size(41, 15);
            this.AfficherScore.TabIndex = 1;
            this.AfficherScore.Text = "Score";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(325, 497);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(13, 13);
            this.points.TabIndex = 2;
            this.points.Text = "0";
            // 
            // pieceDeux
            // 
            this.pieceDeux.Location = new System.Drawing.Point(278, 48);
            this.pieceDeux.Name = "pieceDeux";
            this.pieceDeux.Size = new System.Drawing.Size(41, 83);
            this.pieceDeux.TabIndex = 4;
            this.pieceDeux.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPieceDeux);
            // 
            // pieceTrois
            // 
            this.pieceTrois.Location = new System.Drawing.Point(328, 48);
            this.pieceTrois.Name = "pieceTrois";
            this.pieceTrois.Size = new System.Drawing.Size(41, 83);
            this.pieceTrois.TabIndex = 5;
            this.pieceTrois.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPieceTrois);
            // 
            // EcranJeu
            // 
            this.EcranJeu.Location = new System.Drawing.Point(1, 12);
            this.EcranJeu.Name = "EcranJeu";
            this.EcranJeu.Size = new System.Drawing.Size(255, 515);
            this.EcranJeu.TabIndex = 6;
            this.EcranJeu.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBackground);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.refreshProgram);
            // 
            // temps
            // 
            this.temps.AutoSize = true;
            this.temps.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temps.Location = new System.Drawing.Point(278, 472);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(45, 15);
            this.temps.TabIndex = 7;
            this.temps.Text = "Temps";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Location = new System.Drawing.Point(325, 474);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(19, 13);
            this.minutes.TabIndex = 8;
            this.minutes.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            // 
            // secondes
            // 
            this.secondes.AutoSize = true;
            this.secondes.Location = new System.Drawing.Point(359, 474);
            this.secondes.Name = "secondes";
            this.secondes.Size = new System.Drawing.Size(19, 13);
            this.secondes.TabIndex = 10;
            this.secondes.Text = "00";
            // 
            // Timer_time
            // 
            this.Timer_time.Interval = 1000;
            this.Timer_time.Tick += new System.EventHandler(this.clock);
            // 
            // affichageControles
            // 
            this.affichageControles.AutoSize = true;
            this.affichageControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.affichageControles.Location = new System.Drawing.Point(278, 157);
            this.affichageControles.Name = "affichageControles";
            this.affichageControles.Size = new System.Drawing.Size(312, 85);
            this.affichageControles.TabIndex = 11;
            this.affichageControles.Text = resources.GetString("affichageControles.Text");
            // 
            // commencer
            // 
            this.commencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.commencer.Location = new System.Drawing.Point(362, 323);
            this.commencer.Name = "commencer";
            this.commencer.Size = new System.Drawing.Size(112, 40);
            this.commencer.TabIndex = 12;
            this.commencer.Text = "Commencer";
            this.commencer.UseVisualStyleBackColor = true;
            this.commencer.Click += new System.EventHandler(this.commencer_Click);
            // 
            // Reglage
            // 
            this.Reglage.Location = new System.Drawing.Point(515, 12);
            this.Reglage.Name = "Reglage";
            this.Reglage.Size = new System.Drawing.Size(75, 23);
            this.Reglage.TabIndex = 13;
            this.Reglage.Text = "Options";
            this.Reglage.UseVisualStyleBackColor = true;
            this.Reglage.Click += new System.EventHandler(this.Reglage_Click);
            // 
            // Timer_secret
            // 
            this.Timer_secret.Interval = 250;
            this.Timer_secret.Tick += new System.EventHandler(this.Timer_secret_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 532);
            this.Controls.Add(this.Reglage);
            this.Controls.Add(this.commencer);
            this.Controls.Add(this.affichageControles);
            this.Controls.Add(this.secondes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.EcranJeu);
            this.Controls.Add(this.pieceTrois);
            this.Controls.Add(this.pieceDeux);
            this.Controls.Add(this.points);
            this.Controls.Add(this.AfficherScore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Puyo Puyo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label AfficherScore;
        private System.Windows.Forms.Panel pieceTrois;
        private System.Windows.Forms.Panel pieceDeux;
        private System.Windows.Forms.Panel EcranJeu;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label temps;
        private System.Windows.Forms.Label secondes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Timer Timer_time;
        private System.Windows.Forms.Button commencer;
        private System.Windows.Forms.Label affichageControles;
        private System.Windows.Forms.Button Reglage;
        private System.Windows.Forms.Timer Timer_secret;
    }
}

