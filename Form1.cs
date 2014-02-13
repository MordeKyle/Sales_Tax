using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program: Sales Tax Calculator
//Author: Kyle McBride A02609917
//Date: 02/06/2014
//Description: The user of this program will enter the price of an item or items into the input. The
//             program will then calculate county and state sales taxes. The sales tax will then be
//             displayed to the user as county sales tax, state sales tax, the total amount of sales
//             tax, and the total amount of the purchase.
//
//     *Change Log*
//     02/13/2014
//      added some descriptions. 
//     02/11/2014 2
//      changes alignment of the text in the Text Box and Output Labels
//     02/11/2014
//      fixed dates in change log.
//      changed salePriceTB to salePriceTextBox
//     02/07/2014 2
//      infoLabel added.
//      fixed tab stops and tab orders.
//     02/07/2014
//      calculateButton event handler created;
//        Exception handler.
//        Added decimal variables.
//        Parse decimal variable salePrice(user input).
//        calculations added.
//        displaying of outputs added.
//      clearButton event handler created;
//        clearing of all labels and textbox added.
//      exitButton event handler created;
//        closing of program added.
//     02/06/2014     
//      Repository Creation.
//      salePriceTB == Sale Price Text box created.
//      amountOfPurchase label created.  
//      stateSalesTaxLabel and stateSalesTaxOutput created.
//      countySalesTaxLabel and countySalesTaxOutput created.
//      totalOfPurchaseLabel and totalOfPurchaseOutput created.
//      calculateButton created.
//      clearButton created.
//      exitButton created.
//      strings STATE_SALES_TAX_PERCENT and COUNTY_SALES_TAX_PERCENT created.

namespace Sales_Tax
{
    public partial class mainForm : Form
    {
        //declare constant values as strings.
        private const decimal STATE_SALES_TAX_PERCENT = 0.04m;
        private const decimal COUNTY_SALES_TAX_PERCENT = 0.02m;


        public mainForm()
        {
            InitializeComponent();
        }

        private void salePriceTB_TextChanged(object sender, EventArgs e)
        {
            // salePriceTB is where the user will enter the initial price of a purchase, before any
            // sales tax is applied to the figure. This figure will be called on later in the code
            // as salePriceTextBox.Text in order to user the figure the user enters.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare strings
                decimal salePrice;
                decimal stateTax;
                decimal countyTax;
                decimal totalTax;
                decimal totalPrice;

                //pulling the user defined data and assigning it to a decimal string:
                salePrice = decimal.Parse(salePriceTextBox.Text);

                //calculations:
                stateTax = salePrice * STATE_SALES_TAX_PERCENT;
                countyTax = salePrice * COUNTY_SALES_TAX_PERCENT;
                totalTax = countyTax + stateTax;
                totalPrice = totalTax + salePrice;

                //displaying the data:
                stateSalesTaxOutput.Text = stateTax.ToString("c");
                countySalesTaxOutput.Text = countyTax.ToString("c");
                totalSalesTaxOutput.Text = totalTax.ToString("c");
                totalOfPurchaseOutput.Text = totalPrice.ToString("c");

            }
            catch
            {
                //eroor message.
                MessageBox.Show("Oops, something went wrong.");

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing all of the inputs and outputs:
            salePriceTextBox.Text = "";
            stateSalesTaxOutput.Text = "";
            countySalesTaxOutput.Text = "";
            totalSalesTaxOutput.Text = "";
            totalOfPurchaseOutput.Text = "";


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exiting the program:
            this.Close();

        }
    }
}
