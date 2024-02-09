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
using System.Xml.Linq;

namespace WordVoyagerWindowsApp
{
    public partial class UpdateEmployee : Form
    {
        private string EmployeeName;
        private string Designation;
        private string Department;
        private int EmployeeID;
        public UpdateEmployee()
        {
            this.EmployeeName= string.Empty;
            this.Designation= string.Empty;
            this.Department= string.Empty;
            this.EmployeeID= -1;
            InitializeComponent();
        }

        public UpdateEmployee(int empId, string name, string empdesignation, string empdepartment)
        {
            this.EmployeeID = empId;
            this.EmployeeName = name;
            this.Designation = empdesignation;
            this.Department= empdepartment;
            InitializeComponent();
        }

        private void onChangeName(object sender, EventArgs e)
        {
            this.EmployeeName=updatename.Text;
        }

        private void onChangeDesignation(object sender, EventArgs e)
        {
            this.Designation=designation.Text;
        }

        private void onChangeDepartment(object sender, EventArgs e)
        {
            this.Department = department.Text;
        }

        private void onClickUpdateEmployee(object sender, EventArgs e)
        {
            if (this.EmployeeName.Length == 0)
            {
                MessageBox.Show("Employee Name cannot be empty");
                return;
            }
            else if (this.EmployeeName.Length > 100)
            {
                MessageBox.Show("Employee Name must be less than or equal to 100 characters");
                return;
            }
            else if (this.Designation.Length == 0)
            {
                MessageBox.Show("Employee Designation cannot be empty");
                return;
            }
            else if (this.Designation.Length > 100)
            {
                MessageBox.Show("Employee Designation must be less than or equal to 100 characters");
                return;
            }
            else if (this.Department.Length == 0)
            {
                MessageBox.Show("Department cannot be empty");
                return;
            }
            else if (this.Department.Length > 100)
            {
                MessageBox.Show("Department must be less than or equal to 100 characters");
                return;
            }
            else
            {
                EmployeeDB employeeDB = new EmployeeDB();
                employeeDB.CreateConnection();
                int status = employeeDB.UpdateEmployeeDetails(EmployeeID, EmployeeName, Designation, Department);
                if (status > 0)
                {
                    MessageBox.Show("Employee Data Updated Successfully!!");
                }
                else
                {
                    MessageBox.Show("Employee Data Updation Failed!!");
                }

                employeeDB.CloseConnection();
            }

        }

        private void onLoadSetInputValues(object sender, EventArgs e)
        {
            updatename.Text = this.EmployeeName;
            department.Text = this.Department;
            designation.Text = this.Designation;

        }

        private void UpdateEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplayEmployees displayEmployees = new DisplayEmployees();
            displayEmployees.Show();
        }
    }
}
