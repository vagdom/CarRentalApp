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
    public partial class RentalOrders : Form
    {
        public RentalOrders()
        {
            InitializeComponent();
        }

        private void ShowRentalOrders()
        {
            string orderStatus, notes;
            string condition, tankLevel;
            DateTime dateProcessed, rentStartDate, rentEndDate;
            string customer = "", employee = "", vehicle = "";
            int mileageStart, mileageEnd, mileageTotal, totalDays;
            string employeeNumber, employeeFirstName, employeeLastName;
            double rateApplied, subTotal, taxRate, taxAmount, orderTotal;

            BinaryFormatter bfmVehicles = new BinaryFormatter();
            BinaryFormatter bfmEmployees = new BinaryFormatter();
            BinaryFormatter bfmRentalOrders = new BinaryFormatter();
            Dictionary<string, Vehicle> lstVehicles = new Dictionary<string, Vehicle>();
            Dictionary<string, Employee> lstEmployees = new Dictionary<string, Employee>();
            Dictionary<int, RentalOrder> lstRentalOrders = new Dictionary<int, RentalOrder>();
            string strVehiclesFile = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\Vehicles.crs";
            string strEmployeesFile = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\Employees.cre";
            string strRentalOrdersFile = @"C:\Microsoft Visual C# Application Design\Bethesda Car Rental\RentalOrders.ros";

            if (File.Exists(strRentalOrdersFile))
            {
                lvwRentalOrders.Items.Clear();

                using (FileStream stmRentalOrders = new FileStream(strRentalOrdersFile,
                                                         FileMode.Open,
                                                         FileAccess.Read,
                                                         FileShare.Read))
                {
                    lstRentalOrders = (Dictionary<int, RentalOrder>)bfmRentalOrders.Deserialize(stmRentalOrders);

                    foreach (KeyValuePair<int, RentalOrder> kvp in lstRentalOrders)
                    {
                        RentalOrder ro = kvp.Value;
                        ListViewItem lviRentalOrder = new ListViewItem(kvp.Key.ToString());

                        //dateProcessed = DateTime.Parse(ro.DateProcessed);
                        dateProcessed = new DateTime(06,06,2017);


                        using (FileStream stmEmployees = new FileStream(strEmployeesFile,
                                                                 FileMode.Open,
                                                                 FileAccess.Read,
                                                                 FileShare.Read))
                        {
                            // Retrieve the list of employees from file
                            lstEmployees = (Dictionary<string, Employee>)bfmEmployees.Deserialize(stmEmployees);

                            // Use the KeyValuePair class to visit each key/value item
                            foreach (KeyValuePair<string, Employee> kvpEmployee in lstEmployees)
                            {
                                Employee empl = kvpEmployee.Value;

                                if (kvpEmployee.Key == ro.EmployeeNumber)
                                {
                                    employee = kvpEmployee.Key + ": " + empl.EmployeeName;
                                    break;
                                }
                            }
                        }

                        customer = ro.CustomerFirstName + " " + ro.CustomerLastName;

                        using (FileStream stmVehicles = new FileStream(strVehiclesFile,
                                                               FileMode.Open,
                                                               FileAccess.Read,
                                                               FileShare.Read))
                        {
                            lstVehicles = (Dictionary<string, Vehicle>)bfmVehicles.Deserialize(stmVehicles);

                            foreach (KeyValuePair<string, Vehicle> kvpVehicle in lstVehicles)
                            {
                                Vehicle car = kvpVehicle.Value;

                                if (kvpVehicle.Key == ro.VehicleTagNumber)
                                {
                                    vehicle = kvpVehicle.Key + ": " + car.Make + " " + car.Model;
                                }
                            }
                        }

                        condition = ro.VehicleCondition;
                        tankLevel = ro.TankLevel;
                        mileageStart = ro.MileageStart;
                        mileageEnd = ro.MileageEnd;
                        mileageTotal = ro.MileageTotal;
                        //rentStartDate = DateTime.Parse(ro.RentStartDate);
                        //rentEndDate = DateTime.Parse(ro.RentEndDate);
                        totalDays = ro.TotalDays;
                        rateApplied = ro.RateApplied;
                        subTotal = ro.SubTotal;
                        taxRate = ro.TaxRate;
                        taxAmount = ro.TaxAmount;
                        orderTotal = ro.OrderTotal;
                        //orderStatus = ro.OrderStatus;
                        notes = ro.Notes;

                        lviRentalOrder.SubItems.Add(dateProcessed.ToShortDateString());
                        lviRentalOrder.SubItems.Add(employee);
                        lviRentalOrder.SubItems.Add(customer);
                        lviRentalOrder.SubItems.Add(vehicle);
                        lviRentalOrder.SubItems.Add(condition);
                        lviRentalOrder.SubItems.Add(tankLevel);
                        lviRentalOrder.SubItems.Add(mileageStart.ToString());
                        lviRentalOrder.SubItems.Add(mileageEnd.ToString());
                        lviRentalOrder.SubItems.Add(mileageTotal.ToString());
                        //lviRentalOrder.SubItems.Add(rentStartDate.ToShortDateString());
                        //lviRentalOrder.SubItems.Add(rentEndDate.ToShortDateString());
                        lviRentalOrder.SubItems.Add(totalDays.ToString());
                        lviRentalOrder.SubItems.Add(rateApplied.ToString());
                        lviRentalOrder.SubItems.Add(subTotal.ToString());
                        lviRentalOrder.SubItems.Add(taxRate.ToString());
                        lviRentalOrder.SubItems.Add(taxAmount.ToString());
                        lviRentalOrder.SubItems.Add(orderTotal.ToString());
                        //lviRentalOrder.SubItems.Add(orderStatus);
                        lviRentalOrder.SubItems.Add(notes);

                        lvwRentalOrders.Items.Add(lviRentalOrder);
                    }
                }
            }
        }


        private void RentalOrders_Load(object sender, EventArgs e)
        {
            ShowRentalOrders();
        }

        private void btnNewRentalOrder_Click(object sender, EventArgs e)
        {
            NewRentalOrder nro = new NewRentalOrder();

            nro.ShowDialog();
            ShowRentalOrders();
        }

        private void btnUpdateRentalOrder_Click(object sender, EventArgs e)
        {
            UpdateRentalOrder uro = new UpdateRentalOrder();

            uro.ShowDialog();
            ShowRentalOrders();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
