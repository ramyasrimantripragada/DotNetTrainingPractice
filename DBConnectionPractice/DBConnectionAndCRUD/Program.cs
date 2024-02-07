using System.Data.SqlClient;
using System;
using System.Linq;

namespace DBConnectionAndCRUD
{


    public class ManageDB
    {
        SqlConnection connection;
        public void CreateConnection()
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "data source=EPINHYDW0B9D\\SQLEXPRESS; Initial Catalog= WordVoyager; Integrated Security=True";
            this.connection.Open();
        }

        public void InsertEmployee(string Name, string Designation, string Department)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO EMPLOYEE(Name,Designation,Department) " +
                "VALUES('" + Name + "','" + Designation + "','" + Department + "') " + "SELECT SCOPE_IDENTITY()";
            command.Connection = this.connection;
            int id = Convert.ToInt32(command.ExecuteScalar());
            if(id>0)
            {
                Console.WriteLine("Employee Data Inserted Successfully!!");
                Console.WriteLine("Employee ID: " + id);
            }
            else
                Console.WriteLine("Employee Data Insertion Failed!!");
        }

        public void DeleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM EMPLOYEE WHERE EmployeeId="+id;
            command.Connection = this.connection;
            int status = command.ExecuteNonQuery();
            if(status>0)
            {
                Console.WriteLine("Employee Record Deleted Successfully!!");
            }
            else
            {
                Console.WriteLine("Employee Record Deletion Failed!!");
            }
        }

        public void DisplayEmployees()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM EMPLOYEE";
            command.Connection = this.connection;
            SqlDataReader sqlDataReader = command.ExecuteReader();
            Console.WriteLine("EmpId\tEmployee Name\tDesignation\tDepartment\tJoining Date");
            while (sqlDataReader.Read() == true)
            {
                Console.WriteLine(sqlDataReader[0] + "\t" + sqlDataReader[1] + "\t" + sqlDataReader[2] + "\t" + sqlDataReader[3] + "\t" + sqlDataReader[4]);
            }
            sqlDataReader.Close();
        }

        public void UpdateEmployeeName(int empId,string name)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE EMPLOYEE SET Name='" + name + "' WHERE EmployeeId=" + empId;
            command.Connection = this.connection;
            int status = command.ExecuteNonQuery();
            if(status>0)
            {
                Console.WriteLine("Employee Name Updated Successfully!!");
            }
            else
            {
                Console.WriteLine("Employee Name Updation Failed!!");

            }
        }

        public void UpdateEmployeeDesignation(int empId,string designation)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE EMPLOYEE SET Designation='" + designation + "' WHERE EmployeeId=" + empId;
            command.Connection = this.connection;
            int status = command.ExecuteNonQuery();
            if (status > 0)
            {
                Console.WriteLine("Employee Designation Updated Successfully!!");
            }
            else
            {
                Console.WriteLine("Employee Designation Updation Failed!!");

            }
        }

        public void UpdateEmployeeDepartment(int empId, string department)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE EMPLOYEE SET Department='" + department + "' WHERE EmployeeId=" + empId;
            command.Connection = this.connection;
            int status = command.ExecuteNonQuery();
            if (status > 0)
            {
                Console.WriteLine("Employee Department Updated Successfully!!");
            }
            else
            {
                Console.WriteLine("Employee Department Updation Failed!!");

            }
        }

        public void CloseConnection()
        {
            this.connection.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ManageDB manageDB = new ManageDB();
            manageDB.CreateConnection();
            //variables for taking input inside switch
            string name, department, designation, selection;
            int empId, choice;
            bool flag = true; //flag for breaking while loop
            while (flag)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.Display Employee Records");
                Console.WriteLine("2.Insert Employee Record");
                Console.WriteLine("3.Update Employee Details");
                Console.WriteLine("4.Delete EMployee Record");
                Console.WriteLine("5.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    //displaying employee table records
                    case 1:
                        manageDB.DisplayEmployees();
                        break;

                    //inserting new employee record
                    case 2:
                        Console.Write("Enter Employee Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Employee Designation: ");
                        designation = Console.ReadLine();
                        Console.Write("Enter Employee Department: ");
                        department = Console.ReadLine();
                        manageDB.InsertEmployee(name, designation, department);
                        break;

                    //Updating employee record by empId
                    case 3:
                        Console.Write("Enter Employee ID: ");
                        empId = int.Parse(Console.ReadLine());
                        Console.Write("Do you want to update Name of Employee[y/n]: ");
                        selection = Console.ReadLine();
                        if(selection.SequenceEqual("y") || selection.SequenceEqual("Y"))
                        {
                            Console.Write("Enter Employee Name: ");
                            name = Console.ReadLine();
                            manageDB.UpdateEmployeeName(empId, name);
                        }
                        Console.Write("Do you want to update Designation of Employee[y/n]: ");
                        selection = Console.ReadLine();
                        if (selection.SequenceEqual("y") || selection.SequenceEqual("Y"))
                        {
                            Console.Write("Enter Employee Designation: ");
                            designation = Console.ReadLine();
                            manageDB.UpdateEmployeeDesignation(empId, designation);
                        }
                        Console.Write("Do you want to update Department of Employee[y/n]: ");
                        selection = Console.ReadLine();
                        if (selection.SequenceEqual("y") || selection.SequenceEqual("Y"))
                        {
                            Console.Write("Enter Employee Department: ");
                            department = Console.ReadLine();
                            manageDB.UpdateEmployeeDepartment(empId, department);
                        }
                        break;

                    //deleting employee record by empId
                    case 4:
                        Console.Write("Enter Employee ID: ");
                        empId = int.Parse(Console.ReadLine());
                        manageDB.DeleteEmployee(empId);
                        break;

                    //other than above options, loop will be broken
                    default:
                        flag = false;
                        continue;
                }
                Console.WriteLine("Enter any key to continue...");
                Console.ReadLine();
            }
            manageDB.CloseConnection();
            Console.WriteLine("Exited!! Enter any key to close!!");
            Console.ReadLine();
        }
    }
}
