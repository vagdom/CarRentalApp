using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VagnerCarRental
{
    [Serializable]
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string EmployeeName
        {
            get { return LastName + ", " + FirstName; }
        }

        public Employee()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            Title = "N/A";
        }

        public Employee(string fname, string lname, string title)
        {
            FirstName = fname;
            LastName = lname;
            Title = title;
        }
    }
}
