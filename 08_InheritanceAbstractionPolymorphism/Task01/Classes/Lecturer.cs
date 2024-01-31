using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Interfaces;

namespace Task01.Classes
{
    class Lecturer : Person, IHomeworkChecking
    {
        public const int lecturesPerWeek = 10;
        public string TeachingInUniversity { get; set; }

        public virtual void CheckHomework()
        {
            Console.WriteLine("Lecturer is checking homework.");
        }

        public void DoExercise()
        {
            Console.WriteLine($"{FirstName} {LastName} is doing an exercise.");
        }
        public void DoExercise(string nameOfExercise)
        {
            Console.WriteLine($"{FirstName} {LastName} is doing the exercise in {nameOfExercise}.");
        }
        public void DoExercise(string nameOfExercise, int durationOfExercise)
        {
            Console.WriteLine($"{FirstName} {LastName} is doing the exercise in {nameOfExercise}. It will go for {durationOfExercise} hours.");
        }

        //Constructors
        public Lecturer() : base() { }
        public Lecturer(string firstName, string lastName, int yearsWorked, string teachingInUniversity) : base(firstName, lastName, yearsWorked)
        {
            TeachingInUniversity = teachingInUniversity;
        }

        public virtual void AfternoonGreeting()
        {
            Console.WriteLine($"Lecturer {FirstName} says: Good afternoon!");
        }
    }
}
