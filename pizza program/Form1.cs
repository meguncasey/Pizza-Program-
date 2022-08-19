using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            double OrderTotal = 0;
            double VAT = 0;
            double Total = 0;
            double Result = 0;


            if (cbSmall.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Small Pizza £2.00 ";
                Result = 2.00;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2"); //outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100; // calculates vat
                lblvat.Text = lblvat.Text + VAT; // outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2"); // outputs vat to labal
                Total = VAT + OrderTotal; // adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2"); //outputs total cost to pay to label 
            }

            if (cbMedium.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Medium Pizza £2.50 ";
                Result = 2.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            
            }

            if (cbLarge.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Large Pizza £3.00 ";
                Result = 3.00;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            
            }
            if (cbDonner.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Donner 50p ";  // MEGAN FARROWS CODE 
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }
            if (cbPepperoni.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Pepperoni 50p ";
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }

            if (cbSpicybeef.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Spicy Beef 50p ";
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }
            
            //MEGAN FARROWS CODE 
            if (cbExtracheese.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Extra Cheese 20p ";
                Result = 0.20;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }
            if (cbHam.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Ham 50p ";
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }
            if (cbOnions.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Onions 50p ";
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }

            if (cbPeppers.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Peppers 50p ";
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }
            //  MEGAN FARROWS CODE 
            if (cbChicken.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Chicken 50p ";
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }

            if (cbStuffedcrust.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Stuffed Crust 50p ";
                Result = 0.50;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal; // adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }
            if (cbDelivery.Checked == true)
            {
                lblOrdersum.Text = lblOrdersum.Text + "Delivery ";
                Result = 1.00;
                OrderTotal += Result;
                lbltotal.Text = OrderTotal.ToString("C2");//outputs order total without vat to label 
                VAT = OrderTotal * 20 / 100;// calculates vat
                lblvat.Text = lblvat.Text + VAT;// outputs vat calucation to label
                lblvat.Text = VAT.ToString("C2");// outputs vat to labal
                Total = VAT + OrderTotal;// adds VAT to the running total 
                lblTopay.Text = Total.ToString("C2");//outputs total cost to pay to label
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //MEGAN FARROWS CODE 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // causes to form to shut down
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Please contact megan for more help on 034895323 or email Megspizza@outlook.com"); //shows message box for help
        }
    }
}
