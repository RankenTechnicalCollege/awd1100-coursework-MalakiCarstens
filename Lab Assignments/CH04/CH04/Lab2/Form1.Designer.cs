namespace Lab2
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
            this.calculate = new System.Windows.Forms.Button();
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chicken Farmer";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(344, 223);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(115, 36);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(97, 131);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(100, 22);
            this.txtChicken1.TabIndex = 2;
            this.txtChicken1.TextChanged += new System.EventHandler(this.calculate_Click);
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(240, 131);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(100, 22);
            this.txtChicken2.TabIndex = 3;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(465, 131);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(100, 22);
            this.txtChicken3.TabIndex = 4;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(606, 131);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(100, 22);
            this.txtChicken4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter number of eggs lai by each chicken:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(382, 326);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}

