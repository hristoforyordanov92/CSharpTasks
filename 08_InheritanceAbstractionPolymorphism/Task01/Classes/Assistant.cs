using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Interfaces;

namespace Task01.Classes
{
    class Assistant : Lecturer, IScientificArticles
    {
        public bool IsMainAssistant { get; set; }

        public Assistant() : base() { }
        public Assistant(string firstName, string lastName, int yearsWorked, string teachingInUniversity, bool isMainAssistant) :
            base(firstName, lastName, yearsWorked, teachingInUniversity)
        {
            IsMainAssistant = isMainAssistant;
        }

        public void Introduce()
        {
            string word = "";
            if (IsMainAssistant == false)
            {
                word = "not ";
            }
            Console.WriteLine($"My name is {FirstName} {LastName} and I am {word}main assistant.");
        }

        public void PublishScientificArticles()
        {
            Console.WriteLine("Publishing scientific articles.");
        }

        public override void CheckHomework()
        {
            Console.WriteLine($"Assistant {FirstName} {LastName} is checking homework.");
        }

        public void CheckExams()
        {
            Console.WriteLine("Assistant is checking exams.");
        }

        public override void AfternoonGreeting()
        {
            Console.WriteLine($"Assistant {FirstName} {LastName} says: Good afternoon!");
        }
    }
}
