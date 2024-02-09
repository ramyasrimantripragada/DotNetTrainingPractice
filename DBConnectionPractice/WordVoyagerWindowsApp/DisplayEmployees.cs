using EmployeeRecordManagement;
using System;
using System.Data;
using System.Windows.Forms;
 
namespace WordVoyagerWindowsApp
{
    public partial class DisplayEmployees : Form
    {
        public DisplayEmployees()
        {
            InitializeComponent();
          
        }

        private void DisplayEmployees_Load(object sender, EventArgs e)
        {
            EmployeeDB employeeDB = new EmployeeDB();
            employeeDB.CreateConnection();
            DataSet dataSet = employeeDB.DisplayEmployees();
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("No records in Employee Table!!");
            }
            employeeDB.CloseConnection();
        }

        private void onClickDeleteEmployee(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                var row = dataGridView1.SelectedRows[0];
                int id = (int)row.Cells[0].Value;
                EmployeeDB employeeDB = new EmployeeDB();
                employeeDB.CreateConnection();
                int status = employeeDB.DeleteEmployee(id);
                if (status > 0)
                {
                    MessageBox.Show("Employee Record with Employee ID: " + id + " Deleted Successfully!!");
                    this.DisplayEmployees_Load(this,EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Employee Record Deletion Failed!!");
                }

                employeeDB.CloseConnection();
            }
            else
            {
                MessageBox.Show("Please select an Employee Record to delete!!");
            }
        }

        private void onClickOpenUpdateEmployee(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var row = dataGridView1.SelectedRows[0];
                int id = (int)row.Cells[0].Value;
                var updateEmp = new UpdateEmployee((int)row.Cells[0].Value, (string)row.Cells[1].Value, (string)row.Cells[2].Value, (string)row.Cells[3].Value);
                updateEmp.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an Employee Record to Update!!");
            }
        }
    }
}
