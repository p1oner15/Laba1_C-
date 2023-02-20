using System;
using System.Data.SqlTypes;
using System.Linq;


namespace Lab12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Nastya", "female", "blonde", 20);
            Student student2 = new Student("Sasha", "male", "brown", 22);
            string result = Student.AddStudents(student1, student2);
            Console.WriteLine(result); // prints "Aliob"
            string result2 = Student.CombineHairColor(student1, student2);
            Console.WriteLine(result2);
            int result3 = Student.CombineAges(student1, student2);
            Console.WriteLine(result3);

        }
    }
}