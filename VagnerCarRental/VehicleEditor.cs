using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace VagnerCarRental
{
    public partial class VehicleEditor : Form
    {
        public VehicleEditor()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            if (dlgPicture.ShowDialog() == DialogResult.OK)
            {
                lblPictureName.Text = dlgPicture.FileName;
                pbxVehicle.Image = Image.FromFile(lblPictureName.Text);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            BinaryFormatter bfmVehicles = new BinaryFormatter();
            Dictionary<string, Vehicle> lstVehicles = new Dictionary<string, Vehicle>();
            string strFileName = @"E:\VagnerCarRental\VagnerCarRental\Vehicles.crs";

            if (File.Exists(strFileName))
            {
                using (FileStream stmVehicles = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read,
                                                               FileShare.Read))
                {
                    lstVehicles = (Dictionary<string, Vehicle>)bfmVehicles.Deserialize(stmVehicles);
                }
            }

            if (txtTagNumber.Text.Length == 0)
            {
                MessageBox.Show("You must enter the car's tag number.",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMake.Text.Length == 0)
            {
                MessageBox.Show("You must specify the car's manufacturer.",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtModel.Text.Length == 0)
            {
                MessageBox.Show("You must enter the model of the vehicle.",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a Vehicle object
            vehicle.Make = txtMake.Text;
            vehicle.Model = txtModel.Text;
            vehicle.Doors = int.Parse(txtDoors.Text);
            vehicle.Passengers = int.Parse(txtPassengers.Text);
            vehicle.Condition = cbxConditions.Text;
            vehicle.Category = cbxCategories.Text;
            vehicle.Availability = cbxAvailabilities.Text;

            // Call the Add method of our collection class to add the vehicle
            lstVehicles.Add(txtTagNumber.Text, vehicle);

            // Save the list
            using (FileStream stmVehicles = new FileStream(strFileName,
                                                            FileMode.Create,
                                                            FileAccess.Write,
                                                            FileShare.Write))
            {
                bfmVehicles.Serialize(stmVehicles, lstVehicles);

                if (lblPictureName.Text.Length != 0)
                {
                    FileInfo flePicture = new FileInfo(lblPictureName.Text);
                    flePicture.CopyTo(@"E:\VagnerCarRental\VagnerCarRental\" +
                                        txtTagNumber.Text +
                                        flePicture.Extension);
                }

                /*txtTagNumber.Text = "";
                txtMake.Text = "";
                txtModel.Text = "";
                txtDoors.Text = "";
                txtPassengers.Text = "0";
                cbxConditions.SelectedIndex = 0;
                cbxCategories.Text = "Economy";
                cbxAvailabilities.SelectedIndex = 0;
                lblPictureName.Text = ".";
                pbxVehicle.Image = Image.FromFile(@"E:\VagnerCarRental\VagnerCarRental\Vehicle1.jpg"); */

                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VehicleEditor_Load(object sender, EventArgs e)
        {
            //pbxVehicle.Image = Image.FromFile(@"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\Vehicle1.jpg"); //Get picture dynamically        
            pbxVehicle.Image = Image.FromFile(@"E:\VagnerCarRental\VagnerCarRental\Vehicle1.jpg");
            lblPictureName.Text = "Choose an image for the vehicle";
        }
    }
}
