namespace EX1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResultsTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(996, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Custom Cool Shirts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "What size shirts do you need?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "$9.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "$10.99";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "$11.99";
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(182, 291);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(465, 177);
            this.lblResults.TabIndex = 5;
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(186, 148);
            this.btnSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(64, 60);
            this.btnSmall.TabIndex = 6;
            this.btnSmall.Text = "S";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(330, 148);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(64, 60);
            this.btnMedium.TabIndex = 7;
            this.btnMedium.Text = "M";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(477, 150);
            this.btnLarge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(61, 58);
            this.btnLarge.TabIndex = 8;
            this.btnLarge.Text = "L";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(309, 531);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 32);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResultsTotal
            // 
            this.lblResultsTotal.Location = new System.Drawing.Point(689, 291);
            this.lblResultsTotal.Name = "lblResultsTotal";
            this.lblResultsTotal.Size = new System.Drawing.Size(273, 177);
            this.lblResultsTotal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.lblResultsTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResultsTotal;
    }
}

