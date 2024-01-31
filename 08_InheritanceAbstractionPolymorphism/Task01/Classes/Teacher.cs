using System;
using Task01.Interfaces;

namespace Task01.Classes
{
    class Teacher : Person, IHomeworkChecking
    {
        public string TeachingSubject { get; set; }

        public Teacher() : base()
        {
        }

        public Teacher(string firstName, string lastName, int yearsWorked, string teachingSubject) : base(firstName, lastName, yearsWorked)
        {
            TeachingSubject = teachingSubject;
        }

        public void CheckHomework()
        {
            Console.WriteLine($"Teacher {FirstName} {LastName} is checking homework.");
        }

        public void AfternoonGreeting()
        {
            Console.WriteLine($"{FirstName} {LastName} says: Good afternoon!");
        }

        public void EveningGreeting()
        {
            Console.WriteLine($"{FirstName} {LastName} says: Good evening!");
        }
    }
}
