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

namespace VagnerCarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // If the directory and the sub-directory don't exist, create them
            Directory.CreateDirectory(@"C:\Microsoft Visual C# Application Design\Bethesda Car Rental");
        }

        private void btnRentalOrders_Click(object sender, EventArgs e)
        {
            RentalOrders ros = new RentalOrders();
            ros.Show();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Vehicles cars = new Vehicles();
            cars.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees staff = new Employees();
            staff.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
