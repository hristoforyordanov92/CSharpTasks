using System;

namespace Task01.Classes
{
    abstract class Person
    {
        public static int numberOfPersonObjects = 0;

        protected string firstName;
        protected string lastName;
        private int yearsWorked;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        protected int YearsWorked
        {
            get { return yearsWorked; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Years worked must be above 0.");
                }
                else
                {
                    yearsWorked = value;
                }
            }
        }

        public Person()
        {
            numberOfPersonObjects++;
        }

        public Person(string firstName, string lastName, int yearsWorked) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            YearsWorked = yearsWorked;
        }
    }
}