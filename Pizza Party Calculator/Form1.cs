using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Party_Calculator
{
    public partial class formPizzaCalculator : Form
    {
        public formPizzaCalculator()
        {
            InitializeComponent();

            //added these here to build the sizePrice dictionary
            sizePrice.Add("Small", 9.99m);
            sizePrice.Add("Medium", 14.99m);
            sizePrice.Add("Large", 19.99m);
        }

        Dictionary<String, Decimal> sizePrice = new Dictionary<string, decimal>();

        RadioButton size = null;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Checks to see if the size group has a checked radio button
        private bool isSizeChecked()
        {
            foreach (RadioButton rb in gbSize.Controls.OfType<RadioButton>()) //For loop that checks each radio button in the group to see if its checked
            {
                if (rb.Checked)
                {
                    return true; //Returns true if theres a checked radio button
                }
            }
            return false;
        }


        //Checks to see if input is a decimal number
        private bool isDecimal(TextBox txtbox, string name)
        {
            Decimal number = 0;
            if (Decimal.TryParse(txtbox.Text, out number))
            {
                return true;
            } else if (txtbox.Text == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                txtbox.Focus();
                return false;
            }
        }

        //only really used for the Tip Box, but checks that it's valid
        private bool isValidData(TextBox txtbox, string name)
        {
            return
                isDecimal(txtbox, name) || txtbox.Text == "";
         }

        private void getCheckedSize(object sender, EventArgs e)
        {
            size = sender as RadioButton;
        }
        
        //clears the total box for recalculation
        private void clearFutureValues (object sender, EventArgs e)
        {
            size = null;
            txtTotal.Clear();
            txtTip.Clear();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                if (isValidData(txtTip, "Tip"))
                {

                    decimal total = 0m;

                    if (isSizeChecked())
                    {
                        switch (size.Name)
                        {
                            case "rbSmall":
                                sizePrice.TryGetValue("Small", out total);
                                break;

                            case "rbMedium":
                                sizePrice.TryGetValue("Medium", out total);
                                break;
                            case "rbLarge":
                                sizePrice.TryGetValue("Large", out total);
                                break;
                        }
                    }

                    if (cbPepperoni.Checked)
                    {
                        total += 1.29m;
                    }
                    if (cbSausage.Checked)
                    {
                        total += .99m;
                    }
                    if (cbOnion.Checked)
                    {
                        total += .50m;
                    }
                    if (cbBacon.Checked)
                    {
                        total += 1.29m;
                    }
                    if (cbMushroom.Checked)
                    {
                        total += .50m;
                    }
                    if (cbBreakSticks.Checked)
                    {
                        total += 5.99m;
                    }
                    if (cbDippingSauce.Checked)
                    {
                        total += .99m;
                    }
                    if (cbSoda.Checked)
                    {
                        total += 1.59m;
                    }

                    decimal tax = 8.025m;
                    decimal tip;

                    if (txtTip.Text == "")
                    {
                        tip = 0;
                    }
                    else
                    {
                        tip = Convert.ToDecimal(txtTip.Text);
                    }


                    txtTotal.Text = ((1 + tax / 100) * total + tip).ToString("c");
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Too large of a tip?", "Entry Error");
            }
               
        }
    }

}
