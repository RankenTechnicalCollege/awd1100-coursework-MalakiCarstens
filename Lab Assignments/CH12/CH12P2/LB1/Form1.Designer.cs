namespace LB1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.lblNameOfFoodError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpSundaeToppings = new System.Windows.Forms.GroupBox();
            this.chkMango = new System.Windows.Forms.CheckBox();
            this.chkPeach = new System.Windows.Forms.CheckBox();
            this.chkLime = new System.Windows.Forms.CheckBox();
            this.chkSyrup = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.lblToppingError = new System.Windows.Forms.Label();
            this.lblMixinError = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grpDrinkMixins = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpSundaeToppings.SuspendLayout();
            this.grpDrinkMixins.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1202, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Order";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "What name do you want on the order?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 728);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add item to order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(20, 103);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(385, 28);
            this.txtUserName.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSoda);
            this.groupBox1.Controls.Add(this.chkSundae);
            this.groupBox1.Location = new System.Drawing.Point(41, 282);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(604, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Location = new System.Drawing.Point(372, 29);
            this.chkSoda.Margin = new System.Windows.Forms.Padding(4);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(63, 26);
            this.chkSoda.TabIndex = 8;
            this.chkSoda.Text = "Yes";
            this.chkSoda.UseVisualStyleBackColor = true;
            this.chkSoda.CheckedChanged += new System.EventHandler(this.chkSoda_CheckedChanged);
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(8, 29);
            this.chkSundae.Margin = new System.Windows.Forms.Padding(4);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(63, 26);
            this.chkSundae.TabIndex = 0;
            this.chkSundae.Text = "Yes";
            this.chkSundae.UseVisualStyleBackColor = true;
            this.chkSundae.CheckedChanged += new System.EventHandler(this.chkSundae_CheckedChanged);
            // 
            // lblNameOfFoodError
            // 
            this.lblNameOfFoodError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfFoodError.ForeColor = System.Drawing.Color.Red;
            this.lblNameOfFoodError.Location = new System.Drawing.Point(15, 151);
            this.lblNameOfFoodError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameOfFoodError.Name = "lblNameOfFoodError";
            this.lblNameOfFoodError.Size = new System.Drawing.Size(466, 32);
            this.lblNameOfFoodError.TabIndex = 0;
            this.lblNameOfFoodError.Text = "Name required / No food selected";
            this.lblNameOfFoodError.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do you want a sundae?";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Do you want a soda?";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(39, 465);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sundae Toppings";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(409, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Drink Mixins";
            // 
            // grpSundaeToppings
            // 
            this.grpSundaeToppings.Controls.Add(this.chkSyrup);
            this.grpSundaeToppings.Controls.Add(this.chkNuts);
            this.grpSundaeToppings.Controls.Add(this.chkSprinkles);
            this.grpSundaeToppings.Location = new System.Drawing.Point(49, 490);
            this.grpSundaeToppings.Name = "grpSundaeToppings";
            this.grpSundaeToppings.Size = new System.Drawing.Size(209, 144);
            this.grpSundaeToppings.TabIndex = 11;
            this.grpSundaeToppings.TabStop = false;
            this.grpSundaeToppings.Visible = false;
            // 
            // chkMango
            // 
            this.chkMango.AutoSize = true;
            this.chkMango.Location = new System.Drawing.Point(6, 91);
            this.chkMango.Name = "chkMango";
            this.chkMango.Size = new System.Drawing.Size(141, 26);
            this.chkMango.TabIndex = 5;
            this.chkMango.Text = "Mango Flavor";
            this.chkMango.UseVisualStyleBackColor = true;
            // 
            // chkPeach
            // 
            this.chkPeach.AutoSize = true;
            this.chkPeach.Location = new System.Drawing.Point(6, 59);
            this.chkPeach.Name = "chkPeach";
            this.chkPeach.Size = new System.Drawing.Size(138, 26);
            this.chkPeach.TabIndex = 4;
            this.chkPeach.Text = "Peach Flavor";
            this.chkPeach.UseVisualStyleBackColor = true;
            // 
            // chkLime
            // 
            this.chkLime.AutoSize = true;
            this.chkLime.Location = new System.Drawing.Point(6, 27);
            this.chkLime.Name = "chkLime";
            this.chkLime.Size = new System.Drawing.Size(125, 26);
            this.chkLime.TabIndex = 3;
            this.chkLime.Text = "Lime Flavor";
            this.chkLime.UseVisualStyleBackColor = true;
            // 
            // chkSyrup
            // 
            this.chkSyrup.AutoSize = true;
            this.chkSyrup.Location = new System.Drawing.Point(6, 91);
            this.chkSyrup.Name = "chkSyrup";
            this.chkSyrup.Size = new System.Drawing.Size(165, 26);
            this.chkSyrup.TabIndex = 2;
            this.chkSyrup.Text = "Chocolate Syurp";
            this.chkSyrup.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(6, 59);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(69, 26);
            this.chkNuts.TabIndex = 1;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Location = new System.Drawing.Point(6, 27);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(106, 26);
            this.chkSprinkles.TabIndex = 0;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // lblToppingError
            // 
            this.lblToppingError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingError.ForeColor = System.Drawing.Color.Red;
            this.lblToppingError.Location = new System.Drawing.Point(45, 637);
            this.lblToppingError.Name = "lblToppingError";
            this.lblToppingError.Size = new System.Drawing.Size(236, 28);
            this.lblToppingError.TabIndex = 3;
            this.lblToppingError.Text = "Only 2 toppings allowed";
            // 
            // lblMixinError
            // 
            this.lblMixinError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMixinError.ForeColor = System.Drawing.Color.Red;
            this.lblMixinError.Location = new System.Drawing.Point(383, 637);
            this.lblMixinError.Name = "lblMixinError";
            this.lblMixinError.Size = new System.Drawing.Size(236, 28);
            this.lblMixinError.TabIndex = 12;
            this.lblMixinError.Text = "Only 1 mixin allowed";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(746, 128);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(592, 537);
            this.rtbOutput.TabIndex = 13;
            this.rtbOutput.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1262, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Order";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(1140, 686);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 25);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(1208, 689);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(115, 22);
            this.lblTotalPrice.TabIndex = 16;
            // 
            // grpDrinkMixins
            // 
            this.grpDrinkMixins.Controls.Add(this.chkLime);
            this.grpDrinkMixins.Controls.Add(this.chkMango);
            this.grpDrinkMixins.Controls.Add(this.chkPeach);
            this.grpDrinkMixins.Location = new System.Drawing.Point(383, 490);
            this.grpDrinkMixins.Name = "grpDrinkMixins";
            this.grpDrinkMixins.Size = new System.Drawing.Size(211, 144);
            this.grpDrinkMixins.TabIndex = 3;
            this.grpDrinkMixins.TabStop = false;
            this.grpDrinkMixins.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1375, 901);
            this.Controls.Add(this.grpDrinkMixins);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lblMixinError);
            this.Controls.Add(this.lblToppingError);
            this.Controls.Add(this.grpSundaeToppings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNameOfFoodError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSundaeToppings.ResumeLayout(false);
            this.grpSundaeToppings.PerformLayout();
            this.grpDrinkMixins.ResumeLayout(false);
            this.grpDrinkMixins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameOfFoodError;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpSundaeToppings;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.Label lblToppingError;
        private System.Windows.Forms.CheckBox chkSyrup;
        private System.Windows.Forms.CheckBox chkMango;
        private System.Windows.Forms.CheckBox chkPeach;
        private System.Windows.Forms.CheckBox chkLime;
        private System.Windows.Forms.Label lblMixinError;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox grpDrinkMixins;
    }
}

