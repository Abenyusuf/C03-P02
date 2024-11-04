// Ahmed Benyusuf
// Class and Section (CS 313 01)
// Assignment (Program 02 Chapter 03)
// Description of the Program : This program allows users to click on pictures of different fruits to add their prices to a running total, which can be reset to zero with a button.




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FruitStand : Form
    {
        // creates a value for each of the picture boxes that can be used later to changr the total
        const decimal Sixty_five_cent = 0.65m;
        const decimal one_twenty_cent = 1.20m;
        const decimal one_sixty_cent = 1.60m;
        const decimal one_thirty_five_cent = 1.35m;


        // Contains a running total that can be updated constantly
        private decimal Total = 0;

        public FruitStand()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // Closes and exits the program
        }

        private void BananaPriceBox_Click(object sender, EventArgs e)
        {
            Total += Sixty_five_cent;
            TotalOutput.Text = Total.ToString("C");
            // For each click of the banana picture box it will increase the price sixty five cents
        }

        private void PearPriceBox_Click(object sender, EventArgs e)
        {
            Total += one_twenty_cent;
            TotalOutput.Text = Total.ToString("C");
            // For each click of the pear picture box it will increase the price one dollar and twenty cents

        }

        private void OrangePriceBox_Click(object sender, EventArgs e)
        {
            Total += one_sixty_cent;
            TotalOutput.Text = Total.ToString("C");
            // For each click of the orange picture box it will increase the price one dollar and sixty cents

        }

        private void ApplePriceBox_Click(object sender, EventArgs e)
        {
            Total += one_thirty_five_cent;
            TotalOutput.Text = Total.ToString("C");
            // For each click of the apple picture box it will increase the price one dollar and thirty five cents
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Total = 0;
            TotalOutput.Text = Total.ToString("C");
            // This button will reset the total that is displayed
        }
    }
}