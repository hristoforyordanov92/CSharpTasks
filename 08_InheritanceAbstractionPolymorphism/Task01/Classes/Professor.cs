using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Classes
{
    class Professor : Lecturer
    {
        public string Title { get; set; }

        public Professor() : base() { }
        public Professor(string firstName, string lastName, int yearsWorked, string teachingInUniversity, string title) :
            base(firstName, lastName, yearsWorked, teachingInUniversity)
        {
            Title = title;
        }

        public void SayTitleAndYearsWorked()
        {
            Console.WriteLine($"My title is {Title} and i have worked for {YearsWorked} years.");
        }

        public override void CheckHomework()
        {
            Console.WriteLine($"Professor {FirstName} {LastName} is checking homework.");
        }

        public void GiveExams()
        {
            Console.WriteLine($"Professor {FirstName} {LastName} is giving exams.");
        }

        public override void AfternoonGreeting()
        {
            Console.WriteLine($"Professor {FirstName} {LastName} says: Good afternoon!");
        }
    }
}
