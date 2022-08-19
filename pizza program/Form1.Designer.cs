namespace pizza_program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDonner = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.cbSpicybeef = new System.Windows.Forms.CheckBox();
            this.cbExtracheese = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbOnions = new System.Windows.Forms.CheckBox();
            this.cbPeppers = new System.Windows.Forms.CheckBox();
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbStuffedcrust = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbDelivery = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrdersum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSmall = new System.Windows.Forms.CheckBox();
            this.cbMedium = new System.Windows.Forms.CheckBox();
            this.cbLarge = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTopay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tandysoft", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order your Pizza with Megs Pizza!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toppings:";
            // 
            // cbDonner
            // 
            this.cbDonner.AutoSize = true;
            this.cbDonner.Location = new System.Drawing.Point(302, 120);
            this.cbDonner.Name = "cbDonner";
            this.cbDonner.Size = new System.Drawing.Size(85, 17);
            this.cbDonner.TabIndex = 5;
            this.cbDonner.Text = "Donner. 50p";
            this.cbDonner.UseVisualStyleBackColor = true;
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(302, 157);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(95, 17);
            this.cbPepperoni.TabIndex = 6;
            this.cbPepperoni.Text = "Pepperoni.50p";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            // 
            // cbSpicybeef
            // 
            this.cbSpicybeef.AutoSize = true;
            this.cbSpicybeef.Location = new System.Drawing.Point(302, 192);
            this.cbSpicybeef.Name = "cbSpicybeef";
            this.cbSpicybeef.Size = new System.Drawing.Size(101, 17);
            this.cbSpicybeef.TabIndex = 7;
            this.cbSpicybeef.Text = "Spicy Beef. 50p";
            this.cbSpicybeef.UseVisualStyleBackColor = true;
            // 
            // cbExtracheese
            // 
            this.cbExtracheese.AutoSize = true;
            this.cbExtracheese.Location = new System.Drawing.Point(454, 119);
            this.cbExtracheese.Name = "cbExtracheese";
            this.cbExtracheese.Size = new System.Drawing.Size(113, 17);
            this.cbExtracheese.TabIndex = 8;
            this.cbExtracheese.Text = "Extra Cheese. 20p";
            this.cbExtracheese.UseVisualStyleBackColor = true;
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(454, 157);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(72, 17);
            this.cbHam.TabIndex = 9;
            this.cbHam.Text = "Ham. 50p";
            this.cbHam.UseVisualStyleBackColor = true;
            // 
            // cbOnions
            // 
            this.cbOnions.AutoSize = true;
            this.cbOnions.Location = new System.Drawing.Point(454, 192);
            this.cbOnions.Name = "cbOnions";
            this.cbOnions.Size = new System.Drawing.Size(83, 17);
            this.cbOnions.TabIndex = 10;
            this.cbOnions.Text = "Onions. 50p";
            this.cbOnions.UseVisualStyleBackColor = true;
            // 
            // cbPeppers
            // 
            this.cbPeppers.AutoSize = true;
            this.cbPeppers.Location = new System.Drawing.Point(607, 119);
            this.cbPeppers.Name = "cbPeppers";
            this.cbPeppers.Size = new System.Drawing.Size(120, 17);
            this.cbPeppers.TabIndex = 11;
            this.cbPeppers.Text = "Mixed Peppers. 50p";
            this.cbPeppers.UseVisualStyleBackColor = true;
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Location = new System.Drawing.Point(607, 157);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(86, 17);
            this.cbChicken.TabIndex = 12;
            this.cbChicken.Text = "Chicken.50p";
            this.cbChicken.UseVisualStyleBackColor = true;
            // 
            // cbStuffedcrust
            // 
            this.cbStuffedcrust.AutoSize = true;
            this.cbStuffedcrust.Location = new System.Drawing.Point(607, 192);
            this.cbStuffedcrust.Name = "cbStuffedcrust";
            this.cbStuffedcrust.Size = new System.Drawing.Size(111, 17);
            this.cbStuffedcrust.TabIndex = 13;
            this.cbStuffedcrust.Text = "Stuffed Crust. 50p";
            this.cbStuffedcrust.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Your Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(306, 260);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(413, 20);
            this.txtName.TabIndex = 15;
            // 
            // cbDelivery
            // 
            this.cbDelivery.AutoSize = true;
            this.cbDelivery.Location = new System.Drawing.Point(251, 307);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(110, 17);
            this.cbDelivery.TabIndex = 16;
            this.cbDelivery.Text = "For delivery £1.00";
            this.cbDelivery.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.AllowDrop = true;
            this.txtAddress.Location = new System.Drawing.Point(260, 347);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(467, 70);
            this.txtAddress.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address/Special instructions";
            // 
            // lblOrdersum
            // 
            this.lblOrdersum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrdersum.Location = new System.Drawing.Point(6, 223);
            this.lblOrdersum.Name = "lblOrdersum";
            this.lblOrdersum.Size = new System.Drawing.Size(186, 50);
            this.lblOrdersum.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Order Summary ";
            // 
            // cbSmall
            // 
            this.cbSmall.AutoSize = true;
            this.cbSmall.Location = new System.Drawing.Point(306, 77);
            this.cbSmall.Name = "cbSmall";
            this.cbSmall.Size = new System.Drawing.Size(81, 17);
            this.cbSmall.TabIndex = 21;
            this.cbSmall.Text = "Small £2.00";
            this.cbSmall.UseVisualStyleBackColor = true;
            // 
            // cbMedium
            // 
            this.cbMedium.AutoSize = true;
            this.cbMedium.Location = new System.Drawing.Point(454, 77);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Size = new System.Drawing.Size(93, 17);
            this.cbMedium.TabIndex = 22;
            this.cbMedium.Text = "Medium £2.50";
            this.cbMedium.UseVisualStyleBackColor = true;
            // 
            // cbLarge
            // 
            this.cbLarge.AutoSize = true;
            this.cbLarge.Location = new System.Drawing.Point(607, 79);
            this.cbLarge.Name = "cbLarge";
            this.cbLarge.Size = new System.Drawing.Size(83, 17);
            this.cbLarge.TabIndex = 23;
            this.cbLarge.Text = "Large £3.00";
            this.cbLarge.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(547, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(541, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "_________________________________________________________________________________" +
    "________";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(243, 433);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(160, 47);
            this.btnBill.TabIndex = 26;
            this.btnBill.Text = "Show Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(429, 433);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(149, 47);
            this.btnHelp.TabIndex = 27;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(594, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 44);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotal.Location = new System.Drawing.Point(6, 302);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(186, 22);
            this.lbltotal.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "VAT";
            // 
            // lblvat
            // 
            this.lblvat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblvat.Location = new System.Drawing.Point(2, 359);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(190, 26);
            this.lblvat.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "TO PAY: ";
            // 
            // lblTopay
            // 
            this.lblTopay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTopay.Location = new System.Drawing.Point(5, 435);
            this.lblTopay.Name = "lblTopay";
            this.lblTopay.Size = new System.Drawing.Size(186, 44);
            this.lblTopay.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.lblTopay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbLarge);
            this.Controls.Add(this.cbMedium);
            this.Controls.Add(this.cbSmall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOrdersum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cbDelivery);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStuffedcrust);
            this.Controls.Add(this.cbChicken);
            this.Controls.Add(this.cbPeppers);
            this.Controls.Add(this.cbOnions);
            this.Controls.Add(this.cbHam);
            this.Controls.Add(this.cbExtracheese);
            this.Controls.Add(this.cbSpicybeef);
            this.Controls.Add(this.cbPepperoni);
            this.Controls.Add(this.cbDonner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Megs Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDonner;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.CheckBox cbSpicybeef;
        private System.Windows.Forms.CheckBox cbExtracheese;
        private System.Windows.Forms.CheckBox cbHam;
        private System.Windows.Forms.CheckBox cbOnions;
        private System.Windows.Forms.CheckBox cbPeppers;
        private System.Windows.Forms.CheckBox cbChicken;
        private System.Windows.Forms.CheckBox cbStuffedcrust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox cbDelivery;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrdersum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbSmall;
        private System.Windows.Forms.CheckBox cbMedium;
        private System.Windows.Forms.CheckBox cbLarge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTopay;
    }
}

