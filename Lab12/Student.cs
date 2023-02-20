using System;

namespace Lab12;
public class Student
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string HairColor { get; set; }
    public int Age { get; set; }

    public Student(string name, string gender, string hairColor, int age)
    {
        Name = name;
        Gender = gender;
        HairColor = hairColor;
        Age = age;
    }


    public void AddAge(int ageToAdd)
    {
        Age += ageToAdd;
    }

    public void AddHairColor(int r, int g, int b)
    {
        HairColor = string.Format("rgb({0}, {1}, {2})", r, g, b);
    }

    public void AddGender(string gender)
    {
        Gender = gender;
    }

    public static string AddStudents(Student student1, Student student2)
    {
        string name1 = student1.Name.Substring(0, 3);
        string name2 = student2.Name.Substring(student2.Name.Length - 3);
        return name1 + name2;
    }

    public static int CombineAges(Student student1, Student student2)
    {
        int newAge = student1.Age + student2.Age;
        return newAge;
    }

    public static string CombineHairColor(Student student1, Student student2)
    {
        string haircolor1 = student1.HairColor.Substring(0, 3);
        string haircolor2 = student2.HairColor.Substring(student2.HairColor.Length - 3);
        return haircolor1 + haircolor2;
    }
}
