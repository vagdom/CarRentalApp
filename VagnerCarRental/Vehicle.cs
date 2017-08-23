using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VagnerCarRental
{
    [Serializable]
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int Passengers { get; set; }
        public string Condition { get; set; }
        public string Category { get; set; }
        public string Availability { get; set; }

        public Vehicle()
        {
            Make = "";
            Model = "";
            Doors = 4;
            Passengers = 4;
            Condition = "Excellent";
            Category = "Compact";
            Availability = "Available";
        }

        public Vehicle(string make, string model,
                       int doors, int passengers, string condition,
                       string category, string available)
        {
            Make = make;
            Model = model;
            Doors = doors;
            Passengers = passengers;
            Condition = condition;
            Category = category;
            Availability = available;
        }
    }
}
