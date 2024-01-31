using Task01.CustomExceptions;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());

                    SumNumbers(firstNumber, secondNumber);
                    //break; //Commented it out so the application is tester-friendly! A.K.A. endless fun!
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message} Please, enter new numbers!");
                    Console.WriteLine();
                }

                // this below was the old code. good that it handles each exception type, but does the exact same thing, so it's pointlessly repetitive
                // all exception are of type Exception, so you can catch them all using this type.
                // if for some reason you need to handle a specific exception in a special way, then you can always add another 'catch' with the specific type ABOVE the 'Exception' base type.

                //catch (EqualNumbersException ex)
                //{
                //    Console.Write(ex.Message);
                //    Console.WriteLine(" Please, enter new numbers!\n");
                //}
                //catch (NegativeNumberException ex)
                //{
                //    Console.Write(ex.Message);
                //    Console.WriteLine(" Please, enter new numbers!\n");
                //}
                //catch (FormatException ex)
                //{
                //    Console.Write(ex.Message);
                //    Console.WriteLine(" Please, enter new numbers!\n");
                //}
                //catch (OverflowException ex)
                //{
                //    Console.Write(ex.Message);
                //    Console.WriteLine(" Please, enter new numbers!\n");
                //}
            }
        }

        static void SumNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                throw new EqualNumbersException("Numbers must NOT be equal!");
            }
            else if (firstNumber < 0 || secondNumber < 0)
            {
                throw new NegativeNumberException("Both numbers must be positive!");
            }
            else
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}\n");
            }
        }
    }
}
