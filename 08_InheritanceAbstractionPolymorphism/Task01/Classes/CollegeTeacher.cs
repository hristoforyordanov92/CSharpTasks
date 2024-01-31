using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Interfaces;

namespace Task01.Classes
{
    class CollegeTeacher : Teacher, IScientificArticles
    {
        public string WorkingInCollege { get; set; }

        public CollegeTeacher() : base() { }
        public CollegeTeacher(string firstName, string lastName, int yearsWorked, string teachingSubject, string workingInCollege) :
            base(firstName, lastName, yearsWorked, teachingSubject)
        {
            WorkingInCollege = workingInCollege;
        }

        public void PublishScientificArticles()
        {
            Console.WriteLine($"{FirstName} {LastName} is publishing scientific articles.");
        }
    }
}
