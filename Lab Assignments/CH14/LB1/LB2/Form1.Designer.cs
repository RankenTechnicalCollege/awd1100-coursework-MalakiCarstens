namespace LB2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFramed = new System.Windows.Forms.RadioButton();
            this.rdbMatted = new System.Windows.Forms.RadioButton();
            this.rdbUnframed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbPine = new System.Windows.Forms.RadioButton();
            this.rdbOak = new System.Windows.Forms.RadioButton();
            this.rdbSteel = new System.Windows.Forms.RadioButton();
            this.rdbSilver = new System.Windows.Forms.RadioButton();
            this.rdbGold = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbAntique = new System.Windows.Forms.RadioButton();
            this.rdbVintage = new System.Windows.Forms.RadioButton();
            this.rdbEclectic = new System.Windows.Forms.RadioButton();
            this.rdbSimple = new System.Windows.Forms.RadioButton();
            this.rdbModern = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width (in)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height (in)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(157, 34);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(152, 22);
            this.txtWidth.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(157, 82);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(152, 22);
            this.txtHeight.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFramed);
            this.groupBox1.Controls.Add(this.rdbMatted);
            this.groupBox1.Controls.Add(this.rdbUnframed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // rdbFramed
            // 
            this.rdbFramed.AutoSize = true;
            this.rdbFramed.Location = new System.Drawing.Point(23, 102);
            this.rdbFramed.Name = "rdbFramed";
            this.rdbFramed.Size = new System.Drawing.Size(92, 26);
            this.rdbFramed.TabIndex = 10;
            this.rdbFramed.TabStop = true;
            this.rdbFramed.Text = "Framed";
            this.rdbFramed.UseVisualStyleBackColor = true;
            // 
            // rdbMatted
            // 
            this.rdbMatted.AutoSize = true;
            this.rdbMatted.Location = new System.Drawing.Point(23, 70);
            this.rdbMatted.Name = "rdbMatted";
            this.rdbMatted.Size = new System.Drawing.Size(85, 26);
            this.rdbMatted.TabIndex = 9;
            this.rdbMatted.TabStop = true;
            this.rdbMatted.Text = "Matted";
            this.rdbMatted.UseVisualStyleBackColor = true;
            // 
            // rdbUnframed
            // 
            this.rdbUnframed.AutoSize = true;
            this.rdbUnframed.Location = new System.Drawing.Point(23, 38);
            this.rdbUnframed.Name = "rdbUnframed";
            this.rdbUnframed.Size = new System.Drawing.Size(109, 26);
            this.rdbUnframed.TabIndex = 8;
            this.rdbUnframed.TabStop = true;
            this.rdbUnframed.Text = "Unframed";
            this.rdbUnframed.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbBlack);
            this.groupBox2.Controls.Add(this.rdbRed);
            this.groupBox2.Controls.Add(this.rdbGreen);
            this.groupBox2.Controls.Add(this.rdbBlue);
            this.groupBox2.Controls.Add(this.rdbWhite);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 208);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(19, 37);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(75, 26);
            this.rdbBlack.TabIndex = 11;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(19, 69);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(64, 26);
            this.rdbRed.TabIndex = 12;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(19, 101);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(81, 26);
            this.rdbGreen.TabIndex = 13;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(19, 133);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(67, 26);
            this.rdbBlue.TabIndex = 14;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(19, 162);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(77, 26);
            this.rdbWhite.TabIndex = 15;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbPine);
            this.groupBox3.Controls.Add(this.rdbOak);
            this.groupBox3.Controls.Add(this.rdbSteel);
            this.groupBox3.Controls.Add(this.rdbSilver);
            this.groupBox3.Controls.Add(this.rdbGold);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(284, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 208);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Material";
            // 
            // rdbPine
            // 
            this.rdbPine.AutoSize = true;
            this.rdbPine.Location = new System.Drawing.Point(6, 37);
            this.rdbPine.Name = "rdbPine";
            this.rdbPine.Size = new System.Drawing.Size(67, 26);
            this.rdbPine.TabIndex = 8;
            this.rdbPine.Text = "Pine";
            this.rdbPine.UseVisualStyleBackColor = true;
            // 
            // rdbOak
            // 
            this.rdbOak.AutoSize = true;
            this.rdbOak.Location = new System.Drawing.Point(6, 69);
            this.rdbOak.Name = "rdbOak";
            this.rdbOak.Size = new System.Drawing.Size(64, 26);
            this.rdbOak.TabIndex = 9;
            this.rdbOak.TabStop = true;
            this.rdbOak.Text = "Oak";
            this.rdbOak.UseVisualStyleBackColor = true;
            // 
            // rdbSteel
            // 
            this.rdbSteel.AutoSize = true;
            this.rdbSteel.Location = new System.Drawing.Point(6, 101);
            this.rdbSteel.Name = "rdbSteel";
            this.rdbSteel.Size = new System.Drawing.Size(72, 26);
            this.rdbSteel.TabIndex = 10;
            this.rdbSteel.TabStop = true;
            this.rdbSteel.Text = "Steel";
            this.rdbSteel.UseVisualStyleBackColor = true;
            // 
            // rdbSilver
            // 
            this.rdbSilver.AutoSize = true;
            this.rdbSilver.Location = new System.Drawing.Point(6, 133);
            this.rdbSilver.Name = "rdbSilver";
            this.rdbSilver.Size = new System.Drawing.Size(76, 26);
            this.rdbSilver.TabIndex = 11;
            this.rdbSilver.TabStop = true;
            this.rdbSilver.Text = "Silver";
            this.rdbSilver.UseVisualStyleBackColor = true;
            // 
            // rdbGold
            // 
            this.rdbGold.AutoSize = true;
            this.rdbGold.Location = new System.Drawing.Point(6, 165);
            this.rdbGold.Name = "rdbGold";
            this.rdbGold.Size = new System.Drawing.Size(69, 26);
            this.rdbGold.TabIndex = 12;
            this.rdbGold.TabStop = true;
            this.rdbGold.Text = "Gold";
            this.rdbGold.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbAntique);
            this.groupBox4.Controls.Add(this.rdbVintage);
            this.groupBox4.Controls.Add(this.rdbEclectic);
            this.groupBox4.Controls.Add(this.rdbSimple);
            this.groupBox4.Controls.Add(this.rdbModern);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(529, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 208);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Style";
            // 
            // rdbAntique
            // 
            this.rdbAntique.AutoSize = true;
            this.rdbAntique.Location = new System.Drawing.Point(6, 101);
            this.rdbAntique.Name = "rdbAntique";
            this.rdbAntique.Size = new System.Drawing.Size(92, 26);
            this.rdbAntique.TabIndex = 8;
            this.rdbAntique.TabStop = true;
            this.rdbAntique.Text = "Antique";
            this.rdbAntique.UseVisualStyleBackColor = true;
            // 
            // rdbVintage
            // 
            this.rdbVintage.AutoSize = true;
            this.rdbVintage.Location = new System.Drawing.Point(6, 133);
            this.rdbVintage.Name = "rdbVintage";
            this.rdbVintage.Size = new System.Drawing.Size(92, 26);
            this.rdbVintage.TabIndex = 9;
            this.rdbVintage.TabStop = true;
            this.rdbVintage.Text = "Vintage";
            this.rdbVintage.UseVisualStyleBackColor = true;
            // 
            // rdbEclectic
            // 
            this.rdbEclectic.AutoSize = true;
            this.rdbEclectic.Location = new System.Drawing.Point(6, 165);
            this.rdbEclectic.Name = "rdbEclectic";
            this.rdbEclectic.Size = new System.Drawing.Size(93, 26);
            this.rdbEclectic.TabIndex = 10;
            this.rdbEclectic.TabStop = true;
            this.rdbEclectic.Text = "Eclectic";
            this.rdbEclectic.UseVisualStyleBackColor = true;
            // 
            // rdbSimple
            // 
            this.rdbSimple.AutoSize = true;
            this.rdbSimple.Location = new System.Drawing.Point(6, 37);
            this.rdbSimple.Name = "rdbSimple";
            this.rdbSimple.Size = new System.Drawing.Size(85, 26);
            this.rdbSimple.TabIndex = 8;
            this.rdbSimple.TabStop = true;
            this.rdbSimple.Text = "Simple";
            this.rdbSimple.UseVisualStyleBackColor = true;
            // 
            // rdbModern
            // 
            this.rdbModern.AutoSize = true;
            this.rdbModern.Location = new System.Drawing.Point(6, 69);
            this.rdbModern.Name = "rdbModern";
            this.rdbModern.Size = new System.Drawing.Size(91, 26);
            this.rdbModern.TabIndex = 9;
            this.rdbModern.TabStop = true;
            this.rdbModern.Text = "Modern";
            this.rdbModern.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(68, 551);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 42);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(55, 634);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(420, 24);
            this.lblResults.TabIndex = 6;
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(480, 542);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(259, 51);
            this.lblCost.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 687);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Photoshop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.RadioButton rdbUnframed;
        private System.Windows.Forms.RadioButton rdbFramed;
        private System.Windows.Forms.RadioButton rdbMatted;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbPine;
        private System.Windows.Forms.RadioButton rdbOak;
        private System.Windows.Forms.RadioButton rdbSteel;
        private System.Windows.Forms.RadioButton rdbSilver;
        private System.Windows.Forms.RadioButton rdbGold;
        private System.Windows.Forms.RadioButton rdbAntique;
        private System.Windows.Forms.RadioButton rdbVintage;
        private System.Windows.Forms.RadioButton rdbEclectic;
        private System.Windows.Forms.RadioButton rdbSimple;
        private System.Windows.Forms.RadioButton rdbModern;
    }
}

