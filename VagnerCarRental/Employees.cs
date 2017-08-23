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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        internal void ShowEmployees()
        {
            BinaryFormatter bfmEmployees = new BinaryFormatter();
            Dictionary<string, Employee> lstEmployees = new Dictionary<string, Employee>();
            // This is the file that holds the list of employees
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

                    // Before displaying the employees, empty the list view
                    lvwEmployees.Items.Clear();
                    // This variable will allow us to identify the odd and even indexes
                    int i = 1;
                    // Use the KeyValuePair class to visit each key/value item
                    foreach (KeyValuePair<string, Employee> kvp in lstEmployees)
                    {
                        ListViewItem lviEmployee = new ListViewItem(kvp.Key);

                        Employee empl = kvp.Value;

                        lviEmployee.SubItems.Add(empl.FirstName);
                        lviEmployee.SubItems.Add(empl.LastName);
                        lviEmployee.SubItems.Add(empl.EmployeeName);
                        lviEmployee.SubItems.Add(empl.Title);

                        if (i % 2 == 0)
                        {
                            lviEmployee.BackColor = Color.FromArgb(255, 128, 0);
                            lviEmployee.ForeColor = Color.White;
                        }
                        else
                        {
                            lviEmployee.BackColor = Color.FromArgb(128, 64, 64);
                            lviEmployee.ForeColor = Color.White;
                        }

                        lvwEmployees.Items.Add(lviEmployee);

                        i++;
                    }
                }
            }
        }



        private void Employees_Load(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeEditor editor = new EmployeeEditor();
            BinaryFormatter bfBethesdaCarRental = new BinaryFormatter();
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
                    lstEmployees = (Dictionary<string, Employee>)bfBethesdaCarRental.Deserialize(stmEmployees);
                }
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtEmployeeNumber.Text == "")
                {
                    MessageBox.Show("You must provide an employee number.",
                                    "Bethesda Car Rental",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (editor.txtLastName.Text == "")
                {
                    MessageBox.Show("You must provide the employee's last name.",
                                    "Bethesda Car Rental",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Employee empl = new Employee();

                empl.FirstName = editor.txtFirstName.Text;
                empl.LastName = editor.txtLastName.Text;
                empl.Title = editor.txtTitle.Text;
                lstEmployees.Add(editor.txtEmployeeNumber.Text, empl);

                using (FileStream fsBethesdaCarRental = new FileStream(strFilename,
                                                        FileMode.Create,
                                                        FileAccess.Write,
                                                        FileShare.Write))
                {
                    bfBethesdaCarRental.Serialize(fsBethesdaCarRental, lstEmployees);
                }
            }

            ShowEmployees();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
