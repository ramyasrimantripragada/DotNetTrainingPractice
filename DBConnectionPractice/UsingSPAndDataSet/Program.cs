using System.Data.SqlClient;
using System;
using System.Linq;
using System.Data;
using System.Xml.Linq;

namespace UsingSPAndDataSet
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

        public void InsertEmployee(string name, string designation, string department)
        {
            SqlCommand command = new SqlCommand("uspInsertEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter nameParam = new SqlParameter()
            {
                ParameterName = "@Name",
                Value = name,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(nameParam);
            SqlParameter designationParam = new SqlParameter()
            {
                ParameterName = "@Designation",
                Value = designation,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(designationParam);
            SqlParameter departmentParam = new SqlParameter()
            {
                ParameterName = "@Department",
                Value = department,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(departmentParam);
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output,
            };
            command.Parameters.Add(idParam);
            command.ExecuteNonQuery();
            int id = int.Parse(idParam.Value.ToString());
            if (id > 0)
            {
                Console.WriteLine("Employee Data Inserted Successfully!!");
                Console.WriteLine("Employee ID: " + id);
            }
            else
                Console.WriteLine("Employee Data Insertion Failed!!");
        }

        public void DeleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand("uspDeleteEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                Value = id,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(idParam);
            int status = command.ExecuteNonQuery();
            if (status > 0)
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
            SqlCommand command = new SqlCommand("uspGetEmployeeRecords", connection);
            command.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "EMPLOYEE");
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet("EMPLOYEE");
            adapter.Fill(dataSet);
            Console.WriteLine("EmpId\tEmployee Name\tDesignation\tDepartment\tJoining Date");
            foreach(DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3] + "\t" + row[4]);
            }
        }

        public void UpdateEmployeeName(int empId, string name)
        {
            SqlCommand command = new SqlCommand("uspUpdateEmployeeName", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                Value = empId,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(idParam);
            SqlParameter nameParam = new SqlParameter()
            {
                ParameterName = "@Name",
                Value = name,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(nameParam);
            int status = command.ExecuteNonQuery();
            if (status > 0)
            {
                Console.WriteLine("Employee Name Updated Successfully!!");
            }
            else
            {
                Console.WriteLine("Employee Name Updation Failed!!");

            }
        }

        public void UpdateEmployeeDesignation(int empId, string designation)
        {
            SqlCommand command = new SqlCommand("uspUpdateEmployeeDesignation", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                Value = empId,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(idParam);
            SqlParameter designationParam = new SqlParameter()
            {
                ParameterName = "@Designation",
                Value = designation,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(designationParam);
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
            SqlCommand command = new SqlCommand("uspUpdateEmployeeDepartment", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                Value = empId,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(idParam);
            SqlParameter departmentParam = new SqlParameter()
            {
                ParameterName = "@Department",
                Value = department,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(departmentParam);
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
                Console.WriteLine("4.Delete Employee Record");
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
                        if (selection.SequenceEqual("y") || selection.SequenceEqual("Y"))
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
