namespace Lab1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnConvertKm = new System.Windows.Forms.Button();
            this.btnConvertMiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance in miles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance in kilometers";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(351, 433);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 25);
            this.lblResults.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(200, 206);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 27);
            this.txtInput.TabIndex = 4;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(493, 206);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 27);
            this.txtInput2.TabIndex = 5;
            // 
            // btnConvertKm
            // 
            this.btnConvertKm.Location = new System.Drawing.Point(134, 239);
            this.btnConvertKm.Name = "btnConvertKm";
            this.btnConvertKm.Size = new System.Drawing.Size(233, 38);
            this.btnConvertKm.TabIndex = 6;
            this.btnConvertKm.Text = "Convert to Kilometers";
            this.btnConvertKm.UseVisualStyleBackColor = true;
            this.btnConvertKm.Click += new System.EventHandler(this.btnConvertKm_Click);
            // 
            // btnConvertMiles
            // 
            this.btnConvertMiles.Location = new System.Drawing.Point(447, 242);
            this.btnConvertMiles.Name = "btnConvertMiles";
            this.btnConvertMiles.Size = new System.Drawing.Size(241, 35);
            this.btnConvertMiles.TabIndex = 7;
            this.btnConvertMiles.Text = "Convert to miles";
            this.btnConvertMiles.UseVisualStyleBackColor = true;
            this.btnConvertMiles.Click += new System.EventHandler(this.btnConvertMiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 562);
            this.Controls.Add(this.btnConvertMiles);
            this.Controls.Add(this.btnConvertKm);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnConvertKm;
        private System.Windows.Forms.Button btnConvertMiles;
    }
}

