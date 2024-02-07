using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class Student
    {
        public int roll;
        public string name;

        public void display()
        {
            Console.WriteLine("Roll: " + roll);
            Console.WriteLine("Name: " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.roll = 1;
            s.name = "John Doe";
            s.display();
            Console.WriteLine("Serializing and writing to file");
            TextWriter writer = new StreamWriter("C:\\Users\\ramya_mantripragada\\source\\repos\\DotNetTrainingPractice\\6thFebruaryPractice\\XMLSerialization\\student.xml", true);
            var serializer = new XmlSerializer(typeof(Student));
            serializer.Serialize(writer, s);
            writer.Close();
            Console.WriteLine("Deserializing and writing to console");
            var myFileStream = new FileStream("C:\\Users\\ramya_mantripragada\\source\\repos\\DotNetTrainingPractice\\6thFebruaryPractice\\XMLSerialization\\student.xml", FileMode.Open);
            var myObject = (Student)serializer.Deserialize(myFileStream);
            myObject.display();
            Console.ReadLine();

        }
    }
}
