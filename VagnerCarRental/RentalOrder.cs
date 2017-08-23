using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VagnerCarRental
{
    [Serializable]
    public class RentalOrder
    {
        public DateTime DateProcessed { get; set; }

        public string EmployeeNumber { get; set; }
        public string ClerkNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZIPCode { get; set; }
        public string VehicleTagNumber { get; set; }
        public string VehicleCondition { get; set; }
        public string TankLevel { get; set; }
        public int MileageStart { get; set; }
        public int MileageEnd { get; set; }
        public int MileageTotal { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }
        public int TotalDays { get; set; }
        public double RateApplied { get; set; }
        public double SubTotal { get; set; }
        public double TaxRate { get; set; }
        public double TaxAmount { get; set; }
        public double OrderTotal { get; set; }
        public double OrderStatus { get; set; }
        public string Notes { get; set; }
    }
}
