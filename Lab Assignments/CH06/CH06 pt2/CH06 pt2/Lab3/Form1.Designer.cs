namespace Lab3
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
            this.lblResults = new System.Windows.Forms.Label();
            this.btnBid = new System.Windows.Forms.Button();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arnie\'s Auctions";
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(488, 50);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(300, 37);
            this.lblResults.TabIndex = 1;
            // 
            // btnBid
            // 
            this.btnBid.Location = new System.Drawing.Point(289, 54);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(91, 33);
            this.btnBid.TabIndex = 2;
            this.btnBid.Text = "Bid";
            this.btnBid.UseVisualStyleBackColor = true;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBidAmount.Location = new System.Drawing.Point(12, 59);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.Size = new System.Drawing.Size(230, 28);
            this.txtBidAmount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.TextBox txtBidAmount;
    }
}

