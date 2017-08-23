using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VagnerCarRental
{
    public partial class EmployeeEditor : Form
    {
        public EmployeeEditor()
        {
            InitializeComponent();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            string strFirstName = txtFirstName.Text;
            string strLastName = txtLastName.Text;
            string strEmployeeName;

            if (strFirstName.Length == 0)
                strEmployeeName = strLastName;
            else
                strEmployeeName = strLastName + ", " + strFirstName;

            txtEmployeeName.Text = strEmployeeName;
        }
    }
}
