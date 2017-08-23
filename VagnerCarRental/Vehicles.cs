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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        internal void ShowVehicles()
        {
            BinaryFormatter bfmVehicles = new BinaryFormatter();
            Dictionary<string, Vehicle> lstVehicles = new Dictionary<string, Vehicle>();
            string strFilename = @"E:\VagnerCarRental\VagnerCarRental\Vehicles.crs"; //Fix this to dynamically locate apps folder

            lvwVehicles.Items.Clear();

            if (File.Exists(strFilename))
            {
                using (FileStream stmVehicles = new FileStream(strFilename,
                                                               FileMode.Open,
                                                               FileAccess.Read,
                                                               FileShare.Read))
                {
                    lstVehicles = (Dictionary<string, Vehicle>)bfmVehicles.Deserialize(stmVehicles);
                }
            }

            foreach (KeyValuePair<string, Vehicle> kvp in lstVehicles)
            {
                ListViewItem lviVehicle = new ListViewItem(kvp.Key);

                Vehicle car = kvp.Value;

                lviVehicle.SubItems.Add(car.Make);
                lviVehicle.SubItems.Add(car.Model);
                lviVehicle.SubItems.Add(car.Doors.ToString());
                lviVehicle.SubItems.Add(car.Passengers.ToString());
                lviVehicle.SubItems.Add(car.Condition);
                lviVehicle.SubItems.Add(car.Category);
                lviVehicle.SubItems.Add(car.Availability);

                if (car.Availability == "Available")
                {
                    // For any vehicle that is available for rent,
                    // show its background in green color
                    lviVehicle.BackColor = Color.FromArgb(0, 128, 0);
                    lviVehicle.ForeColor = Color.White;
                }
                else if (car.Availability == "Rented")
                {
                    // If the vehicle is rented, show its background in orange
                    lviVehicle.BackColor = Color.FromArgb(235, 45, 200);
                    lviVehicle.ForeColor = Color.White;
                }
                else
                {
                    lviVehicle.BackColor = Color.FromArgb(255, 0, 0);
                    lviVehicle.ForeColor = Color.White;
                }

                lvwVehicles.Items.Add(lviVehicle);
            }
        }


        private void Vehicles_Load(object sender, EventArgs e)
        {
            ShowVehicles();
        }

        private void lvwVehicles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string strFileName = @"E:\VagnerCarRental\VagnerCarRental\" + e.Item.Text + ".jpg";            

            if (File.Exists(strFileName))
                pbxVehicle.Image = Image.FromFile(strFileName);
            else
                pbxVehicle.Image = Image.FromFile(@"E:\VagnerCarRental\VagnerCarRental\Vehicle1.jpeg");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            VehicleEditor editor = new VehicleEditor();
            editor.ShowDialog();
            ShowVehicles();
        }
    }
}
