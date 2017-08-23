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
    public partial class UpdateRentalOrder : Form
    {
        public UpdateRentalOrder()
        {
            InitializeComponent();
        }

        private void txtMileageEnd_Leave(object sender, EventArgs e)
        {
            int mileageStart = 0, mileageEnd = 0;

            try
            {
                mileageStart = int.Parse(txtMileageStart.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("There was a problem with the mileage start value.\n" +
                                "Please report the error as\n" +
                                fe.Message,
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                mileageEnd = int.Parse(txtMileageEnd.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("There was a problem with the mileage end value.\n" +
                                "Please report the error as\n" +
                                fe.Message,
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtMileageTotal.Text = (mileageEnd - mileageStart).ToString();
        }

        private void dtpRentStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpRentEndDate.Value = dtpRentStartDate.Value;
        }

        private void dtpRentEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dteStart = dtpRentStartDate.Value;
            DateTime dteEnd = dtpRentEndDate.Value;

            // Let's calculate the difference in days
            TimeSpan tme = dteEnd - dteStart;
            int days = tme.Days;

            // If the customer returns the car the same day, 
            // we consider that the car was rented for 1 day
            if (days == 0)
                days = 1;

            txtTotalDays.Text = days.ToString();
            // At any case, we will let the clerk specify the actual number of days
        }

        private void btnRentalRates_Click(object sender, EventArgs e)
        {
            RentalRates wndRates = new RentalRates();
            wndRates.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Days = 0;
            double RateApplied = 0.00;
            double SubTotal = 0.00;
            double TaxRate = 0.00;
            double TaxAmount = 0.00;
            double OrderTotal = 0.00;

            try
            {
                Days = int.Parse(txtTotalDays.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number of Days",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                RateApplied = double.Parse(txtRateApplied.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Amount for Rate Applied",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SubTotal = Days * RateApplied;
            txtSubTotal.Text = SubTotal.ToString("F");

            try
            {
                TaxRate = double.Parse(txtTaxRate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Tax Rate",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TaxAmount = SubTotal * TaxRate / 100;
            txtTaxAmount.Text = TaxAmount.ToString("F");

            OrderTotal = SubTotal + TaxAmount;
            txtOrderTotal.Text = OrderTotal.ToString("F");
        }

        private void docPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 90, 750, 90);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 93, 750, 93);

            string strDisplay = "Bethesda Car Rental";
            System.Drawing.Font fntBoldString = new Font("Times New Roman", 28, FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntBoldString, Brushes.Black, 240, 100);

            strDisplay = "Vehicle Rental Order";
            System.Drawing.Font fntRegularString = new System.Drawing.Font("Times New Roman", 22, FontStyle.Regular);
            e.Graphics.DrawString(strDisplay, fntRegularString, Brushes.Black, 280, 150);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 187, 750, 187);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 190, 750, 190);

            fntBoldString = new Font("Times New Roman", 12, FontStyle.Bold);
            fntRegularString = new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular);

            e.Graphics.DrawString("Receipt #:  ", fntBoldString, Brushes.Black, 100, 220);
            e.Graphics.DrawString(txtReceiptNumber.Text, fntRegularString, Brushes.Black, 260, 220);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 240, 380, 240);

            e.Graphics.DrawString("Processed By:  ", fntBoldString, Brushes.Black, 420, 220);
            e.Graphics.DrawString(txtEmployeeName.Text, fntRegularString, Brushes.Black, 550, 220);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 240, 720, 240);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 260, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 260, 620, 20));

            e.Graphics.DrawString("Customer", fntBoldString, Brushes.White, 100, 260);

            e.Graphics.DrawString("First Name: ", fntBoldString, Brushes.Black, 100, 300);
            e.Graphics.DrawString(txtCustomerFirstName.Text, fntBoldString, Brushes.Black, 260, 300);
            e.Graphics.DrawString("Last Name: ", fntBoldString, Brushes.Black, 420, 300);
            e.Graphics.DrawString(txtCustomerLastName.Text, fntBoldString, Brushes.Black, 540, 300);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 320, 720, 320);

            e.Graphics.DrawString("Address: ", fntBoldString, Brushes.Black, 100, 330);
            e.Graphics.DrawString(txtCustomerAddress.Text, fntRegularString, Brushes.Black, 260, 330);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 350, 720, 350);

            strDisplay = txtCustomerCity.Text + " " + cbxCustomerStates.Text + " " + txtCustomerZIPCode.Text;
            e.Graphics.DrawString(strDisplay, fntRegularString, Brushes.Black, 260, 360);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 260, 380, 720, 380);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 410, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 410, 620, 20));

            e.Graphics.DrawString("Car Information", fntBoldString, Brushes.White, 100, 410);

            e.Graphics.DrawString("Tag #: ", fntBoldString, Brushes.Black, 100, 450);
            e.Graphics.DrawString(txtTagNumber.Text, fntRegularString, Brushes.Black, 260, 450);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 470, 380, 470);

            e.Graphics.DrawString("Condition: ", fntBoldString, Brushes.Black, 420, 450);
            e.Graphics.DrawString(cbxVehiclesConditions.Text, fntRegularString, Brushes.Black, 530, 450); // ?
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 470, 720, 470);

            e.Graphics.DrawString("Make: ", fntBoldString, Brushes.Black, 100, 480);
            e.Graphics.DrawString(txtMake.Text, fntRegularString, Brushes.Black, 260, 480);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 500, 380, 500);

            e.Graphics.DrawString("Model: ", fntBoldString, Brushes.Black, 420, 480);
            e.Graphics.DrawString(txtModel.Text, fntRegularString, Brushes.Black, 530, 480);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 500, 720, 500);

            e.Graphics.DrawString("Vehicle Condition: ", fntBoldString, Brushes.Black, 100, 510);
            e.Graphics.DrawString(cbxVehiclesConditions.Text, fntRegularString, Brushes.Black, 260, 510);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 530, 380, 530);

            e.Graphics.DrawString("Tank Level: ", fntBoldString, Brushes.Black, 420, 510);
            e.Graphics.DrawString(cbxTanksLevels.Text, fntRegularString, Brushes.Black, 530, 510);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 530, 720, 530);

            e.Graphics.DrawString("Mileage Start:", fntBoldString, Brushes.Black, 100, 540);
            e.Graphics.DrawString(txtMileageStart.Text, fntRegularString, Brushes.Black, 260, 540);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 560, 380, 560);

            e.Graphics.DrawString("Mileage End:", fntBoldString, Brushes.Black, 420, 540);
            e.Graphics.DrawString(txtMileageEnd.Text, fntRegularString, Brushes.Black, 530, 540);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 560, 720, 560);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 590, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 590, 620, 20));

            e.Graphics.DrawString("Order Timing Information", fntBoldString, Brushes.White, 100, 590);

            e.Graphics.DrawString("Start Date:", fntBoldString, Brushes.Black, 100, 620);
            e.Graphics.DrawString(dtpRentStartDate.Value.ToString("D"), fntRegularString, Brushes.Black, 260, 620);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 640, 720, 640);

            e.Graphics.DrawString("End Date:", fntBoldString, Brushes.Black, 100, 650);
            e.Graphics.DrawString(dtpRentEndDate.Value.ToString("D"), fntRegularString, Brushes.Black, 260, 650);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 670, 520, 670);

            e.Graphics.DrawString("Total Days:", fntBoldString, Brushes.Black, 550, 650);
            e.Graphics.DrawString(txtTotalDays.Text, fntRegularString, Brushes.Black, 640, 650);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 550, 670, 720, 670);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 700, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 700, 620, 20));

            e.Graphics.DrawString("Order Evaluation", fntBoldString, Brushes.White, 100, 700);

            StringFormat fmtString = new StringFormat();
            fmtString.Alignment = StringAlignment.Far;

            e.Graphics.DrawString("Rate Applied:", fntBoldString, Brushes.Black, 100, 740);
            e.Graphics.DrawString(txtRateApplied.Text, fntRegularString, Brushes.Black, 300, 740, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 760, 380, 760);

            e.Graphics.DrawString("Tax Rate:", fntBoldString, Brushes.Black, 420, 740);
            e.Graphics.DrawString(txtTaxRate.Text, fntRegularString, Brushes.Black, 640, 740, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 760, 720, 760);

            e.Graphics.DrawString("Sub-Total:", fntBoldString, Brushes.Black, 100, 770);
            e.Graphics.DrawString(txtSubTotal.Text, fntRegularString, Brushes.Black, 300, 770, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 790, 380, 790);

            e.Graphics.DrawString("Tax Amount:", fntBoldString, Brushes.Black, 420, 770);
            e.Graphics.DrawString(txtTaxAmount.Text, fntRegularString, Brushes.Black, 640, 770, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 790, 720, 790);

            e.Graphics.DrawString("Order Total:", fntBoldString, Brushes.Black, 420, 800);
            e.Graphics.DrawString(txtOrderTotal.Text, fntRegularString, Brushes.Black, 640, 800, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 820, 720, 820);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dlgPrint.ShowDialog() == DialogResult.OK)
                docPrint.Print();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            dlgPrintPreview.ShowDialog();
        }

        private void txtEmployeeNumber_Leave(object sender, EventArgs e)
        {
            BinaryFormatter bfmEmployees = new BinaryFormatter();
            Dictionary<string, Employee> lstEmployees = new Dictionary<string, Employee>();
            string strFilename = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\Employees.cre";

            if (File.Exists(strFilename))
            {
                using (FileStream stmEmployees = new FileStream(strFilename,
                                                            FileMode.Open,
                                                            FileAccess.Read,
                                                            FileShare.Read))
                {
                    // Retrieve the list of employees from file
                    lstEmployees = (Dictionary<string, Employee>)bfmEmployees.Deserialize(stmEmployees);

                    // Use the KeyValuePair class to visit each key/value item
                    foreach (KeyValuePair<string, Employee> kvp in lstEmployees)
                    {
                        Employee empl = kvp.Value;

                        if (kvp.Key == txtEmployeeNumber.Text)
                            txtEmployeeName.Text = empl.EmployeeName;
                    }
                }
            }
        }

        private void txtTagNumber_Leave(object sender, EventArgs e)
        {
            BinaryFormatter bfVehicles = new BinaryFormatter();
            Dictionary<string, Vehicle> lstVehicles = new Dictionary<string, Vehicle>();
            string strFilename = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\Vehicles.crs";


            if (File.Exists(strFilename))
            {
                using (FileStream stmVehicles = new FileStream(strFilename,
                                                               FileMode.Open,
                                                               FileAccess.Read,
                                                               FileShare.Read))
                {
                    lstVehicles = (Dictionary<string, Vehicle>)bfVehicles.Deserialize(stmVehicles);

                    foreach (KeyValuePair<string, Vehicle> kvp in lstVehicles)
                    {
                        Vehicle car = kvp.Value;

                        if (kvp.Key == txtTagNumber.Text)
                        {
                            txtMake.Text = car.Make;
                            txtModel.Text = car.Model;
                            cbxVehiclesConditions.Text = car.Condition;
                        }
                    }
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            BinaryFormatter bfmRentalOrders = new BinaryFormatter();
            Dictionary<int, RentalOrder> lstRentalOrders = new Dictionary<int, RentalOrder>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\RentalOrders.ros";

            if (File.Exists(strFileName))
            {
                using (FileStream stmRentalOrders = new FileStream(strFileName,
                                                            FileMode.Open,
                                                            FileAccess.Read,
                                                            FileShare.Read))
                {
                    lstRentalOrders = (Dictionary<int, RentalOrder>)bfmRentalOrders.Deserialize(stmRentalOrders);
                }
            }

            if (string.IsNullOrEmpty(txtReceiptNumber.Text))
            {
                MessageBox.Show("You must enter a receipt number.",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (File.Exists(strFileName))
            {
                using (FileStream stmRentalOrders = new FileStream(strFileName,
                                                         FileMode.Open,
                                                         FileAccess.Read,
                                                         FileShare.Read))
                {
                    lstRentalOrders = (Dictionary<int, RentalOrder>)bfmRentalOrders.Deserialize(stmRentalOrders);

                    foreach (KeyValuePair<int, RentalOrder> kvp in lstRentalOrders)
                    {
                        if (kvp.Key == int.Parse(txtReceiptNumber.Text))
                        {
                            RentalOrder ro = kvp.Value;

                            //dtpDateProcessed.Value = DateTime.Parse(ro.DateProcessed);
                            txtEmployeeNumber.Text = ro.EmployeeNumber;
                            txtEmployeeNumber_Leave(sender, e);
                            txtCustomerFirstName.Text = ro.CustomerFirstName;
                            txtCustomerLastName.Text = ro.CustomerLastName;
                            txtCustomerAddress.Text = ro.CustomerAddress;
                            txtCustomerCity.Text = ro.CustomerCity;
                            cbxCustomerStates.Text = ro.CustomerState;
                            txtCustomerZIPCode.Text = ro.CustomerZIPCode;
                            txtTagNumber.Text = ro.VehicleTagNumber;
                            txtTagNumber_Leave(sender, e);
                            cbxVehiclesConditions.Text = ro.VehicleCondition;
                            cbxTanksLevels.Text = ro.TankLevel;
                            txtMileageStart.Text = ro.MileageStart.ToString();
                            txtMileageEnd.Text = ro.MileageEnd.ToString();
                            txtMileageTotal.Text = ro.MileageTotal.ToString();
                            //dtpRentStartDate.Value = DateTime.Parse(ro.RentStartDate);
                            //dtpRentEndDate.Value = DateTime.Parse(ro.RentEndDate);
                            txtTotalDays.Text = ro.TotalDays.ToString();
                            txtRateApplied.Text = ro.RateApplied.ToString();
                            txtSubTotal.Text = ro.SubTotal.ToString();
                            txtTaxRate.Text = ro.TaxRate.ToString();
                            txtTaxAmount.Text = ro.TaxAmount.ToString();
                            txtOrderTotal.Text = ro.OrderTotal.ToString();
                            //cbxOrderStatus.Text = ro.OrderStatus;
                            txtNotes.Text = ro.Notes;
                            return;
                        }
                    }
                }
            }
        }

        private void btnUpdateRentalOrder_Click(object sender, EventArgs e)
        {
            BinaryFormatter bfmRentalOrders = new BinaryFormatter();
            Dictionary<int, RentalOrder> lstRentalOrders = new Dictionary<int, RentalOrder>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\RentalOrders.ros";

            if (string.IsNullOrEmpty(txtReceiptNumber.Text))
            {
                MessageBox.Show("The receipt number is missing.",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Don't save this rental order if we don't
            // know who processed it
            if (string.IsNullOrEmpty(txtEmployeeNumber.Text))
            {
                MessageBox.Show("You must enter the employee number of the " +
                                "clerk who processed this order.",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Don't save the rental order if we don't
            // know what car is being rented
            if (string.IsNullOrEmpty(txtTagNumber.Text))
            {
                MessageBox.Show("You must enter the tag number " +
                                "of the vehicle that is being rented.",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (File.Exists(strFileName))
            {
                using (FileStream stmRentalOrders = new FileStream(strFileName,
                                                            FileMode.Open,
                                                            FileAccess.Read,
                                                            FileShare.Read))
                {
                    lstRentalOrders = (Dictionary<int, RentalOrder>)bfmRentalOrders.Deserialize(stmRentalOrders);

                    foreach (KeyValuePair<int, RentalOrder> kvpRentalOrder in lstRentalOrders)
                    {
                        if (kvpRentalOrder.Key == int.Parse(txtReceiptNumber.Text))
                        {
                            RentalOrder order = kvpRentalOrder.Value;

                            order.DateProcessed = dtpDateProcessed.Value;
                            order.EmployeeNumber = txtEmployeeNumber.Text;
                            order.CustomerFirstName = txtCustomerFirstName.Text;
                            order.CustomerLastName = txtCustomerLastName.Text;
                            order.CustomerAddress = txtCustomerAddress.Text;
                            order.CustomerCity = txtCustomerCity.Text;
                            order.CustomerState = cbxCustomerStates.Text;
                            order.CustomerZIPCode = txtCustomerZIPCode.Text;
                            order.VehicleTagNumber = txtTagNumber.Text;
                            order.VehicleCondition = cbxVehiclesConditions.Text;
                            order.TankLevel = cbxTanksLevels.Text;
                            order.MileageStart = int.Parse(txtMileageStart.Text);
                            order.MileageEnd = int.Parse(txtMileageEnd.Text);
                            order.MileageTotal = int.Parse(txtMileageTotal.Text);
                            order.RentStartDate = dtpRentStartDate.Value;
                            order.RentEndDate = dtpRentEndDate.Value;
                            order.TotalDays = int.Parse(txtTotalDays.Text);
                            order.RateApplied = double.Parse(txtRateApplied.Text);
                            order.SubTotal = double.Parse(txtSubTotal.Text);
                            order.TaxRate = double.Parse(txtTaxRate.Text);
                            order.TaxAmount = double.Parse(txtTaxAmount.Text);
                            order.OrderTotal = double.Parse(txtOrderTotal.Text);
                            //order.OrderStatus = cbxOrderStatus.Text;
                            order.Notes = txtNotes.Text;

                            break;
                        }
                    }
                }
            }

            using (FileStream bcrStream = new FileStream(strFileName,
                                                         FileMode.Create,
                                                         FileAccess.Write,
                                                         FileShare.Write))
            {
                bfmRentalOrders.Serialize(bcrStream, lstRentalOrders);
            }

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
