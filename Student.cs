using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects_5_Q2
{
    internal class Student
    {
        private int Student_ID;
        private string name;
        private int[] grades;
        private int grade_count;

        public Student(int ID, string name)
        {
            this.Student_ID = ID;
            this.name = name;
            grades = new int[5];
            grade_count = 0;

        }
        public void SetGrade(int grade)
        {
            grades[grade_count] = grade;
            grade_count++;
        }
        public double CalculateAverageGrade()
        {
            if (grade_count == 0)
                return 0;
                double sum = 0;

            for(int i = 0; i < grade_count; i++)
            {
                sum += grades[i];
            }
            return sum/grade_count;
        }
        public int GetStudentID()
        {
            return Student_ID;
        }
        public string GetName()
        {
            return name;
        }
    }
}
