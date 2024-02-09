using EmployeeRecordManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordVoyagerWindowsApp
{
    public partial class InsertEmployee : Form
    {
        string EmployeeName, Designation, Department;
        public InsertEmployee()
        {
            this.EmployeeName = string.Empty;
            this.Designation = string.Empty;
            this.Department = string.Empty;
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeName = name.Text.Trim();
        }

        private void insertEmp_Click(object sender, EventArgs e)
        {
            if (EmployeeName.Length == 0)
            {
                MessageBox.Show("Employee Name cannot be empty");
                return;
            }
            else if (EmployeeName.Length > 100)
            {
                MessageBox.Show("Employee Name must be less than or equal to 100 characters");
                return;
            }
            else if (Designation.Length == 0)
            {
                MessageBox.Show("Employee Designation cannot be empty");
                return;
            }
            else if (Designation.Length > 100)
            {
                MessageBox.Show("Employee Designation must be less than or equal to 100 characters");
                return;
            }
            else if (Department.Length == 0)
            {
                MessageBox.Show("Department cannot be empty");
                return;
            }
            else if (Department.Length > 100)
            {
                MessageBox.Show("Department must be less than or equal to 100 characters");
                return;
            }
            else
            {
                EmployeeDB employeeDB = new EmployeeDB();
                employeeDB.CreateConnection();
                int id = employeeDB.InsertEmployee(EmployeeName, Designation, Department);
                if(id > 0)
                {
                    MessageBox.Show("Employee Data Inserted Successfully!!\nEmployee ID: " + id);
                    name.Text = "";
                    department.Text = "";
                    designation.Text = "";
                }
                else
                {
                    MessageBox.Show("Employee Data Insertion Failed!!");
                }
               
                employeeDB.CloseConnection();
            }

        }

      

        private void designation_TextChanged(object sender, EventArgs e)
        {
            this.Designation = designation.Text.Trim();
        }

        private void department_TextChanged(object sender, EventArgs e)
        {
            this.Department = department.Text.Trim();
        }
    }
}
