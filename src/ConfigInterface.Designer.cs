namespace PuyoPuyo
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxCombi = new System.Windows.Forms.TextBox();
            this.BoxDrop = new System.Windows.Forms.TextBox();
            this.BoxCol = new System.Windows.Forms.TextBox();
            this.BoxRow = new System.Windows.Forms.TextBox();
            this.BoxPos = new System.Windows.Forms.TextBox();
            this.confirmation = new System.Windows.Forms.Button();
            this.Reinitialiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nb de piece a combiner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "vitesse de chute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "nb de colonnes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "nb de lignes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "position intiale de la piece";
            // 
            // BoxCombi
            // 
            this.BoxCombi.Location = new System.Drawing.Point(181, 35);
            this.BoxCombi.Name = "BoxCombi";
            this.BoxCombi.Size = new System.Drawing.Size(100, 20);
            this.BoxCombi.TabIndex = 5;
            this.BoxCombi.Leave += new System.EventHandler(this.comboVerif);
            // 
            // BoxDrop
            // 
            this.BoxDrop.Location = new System.Drawing.Point(181, 120);
            this.BoxDrop.Name = "BoxDrop";
            this.BoxDrop.Size = new System.Drawing.Size(100, 20);
            this.BoxDrop.TabIndex = 6;
            this.BoxDrop.Leave += new System.EventHandler(this.dropVerif);
            // 
            // BoxCol
            // 
            this.BoxCol.Location = new System.Drawing.Point(181, 205);
            this.BoxCol.Name = "BoxCol";
            this.BoxCol.Size = new System.Drawing.Size(100, 20);
            this.BoxCol.TabIndex = 7;
            this.BoxCol.Leave += new System.EventHandler(this.colVerif);
            // 
            // BoxRow
            // 
            this.BoxRow.Location = new System.Drawing.Point(181, 292);
            this.BoxRow.Name = "BoxRow";
            this.BoxRow.Size = new System.Drawing.Size(100, 20);
            this.BoxRow.TabIndex = 8;
            this.BoxRow.Leave += new System.EventHandler(this.rowVerif);
            // 
            // BoxPos
            // 
            this.BoxPos.Location = new System.Drawing.Point(181, 376);
            this.BoxPos.Name = "BoxPos";
            this.BoxPos.Size = new System.Drawing.Size(100, 20);
            this.BoxPos.TabIndex = 9;
            this.BoxPos.Leave += new System.EventHandler(this.posVerif);
            // 
            // confirmation
            // 
            this.confirmation.Location = new System.Drawing.Point(58, 415);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(75, 23);
            this.confirmation.TabIndex = 10;
            this.confirmation.Text = "Confirmer";
            this.confirmation.UseVisualStyleBackColor = true;
            this.confirmation.Click += new System.EventHandler(this.confirmation_Click);
            // 
            // Reinitialiser
            // 
            this.Reinitialiser.Location = new System.Drawing.Point(256, 415);
            this.Reinitialiser.Name = "Reinitialiser";
            this.Reinitialiser.Size = new System.Drawing.Size(75, 23);
            this.Reinitialiser.TabIndex = 11;
            this.Reinitialiser.Text = "Reinitialiser";
            this.Reinitialiser.UseVisualStyleBackColor = true;
            this.Reinitialiser.Click += new System.EventHandler(this.Reinitialiser_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.Reinitialiser);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.BoxPos);
            this.Controls.Add(this.BoxRow);
            this.Controls.Add(this.BoxCol);
            this.Controls.Add(this.BoxDrop);
            this.Controls.Add(this.BoxCombi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxCombi;
        private System.Windows.Forms.TextBox BoxDrop;
        private System.Windows.Forms.TextBox BoxCol;
        private System.Windows.Forms.TextBox BoxRow;
        private System.Windows.Forms.TextBox BoxPos;
        private System.Windows.Forms.Button confirmation;
        private System.Windows.Forms.Button Reinitialiser;
    }
}