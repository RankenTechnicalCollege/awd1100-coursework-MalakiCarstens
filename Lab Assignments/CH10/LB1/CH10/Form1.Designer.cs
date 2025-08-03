namespace CH10
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
            this.cboHeroes = new System.Windows.Forms.ComboBox();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDislikes = new System.Windows.Forms.Label();
            this.lblSuperPower = new System.Windows.Forms.Label();
            this.lblBiography = new System.Windows.Forms.Label();
            this.pbHero = new System.Windows.Forms.PictureBox();
            this.lblHeroLink = new System.Windows.Forms.LinkLabel();
            this.lblHeroName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHeroes
            // 
            this.cboHeroes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeroes.FormattingEnabled = true;
            this.cboHeroes.Location = new System.Drawing.Point(61, 46);
            this.cboHeroes.Name = "cboHeroes";
            this.cboHeroes.Size = new System.Drawing.Size(261, 24);
            this.cboHeroes.TabIndex = 0;
            this.cboHeroes.SelectedIndexChanged += new System.EventHandler(this.cboHeroes_SelectedIndexChanged);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.Location = new System.Drawing.Point(53, 138);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(57, 22);
            this.lblLikes.TabIndex = 1;
            this.lblLikes.Text = "Likes:";
            // 
            // lblDislikes
            // 
            this.lblDislikes.AutoSize = true;
            this.lblDislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDislikes.Location = new System.Drawing.Point(53, 227);
            this.lblDislikes.Name = "lblDislikes";
            this.lblDislikes.Size = new System.Drawing.Size(77, 22);
            this.lblDislikes.TabIndex = 2;
            this.lblDislikes.Text = "Dislikes:";
            // 
            // lblSuperPower
            // 
            this.lblSuperPower.AutoSize = true;
            this.lblSuperPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperPower.Location = new System.Drawing.Point(58, 309);
            this.lblSuperPower.Name = "lblSuperPower";
            this.lblSuperPower.Size = new System.Drawing.Size(119, 22);
            this.lblSuperPower.TabIndex = 3;
            this.lblSuperPower.Text = "Super Power:";
            // 
            // lblBiography
            // 
            this.lblBiography.AutoSize = true;
            this.lblBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiography.Location = new System.Drawing.Point(53, 421);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(96, 22);
            this.lblBiography.TabIndex = 4;
            this.lblBiography.Text = "Biography:";
            // 
            // pbHero
            // 
            this.pbHero.Location = new System.Drawing.Point(528, 46);
            this.pbHero.Name = "pbHero";
            this.pbHero.Size = new System.Drawing.Size(255, 364);
            this.pbHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHero.TabIndex = 5;
            this.pbHero.TabStop = false;
            // 
            // lblHeroLink
            // 
            this.lblHeroLink.AutoSize = true;
            this.lblHeroLink.Location = new System.Drawing.Point(229, 551);
            this.lblHeroLink.Name = "lblHeroLink";
            this.lblHeroLink.Size = new System.Drawing.Size(0, 16);
            this.lblHeroLink.TabIndex = 6;
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroName.Location = new System.Drawing.Point(52, 98);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(0, 25);
            this.lblHeroName.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 593);
            this.Controls.Add(this.lblHeroName);
            this.Controls.Add(this.lblHeroLink);
            this.Controls.Add(this.pbHero);
            this.Controls.Add(this.lblBiography);
            this.Controls.Add(this.lblSuperPower);
            this.Controls.Add(this.lblDislikes);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.cboHeroes);
            this.Name = "Form1";
            this.Text = "X-Men Database";
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHeroes;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblDislikes;
        private System.Windows.Forms.Label lblSuperPower;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.PictureBox pbHero;
        private System.Windows.Forms.LinkLabel lblHeroLink;
        private System.Windows.Forms.Label lblHeroName;
    }
}

