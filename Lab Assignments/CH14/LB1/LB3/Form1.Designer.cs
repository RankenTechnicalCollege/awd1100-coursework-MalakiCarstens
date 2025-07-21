namespace LB3
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
            this.btnNextCard = new System.Windows.Forms.Button();
            this.lblPokemonName = new System.Windows.Forms.Label();
            this.pbCardDisplay = new System.Windows.Forms.PictureBox();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextCard
            // 
            this.btnNextCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextCard.Location = new System.Drawing.Point(420, 598);
            this.btnNextCard.Name = "btnNextCard";
            this.btnNextCard.Size = new System.Drawing.Size(119, 38);
            this.btnNextCard.TabIndex = 1;
            this.btnNextCard.Text = "Next Card";
            this.btnNextCard.UseVisualStyleBackColor = true;
            this.btnNextCard.Click += new System.EventHandler(this.btnNextCard_Click);
            // 
            // lblPokemonName
            // 
            this.lblPokemonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokemonName.ForeColor = System.Drawing.Color.White;
            this.lblPokemonName.Location = new System.Drawing.Point(322, 502);
            this.lblPokemonName.Name = "lblPokemonName";
            this.lblPokemonName.Size = new System.Drawing.Size(323, 60);
            this.lblPokemonName.TabIndex = 2;
            // 
            // pbCardDisplay
            // 
            this.pbCardDisplay.Location = new System.Drawing.Point(322, 40);
            this.pbCardDisplay.Name = "pbCardDisplay";
            this.pbCardDisplay.Size = new System.Drawing.Size(323, 447);
            this.pbCardDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardDisplay.TabIndex = 3;
            this.pbCardDisplay.TabStop = false;
            this.pbCardDisplay.Visible = false;
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.White;
            this.lblResults.Location = new System.Drawing.Point(12, 664);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(959, 47);
            this.lblResults.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(983, 720);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pbCardDisplay);
            this.Controls.Add(this.lblPokemonName);
            this.Controls.Add(this.btnNextCard);
            this.Name = "Form1";
            this.Text = "Booster Pack";
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNextCard;
        private System.Windows.Forms.Label lblPokemonName;
        private System.Windows.Forms.PictureBox pbCardDisplay;
        private System.Windows.Forms.Label lblResults;
    }
}

