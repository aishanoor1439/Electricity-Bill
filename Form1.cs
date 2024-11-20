using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double unitsConsumed = Convert.ToDouble(txtUnits.Text); // Number of units
            double ratePerUnit = Convert.ToDouble(txtRate.Text);    // Rate per unit
            string billType = txtBillType.Text.ToLower();            // Bill type

            double totalBill = 0;
            const double domesticFixedCharge = 500;
            const double industrialFixedCharge = 1000;
            const double commercialFixedCharge = 5000;

            // Switch case to calculate the bill based on the type
            switch (billType)
            {
                case "domestic":
                    totalBill = (unitsConsumed * ratePerUnit) + domesticFixedCharge;
                    break;

                case "industrial":
                    totalBill = (unitsConsumed * ratePerUnit) + industrialFixedCharge;
                    break;

                case "commercial":
                    totalBill = (unitsConsumed * ratePerUnit) + commercialFixedCharge;
                    break;

                default:
                    MessageBox.Show("Invalid bill type! Please enter 'Domestic', 'Industrial', or 'Commercial'.");
                    return;
            }

            // Display the result
            lblTotalBill.Text = $"Total Bill: {totalBill:C}";
        }
    }
}
