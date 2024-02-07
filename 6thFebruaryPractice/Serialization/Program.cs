using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
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
            Console.WriteLine("Using FileStream and Binary Formatter");
            FileStream fs = new FileStream("C:\\Users\\ramya_mantripragada\\source\\repos\\DotNetTrainingPractice\\6thFebruaryPractice\\Serialization\\serialdata.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Console.WriteLine("Serializing Emp1 details to serialdata.txt");
            Employee emp1 = new Employee(101, "Ramya", "Jr. Software Engineer", "Engineering");
            //comment for Deserialization
            
            bf.Serialize(fs, emp1);
            //Uncomment for Deserialization
            /*Console.WriteLine("Deserializing Emp1 details in serialdata.txt and assigning to Emp2");
             Employee emp2 = (Employee)bf.Deserialize(fs);
             Console.WriteLine("Displaying details in Emp2");
             emp2.displayDetails();*/
            fs.Close();
           
            Console.ReadLine();
        }
    }
}
