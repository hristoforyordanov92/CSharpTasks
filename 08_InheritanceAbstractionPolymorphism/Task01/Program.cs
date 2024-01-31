using Task01.Classes;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teach1 = new Teacher("Forko", "Forkov", 5, "Programming");
            teach1.AfternoonGreeting();
            teach1.CheckHomework();
            teach1.EveningGreeting();
            ShowPersonCount();

            string[] classes = new string[5] { "4A", "4B", "4C", "4D", "4E" };
            SchoolTeacher teach2 = new SchoolTeacher("Ivan", "Ivanov", 10, "Math", classes);
            teach2.AfternoonGreeting();
            teach2.CheckHomework();
            teach2.EntertainChildren();
            teach2.EveningGreeting();
            teach2.SayClasses();
            ShowPersonCount();

            CollegeTeacher teach3 = new CollegeTeacher("Gergan", "Gergev", 2, "Biology", "College of Idiots");
            teach3.AfternoonGreeting();
            teach3.CheckHomework();
            teach3.EveningGreeting();
            teach3.PublishScientificArticles();
            ShowPersonCount();

            Lecturer lect1 = new Lecturer("Gogo", "Gegev", 30, "University of Stupidity");
            lect1.AfternoonGreeting();
            lect1.CheckHomework();
            lect1.DoExercise();
            lect1.DoExercise("Math");
            lect1.DoExercise("English", 500);
            ShowPersonCount();

            Assistant lect2 = new Assistant("Pepi", "Dai-Edno-Kilo", 20, "University of Farts", false);
            lect2.AfternoonGreeting();
            lect2.CheckExams();
            lect2.CheckHomework();
            lect2.DoExercise();
            lect2.PublishScientificArticles();
            lect2.Introduce();
            ShowPersonCount();

            Assistant lect3 = new Assistant("Pop", "Dundurkov", 10, "University of Farts", true);
            lect3.AfternoonGreeting();
            lect3.CheckExams();
            lect3.CheckHomework();
            lect3.DoExercise();
            lect3.PublishScientificArticles();
            lect3.Introduce();
            ShowPersonCount();

            Professor proff = new Professor("Bai", "Zarko", 40, "University of Agroculture", "Big Boss");
            proff.AfternoonGreeting();
            proff.CheckHomework();
            proff.DoExercise();
            proff.GiveExams();
            proff.SayTitleAndYearsWorked();
            ShowPersonCount();

            Console.WriteLine("One more person count for testing purposes.");
            ShowPersonCount();
        }

        public static void ShowPersonCount()
        {
            Console.WriteLine($"People instantiated: {Person.numberOfPersonObjects}");
            Console.WriteLine();
        }
    }
}
