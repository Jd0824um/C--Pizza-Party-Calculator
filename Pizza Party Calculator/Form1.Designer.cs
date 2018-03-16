namespace Pizza_Party_Calculator
{
    partial class formPizzaCalculator
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
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbMushroom = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cbDippingSauce = new System.Windows.Forms.CheckBox();
            this.cbBreakSticks = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(27, 11);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbSmall.Click += new System.EventHandler(this.getCheckedSize);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(131, 11);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbMedium.Click += new System.EventHandler(this.getCheckedSize);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(247, 11);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbLarge.Click += new System.EventHandler(this.getCheckedSize);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(278, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Location = new System.Drawing.Point(32, 12);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(333, 34);
            this.gbSize.TabIndex = 9;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size:";
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.cbBacon);
            this.gbToppings.Controls.Add(this.cbMushroom);
            this.gbToppings.Controls.Add(this.cbOnion);
            this.gbToppings.Controls.Add(this.cbSausage);
            this.gbToppings.Controls.Add(this.cbPepperoni);
            this.gbToppings.Location = new System.Drawing.Point(26, 70);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(339, 92);
            this.gbToppings.TabIndex = 10;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings:";
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Location = new System.Drawing.Point(216, 56);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(57, 17);
            this.cbBacon.TabIndex = 4;
            this.cbBacon.Text = "Bacon";
            this.cbBacon.UseVisualStyleBackColor = true;
            // 
            // cbMushroom
            // 
            this.cbMushroom.AutoSize = true;
            this.cbMushroom.Location = new System.Drawing.Point(60, 56);
            this.cbMushroom.Name = "cbMushroom";
            this.cbMushroom.Size = new System.Drawing.Size(75, 17);
            this.cbMushroom.TabIndex = 3;
            this.cbMushroom.Text = "Mushroom";
            this.cbMushroom.UseVisualStyleBackColor = true;
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(252, 20);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(54, 17);
            this.cbOnion.TabIndex = 2;
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(137, 20);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(68, 17);
            this.cbSausage.TabIndex = 1;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(33, 20);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(74, 17);
            this.cbPepperoni.TabIndex = 0;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            // 
            // gbExtras
            // 
            this.gbExtras.Controls.Add(this.cbSoda);
            this.gbExtras.Controls.Add(this.cbDippingSauce);
            this.gbExtras.Controls.Add(this.cbBreakSticks);
            this.gbExtras.Controls.Add(this.button3);
            this.gbExtras.Location = new System.Drawing.Point(32, 180);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(333, 81);
            this.gbExtras.TabIndex = 11;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras:";
            // 
            // cbSoda
            // 
            this.cbSoda.AutoSize = true;
            this.cbSoda.Location = new System.Drawing.Point(221, 31);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(51, 17);
            this.cbSoda.TabIndex = 4;
            this.cbSoda.Text = "Soda";
            this.cbSoda.UseVisualStyleBackColor = true;
            // 
            // cbDippingSauce
            // 
            this.cbDippingSauce.AutoSize = true;
            this.cbDippingSauce.Location = new System.Drawing.Point(119, 31);
            this.cbDippingSauce.Name = "cbDippingSauce";
            this.cbDippingSauce.Size = new System.Drawing.Size(96, 17);
            this.cbDippingSauce.TabIndex = 3;
            this.cbDippingSauce.Text = "Dipping Sauce";
            this.cbDippingSauce.UseVisualStyleBackColor = true;
            // 
            // cbBreakSticks
            // 
            this.cbBreakSticks.AutoSize = true;
            this.cbBreakSticks.Location = new System.Drawing.Point(27, 31);
            this.cbBreakSticks.Name = "cbBreakSticks";
            this.cbBreakSticks.Size = new System.Drawing.Size(86, 17);
            this.cbBreakSticks.TabIndex = 2;
            this.cbBreakSticks.Text = "Bread Sticks";
            this.cbBreakSticks.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(26, 303);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(139, 303);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(41, 269);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(53, 20);
            this.txtTip.TabIndex = 11;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(12, 272);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(28, 13);
            this.lblTip.TabIndex = 14;
            this.lblTip.Text = "Tip: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(172, 287);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // formPizzaCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(391, 338);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.btnExit);
            this.Name = "formPizzaCalculator";
            this.Text = "Pizza Party Calculator";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox cbBacon;
        private System.Windows.Forms.CheckBox cbMushroom;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cbDippingSauce;
        private System.Windows.Forms.CheckBox cbBreakSticks;
    }
}

