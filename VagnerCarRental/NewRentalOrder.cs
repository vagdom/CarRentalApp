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
    public partial class NewRentalOrder : Form
    {
        public NewRentalOrder()
        {
            InitializeComponent();
        }

        private void dtpRentStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpRentEndDate.Value = dtpRentStartDate.Value;
        }

        private void btnRentalRates_Click(object sender, EventArgs e)
        {
            RentalRates wndRates = new RentalRates();
            wndRates.Show();
        }

        private void docPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 90, 750, 90);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 93, 750, 93);

            string strDisplay = "Vagner Car Rental";
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

        private void NewRentalOrder_Load(object sender, EventArgs e)
        {
            int iReceiptNumber = 100000;
            BinaryFormatter bfRentalOrders = new BinaryFormatter();
            Dictionary<int, RentalOrder> lstRentalOrders = new Dictionary<int, RentalOrder>();
            string strFilename = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\RentalOrders.ros";

            if (File.Exists(strFilename))
            {
                using (FileStream stmRentalOrders = new FileStream(strFilename,
                                                               FileMode.Open,
                                                               FileAccess.Read,
                                                               FileShare.Read))
                {
                    lstRentalOrders = (Dictionary<int, RentalOrder>)bfRentalOrders.Deserialize(stmRentalOrders);

                    foreach (KeyValuePair<int, RentalOrder> kvp in lstRentalOrders)
                    {
                        iReceiptNumber = kvp.Key;
                    }
                }
            }

            txtReceiptNumber.Text = (iReceiptNumber + 1).ToString();
        }

        private void btnSaveRentalOrder_Click(object sender, EventArgs e)
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

            // Create a rental order based on the information on the form
            RentalOrder order = new RentalOrder();

            order.DateProcessed = dtpDateProcessed.Value;
            //order.DateProcessed = dtpDateProcessed.Value.ToShortDateString();
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

            try
            {
                order.MileageStart = int.Parse(txtMileageStart.Text);
                order.MileageEnd = int.Parse(txtMileageStart.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid mileage start value",
                            "Bethesda Car Rental",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            order.MileageTotal = 0;
            try
            {
                order.RentStartDate = dtpRentStartDate.Value;
                order.RentEndDate = dtpRentStartDate.Value;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid start date",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            order.TotalDays = 0;
            try
            {
                order.RateApplied = double.Parse(txtRateApplied.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid rate applied value",
                            "Bethesda Car Rental",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            order.SubTotal = double.Parse(txtSubTotal.Text);

            try
            {
                order.TaxRate = double.Parse(txtTaxRate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid start date",
                                "Bethesda Car Rental",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            order.TaxAmount = double.Parse(txtTaxAmount.Text);
            order.OrderTotal = double.Parse(txtOrderTotal.Text);
            //order.OrderStatus = cbxOrderStatus;
            order.Notes = txtNotes.Text;

            lstRentalOrders.Add(int.Parse(txtReceiptNumber.Text), order);

            using (FileStream bcrStream = new FileStream(strFileName,
                                                     FileMode.Create,
                                                     FileAccess.Write,
                                                     FileShare.Write))
            {
                bfmRentalOrders.Serialize(bcrStream, lstRentalOrders);
            }

            Close();
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

        private void txtMileageEnd_Leave(object sender, EventArgs e)
        {
            double initMileage, endMileage, totalMileage = 0.0;

            initMileage = Convert.ToDouble(txtMileageStart.Text);
            endMileage = Convert.ToDouble(txtMileageEnd.Text);
            totalMileage = endMileage - initMileage;

            txtMileageTotal.Text = totalMileage.ToString();
        }

        private void dtpRentEndDate_ValueChanged(object sender, EventArgs e)
        {
            int NumberOfDays = (dtpRentEndDate.Value - dtpRentStartDate.Value).Days;

            txtTotalDays.Text = NumberOfDays.ToString();
        }

        private void txtTagNumber_Leave(object sender, EventArgs e)
        {
            BinaryFormatter bfmVehicles = new BinaryFormatter();
            Dictionary<string, Vehicle> lstVehicles = new Dictionary<string, Vehicle>();
            string strFilename = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\Vehicles.crs";

            if (File.Exists(strFilename))
            {
                using (FileStream stmVehicles = new FileStream(strFilename,
                                                            FileMode.Open,
                                                            FileAccess.Read,
                                                            FileShare.Read))
                {
                    // Retrieve the list of vehicles from file
                    lstVehicles = (Dictionary<string, Vehicle>)bfmVehicles.Deserialize(stmVehicles);

                    // Use the KeyValuePair class to visit each key/value item
                    foreach (KeyValuePair<string, Vehicle> kvp in lstVehicles)
                    {
                        Vehicle empl = kvp.Value;

                        if (kvp.Key == txtTagNumber.Text)
                        {
                            txtMake.Text = empl.Make;
                            txtModel.Text = empl.Model;
                            cbxVehiclesConditions.Text = empl.Condition;
                        }
                            
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double rateApplied, totalDays, subTotal, taxRate, taxAmount, orderTotal, totalMiles = 0.00;
            double gasPrice = 3.29;

            //Assign variables
            rateApplied = Convert.ToDouble(txtRateApplied.Text);
            totalDays = Convert.ToInt16(txtTotalDays.Text);
            taxRate = Convert.ToDouble(txtTaxRate.Text);
            totalMiles = Convert.ToDouble(txtMileageTotal.Text);

            //calculate Order
            subTotal = (rateApplied * totalDays) + (gasPrice * totalMiles);
            taxAmount = (subTotal * taxRate) / 100;
            orderTotal = subTotal + taxAmount;

            //Output Results
            txtSubTotal.Text = subTotal.ToString();
            txtTaxAmount.Text = taxAmount.ToString();
            txtOrderTotal.Text = orderTotal.ToString();


             
        }
    }
}
