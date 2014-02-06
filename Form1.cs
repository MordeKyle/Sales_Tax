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
//      01/06/2014     
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
            // as salePriceTB.Text in order to user the figure the user enters.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
