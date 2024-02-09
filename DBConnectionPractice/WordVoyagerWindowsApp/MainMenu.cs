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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void displayInsertEmployee(object sender, EventArgs e)
        {
            InsertEmployee insertEmployee = new InsertEmployee();
            insertEmployee.Show();
        }

        private void displayEmployeeDeatils_Click(object sender, EventArgs e)
        {
            DisplayEmployees displayEmployee = new DisplayEmployees();
            displayEmployee.Show();
        }
    }
}
