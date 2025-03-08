using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects_5_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Students");
            Student std1=new Student(1,"Zeenat");
            Student std2 = new Student(2, "Seerat");
            Student std3 = new Student(3, "Muskan");

            Console.WriteLine("Adding Teachers");
            Teacher teacher1 = new Teacher(1, "Sadia", "Oop");
            Teacher teacher2 = new Teacher(2, "Sana", "Stat");

            Console.WriteLine("Managing School");
            School school = new School("NTU", "FSD", 20);

            Console.WriteLine("Adding Student to School");
            school.AddStudent(std1);
            school.AddStudent(std2);
            school.AddStudent(std3);

            Console.WriteLine("Assigning Grade");
            teacher1.AssignGrade(std1, 92);
            teacher1.AssignGrade(std2, 10);
            teacher2.AssignGrade(std1, 50);
            teacher2.AssignGrade(std3, 60);

            Console.WriteLine("Display Average");
            Console.WriteLine($"{std1.GetName()} Has Average {std1.CalculateAverageGrade()}");
            Console.WriteLine($"{std2.GetName()} Has Average {std2.CalculateAverageGrade()}");
            Console.WriteLine($"{std3.GetName()} Has Average {std3.CalculateAverageGrade()}");

            Console.WriteLine("Display School Information");
            Console.WriteLine(school.GetName());
            Console.WriteLine(school.Getlocation());

            foreach (Student std in school.GetStudents())
            {
                if (std != null) { 
                Console.WriteLine(std.GetName());
                Console.WriteLine(std.GetStudentID());
            }
            }
            Console.ReadLine();
        }
    }
}
