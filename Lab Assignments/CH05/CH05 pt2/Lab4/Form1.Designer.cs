namespace Lab4
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnDanielle = new System.Windows.Forms.Button();
            this.btnEdward = new System.Windows.Forms.Button();
            this.btnFrancis = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Sales";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "How much was the sale?";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Who made the sale?";
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 215);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(723, 125);
            this.lblResults.TabIndex = 3;
            // 
            // btnDanielle
            // 
            this.btnDanielle.Location = new System.Drawing.Point(12, 163);
            this.btnDanielle.Name = "btnDanielle";
            this.btnDanielle.Size = new System.Drawing.Size(75, 23);
            this.btnDanielle.TabIndex = 4;
            this.btnDanielle.Text = "Danielle";
            this.btnDanielle.UseVisualStyleBackColor = true;
            this.btnDanielle.Click += new System.EventHandler(this.btnDanielle_Click);
            // 
            // btnEdward
            // 
            this.btnEdward.Location = new System.Drawing.Point(122, 163);
            this.btnEdward.Name = "btnEdward";
            this.btnEdward.Size = new System.Drawing.Size(75, 23);
            this.btnEdward.TabIndex = 5;
            this.btnEdward.Text = "Edward";
            this.btnEdward.UseVisualStyleBackColor = true;
            this.btnEdward.Click += new System.EventHandler(this.btnEdward_Click);
            // 
            // btnFrancis
            // 
            this.btnFrancis.Location = new System.Drawing.Point(234, 163);
            this.btnFrancis.Name = "btnFrancis";
            this.btnFrancis.Size = new System.Drawing.Size(75, 23);
            this.btnFrancis.TabIndex = 6;
            this.btnFrancis.Text = "Francis";
            this.btnFrancis.UseVisualStyleBackColor = true;
            this.btnFrancis.Click += new System.EventHandler(this.btnFrancis_Click_1);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(16, 75);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(260, 22);
            this.txtBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnFrancis);
            this.Controls.Add(this.btnEdward);
            this.Controls.Add(this.btnDanielle);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnDanielle;
        private System.Windows.Forms.Button btnEdward;
        private System.Windows.Forms.Button btnFrancis;
        private System.Windows.Forms.TextBox txtBox;
    }
}

