using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Classes
{
    class SchoolRegister : BookBase
    {
        private string teacherName;
        private short numberOfStudents;

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }
        public short NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }

        public void PrintAnnualGrades(byte[] grades)
        {
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            sum /= grades.Length;
            Console.WriteLine($"The avarage grade is {sum:F2}.");
        }
    }
}
