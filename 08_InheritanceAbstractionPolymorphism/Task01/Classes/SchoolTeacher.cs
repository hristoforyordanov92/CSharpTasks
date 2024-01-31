using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Classes
{
    class SchoolTeacher : Teacher
    {
        private string[] _classes = new string[5];

        public string[] Classes
        {
            get { return _classes; }
            set { _classes = value; }
        }

        public SchoolTeacher(string firstName, string lastName, int yearsWorked, string teachingSubject, string[] classes) :
            base(firstName, lastName, yearsWorked, teachingSubject)
        {
            for (int i = 0; i < Classes.Length; i++)
            {
                Classes[i] = classes[i];
            }
        }

        public void SayClasses()
        {
            for (int i = 0; i < Classes.Length; i++)
            {
                Console.WriteLine($"{FirstName} {LastName}: I got class {Classes[i]}.");
            }
        }

        public void EntertainChildren()
        {
            Console.WriteLine($"{FirstName} {LastName} is entertaining children.");
        }
    }
}
