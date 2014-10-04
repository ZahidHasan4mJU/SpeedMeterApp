using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedometerApp5
{
    public partial class SpeedometerForm : Form
    {
        public SpeedometerForm()
        {
            InitializeComponent();
        }

        private Vehicle aVehicle;
        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle = new Vehicle(vehicleNameTextBox.Text, regNoTextBox.Text);
            MessageBox.Show(@"Registered.....");

        }

        private void enterSpeedButton_Click(object sender, EventArgs e)
        {
            aVehicle.Speed = Convert.ToDouble(speedTextBox.Text);
            
            MessageBox.Show(@"Speed has been entered");
            
            aVehicle.getMinSpeed().ToString();
            aVehicle.getMaxSpeed().ToString();
            aVehicle.getTotal();
            aVehicle.incrementCount();
            
            aVehicle.getAverage();

        }

        private void showSpeedButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicle.getMinSpeed().ToString();
            maxSpeedTextBox.Text = aVehicle.getMaxSpeed().ToString();
            averageTextBox.Text = aVehicle.getAverage().ToString();
        }
    }
}
