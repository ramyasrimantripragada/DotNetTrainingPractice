using System;
using System.Text.Json;

namespace Serialization4._8
{
    public class Employee
    {
        int empId;
        string name;
        string designation;
        string department;

        public Employee(int empId, string name, string designation, string department)
        {
            this.empId = empId;
            this.name = name;
            this.designation = designation;
            this.department = department;
        }

        public void displayDetails()
        {
            Console.WriteLine("EmpId: " + empId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Department: " + department);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Installed System.Text.Json using NuGet");
            var emp1 = new Employee(101, "Ramya", "Jr. Software Engineer", "Engineering");
            Console.WriteLine("Serializing to a string using json");
            //throws error because the c# compiler version is 7.3 for .NetFramework and JsonSerializer requires 8.0 or higher
            string serializedData = JsonSerializer.Serialize(emp1);

            Console.WriteLine(serializedData);
          //Employee emp2 = JsonSerializer.Deserialize<Employee>(serializedData);
           // emp2.displayDetails();
            Console.ReadLine();
        }
    }
}
