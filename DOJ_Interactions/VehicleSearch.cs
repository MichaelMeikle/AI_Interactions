using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOJ_Interactions
{
    public partial class VehicleSearch : UserControl
    {
        VehicleGenerator vehicleGenerator;
        public VehicleSearch()
        {
            InitializeComponent();
            vehicleGenerator = new VehicleGenerator();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string licensePlate = licensePlateInput.Text;
            string stateReg = stateRegInput.Text;
            string vin = vinInput.Text;
            string makeModel = makeInput.Text + modelInput.Text;
            if (makeModel.Length == 0)
                makeModel = "N/A";

            resetFields();

            if ((licensePlate.CompareTo("") == 0 || stateReg.CompareTo("") == 0) && vin.CompareTo("") == 0)
                return;

            Vehicle vehicle = vehicleGenerator.generateVehicle(licensePlate, stateReg, vin, makeModel);
            licensePlateLabel.Text = vehicle.LicensePlate;
            vinLabel.Text = vehicle.Vin;
            makeModelLabel.Text = vehicle.MakeModel;
            stateRegLabel.Text = vehicle.StateRegistration;
            registrationOutput.Text = vehicle.RegistrationStatus;
            insuranceOutput.Text = vehicle.InsuranceStatus;
            flagOutput.Text = vehicle.Flag;

            //Set text colors if warnings neccesary
            if(insuranceOutput.Text.CompareTo("Valid") != 0)
                insuranceOutput.ForeColor = Color.FromName("Red");
            if (registrationOutput.Text.CompareTo("Valid") != 0)
                registrationOutput.ForeColor = Color.FromName("Red");
            if (flagOutput.Text.CompareTo("None") != 0)
                flagOutput.ForeColor = Color.FromName("Red");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resetFields();
        }
        private void resetFields()
        {
            licensePlateLabel.Text = "N/A";
            vinLabel.Text = "N/A";
            makeModelLabel.Text = "N/A";
            stateRegLabel.Text = "N/A";
            registrationOutput.Text = "N/A";
            insuranceOutput.Text = "N/A";
            flagOutput.Text = "N/A";
            registrationOutput.ForeColor = Color.FromName("Black");
            insuranceOutput.ForeColor = Color.FromName("Black");
            flagOutput.ForeColor = Color.FromName("Black");

            licensePlateInput.Text = "";
            stateRegInput.Text = "";
            vinInput.Text = "";
            makeInput.Text = "";
            modelInput.Text = "";
        }
    }
}
