using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects_5_Q2
{
    internal class School
    {
        private string SchoolName;
        private string Location;
        private Student[] Students;
        private int student_count;

        public School(string name, string loc,int Max_student)
        {
            SchoolName = name;
            Location = loc;
            Students= new Student[Max_student];
            student_count = 0;
        }
        public void AddStudent(Student student)
        {
            Students[student_count++] = student;
        }
        public string GetName()
        {
            return SchoolName;
        }
        public string Getlocation()
        {
            return Location;
        }
        public Student[] GetStudents()
        {
            return Students;
        }
        }
    }
