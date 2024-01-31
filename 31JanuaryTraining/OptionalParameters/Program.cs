using System;

namespace OptionalParameters
{
    internal class Program
    {
        static void printEmployeeInfo(int empId, string name = "John Doe", int age = 22, string gender = "Male")
        {
            Console.WriteLine("EmpId: " + empId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " +  age);
            Console.WriteLine("Gender: " +  gender);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sending only EmpId");
            printEmployeeInfo(1);
            Console.WriteLine("Sending EmpId and name");
            printEmployeeInfo(1, "Rose");
            Console.WriteLine("Sending EmpId, name using named param");
            printEmployeeInfo(1, name: "Rose");
            Console.WriteLine("Sending EmpId, age using named param");
            printEmployeeInfo(1, age: 25);
            Console.WriteLine("Sending EmpId, gender using named param");
            printEmployeeInfo(1, gender: "Female");
            Console.WriteLine("Sending EmpId, name and age using named param randomly");
            printEmployeeInfo(1, gender: "Female", name: "Rose");
            Console.WriteLine("Sending All params");
            printEmployeeInfo(1, "Rose", 25, "Female");
            Console.ReadLine();
        }
    }
}
