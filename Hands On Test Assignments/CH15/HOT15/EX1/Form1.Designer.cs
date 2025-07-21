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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLongTerm = new System.Windows.Forms.RadioButton();
            this.chkShortTerm = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAccumulation = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblLoanPrice = new System.Windows.Forms.Label();
            this.lblNameField = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLongTerm);
            this.groupBox1.Controls.Add(this.chkShortTerm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateLoan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Loan";
            // 
            // chkLongTerm
            // 
            this.chkLongTerm.AutoSize = true;
            this.chkLongTerm.Location = new System.Drawing.Point(117, 199);
            this.chkLongTerm.Name = "chkLongTerm";
            this.chkLongTerm.Size = new System.Drawing.Size(164, 26);
            this.chkLongTerm.TabIndex = 5;
            this.chkLongTerm.TabStop = true;
            this.chkLongTerm.Text = "Long-Term Loan";
            this.chkLongTerm.UseVisualStyleBackColor = true;
            // 
            // chkShortTerm
            // 
            this.chkShortTerm.AutoSize = true;
            this.chkShortTerm.Location = new System.Drawing.Point(117, 167);
            this.chkShortTerm.Name = "chkShortTerm";
            this.chkShortTerm.Size = new System.Drawing.Size(167, 26);
            this.chkShortTerm.TabIndex = 4;
            this.chkShortTerm.TabStop = true;
            this.chkShortTerm.Text = "Short-Term Loan";
            this.chkShortTerm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(391, 28);
            this.txtName.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(117, 92);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(391, 28);
            this.txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(30, 240);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(133, 36);
            this.btnCreateLoan.TabIndex = 6;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAccumulation);
            this.groupBox2.Controls.Add(this.lblResults);
            this.groupBox2.Controls.Add(this.btnMakePayment);
            this.groupBox2.Controls.Add(this.lblLoanPrice);
            this.groupBox2.Controls.Add(this.lblNameField);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Loan";
            // 
            // lblAccumulation
            // 
            this.lblAccumulation.AutoSize = true;
            this.lblAccumulation.Location = new System.Drawing.Point(25, 249);
            this.lblAccumulation.Name = "lblAccumulation";
            this.lblAccumulation.Size = new System.Drawing.Size(58, 22);
            this.lblAccumulation.TabIndex = 4;
            this.lblAccumulation.Text = "label4";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(26, 193);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 22);
            this.lblResults.TabIndex = 3;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(17, 134);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(165, 35);
            this.btnMakePayment.TabIndex = 2;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblLoanPrice
            // 
            this.lblLoanPrice.AutoSize = true;
            this.lblLoanPrice.Location = new System.Drawing.Point(26, 91);
            this.lblLoanPrice.Name = "lblLoanPrice";
            this.lblLoanPrice.Size = new System.Drawing.Size(0, 22);
            this.lblLoanPrice.TabIndex = 1;
            // 
            // lblNameField
            // 
            this.lblNameField.AutoSize = true;
            this.lblNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameField.Location = new System.Drawing.Point(25, 40);
            this.lblNameField.Name = "lblNameField";
            this.lblNameField.Size = new System.Drawing.Size(0, 29);
            this.lblNameField.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(311, 356);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 714);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bank Loan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton chkLongTerm;
        private System.Windows.Forms.RadioButton chkShortTerm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNameField;
        private System.Windows.Forms.Label lblLoanPrice;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAccumulation;
    }
}

