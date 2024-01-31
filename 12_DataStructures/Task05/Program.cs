namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "My name {}{{Ivan}} and my dog {Sharo}";

            Solution1(inputString);
            Solution2(inputString);
        }

        //Solution from the task
        static void Solution1(string inputString)
        {
            Stack<char> brackets = new Stack<char>();
            char[] charArray = inputString.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '{')
                {
                    if (brackets.Count > 0 && brackets.Peek() == '}')
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        brackets.Push(charArray[i]);
                    }
                }
                else if (charArray[i] == '}')
                {
                    if (brackets.Count > 0 && brackets.Peek() == '{')
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        brackets.Push(charArray[i]);
                    }
                }
            }

            if (brackets.Count == 0)
            {
                Console.WriteLine("There are equal number of brackets.");
            }
            else
            {
                Console.Write($"There are {brackets.Count} extra {brackets.Peek()}");
            }
            Console.WriteLine();
        }

        //My solution
        static void Solution2(string inputString)
        {
            int openBrackets = 0;
            int closedBrackets = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '{')
                {
                    openBrackets++;
                }
                else if (inputString[i] == '}')
                {
                    closedBrackets++;
                }
            }

            if (openBrackets > closedBrackets)
            {
                Console.WriteLine($"There are {openBrackets - closedBrackets} opening breackets more.");
            }
            else if (openBrackets < closedBrackets)
            {
                Console.WriteLine($"There are {closedBrackets - openBrackets} closing breackets more.");
            }
            else
            {
                Console.WriteLine("Both open and closing brackets are equal number.");
            }
        }
    }
}
