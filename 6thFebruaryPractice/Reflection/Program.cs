using System;
using System.Reflection;


namespace Reflection
{
    public class Employee
    {
        static int count = 0;
        int empId;
        string name;
        string designation;
        string department;

        public static void incrCount()
        {
            ++count;
        }

        public Employee(int empId, string name, string designation, string department)
        {
            this.empId = empId;
            this.name = name;
            this.designation = designation;
            this.department = department;
        }

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public string Name
        { 
            get { return name; } 
            set {  name = value; } 
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public string Department 
        {  
            get { return department; } 
            set {  department = value; } 
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
            Console.WriteLine("Printing Reflection of Program class with Main method using typeof() method");
            Type t = typeof(Program);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.IsValueType);
            Console.WriteLine(t.IsEnum);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Assembly.FullName);
            Console.WriteLine(t.BaseType);
            Console.ReadLine();
            Console.WriteLine("Using Assembly and printing Reflection Assembly's Reflection");
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Name of Assembly: " + assembly.FullName);
            foreach (Type type in assembly.GetTypes())
            {
                Console.WriteLine("Class: " + type.FullName);
                Console.WriteLine("Data Members of : " + type.FullName);
                foreach (var variable in type.GetProperties())
                {
                    Console.WriteLine(variable.Name);
                    Console.WriteLine(variable.GetType());
                }
                Console.WriteLine("Methods of " + type.FullName);
                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
                {
                    Console.WriteLine(method.Name);
                    foreach (var parameter in method.GetParameters())
                    {
                        Console.WriteLine(parameter.Name);
                        Console.WriteLine(parameter.ParameterType);
                    }
                }
                
            }
            Console.ReadLine();
        }
    }
}
