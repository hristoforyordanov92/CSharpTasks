namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution 1 with a Stack<T>");
            Solution1();
            Console.WriteLine("\n");

            Console.WriteLine("Solution 2 with a LinkedList<T>");
            Solution2();

            Console.WriteLine("\n");

            Console.WriteLine("Solution 3 with a LinkedList<T> (recursion / not reliable for a lot of elements)");
            Solution3();

            Console.WriteLine("\n");

            Console.WriteLine("Solution 4 with a LinkedList<T> (a while loop to print out in reverse)");
            Solution4();

            Console.WriteLine();
        }

        //Solution with a stack
        static void Solution1()
        {
            Stack<int> stack = new();

            for (int i = 1; i < 51; i++)
            {
                stack.Push(i);
            }

            int totalPops = stack.Count;
            for (int i = 0; i < totalPops; i++)
            {
                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{stack.Pop(),3}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //Linked list (adding first and print normally)
        static void Solution2()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 1; i < 51; i++)
            {
                list.AddFirst(i);
            }

            int counter = 0;
            foreach (var item in list)
            {
                if (counter % 20 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{item,3}");
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        //Linked list (adding last and printing backwards with recursion)
        static void Solution3()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 1; i < 51; i++)
            {
                list.AddLast(i);
            }

            PrintLinkedListBackwards(list.Last);

            Console.WriteLine();
            Console.WriteLine();
        }

        //Can't belive I wrote this and it actually worked :D
        static LinkedListNode<int> PrintLinkedListBackwards(LinkedListNode<int> lastElement, int elementsPerRow = 20, int dontTouchThisVariblePlease = 0)
        {
            if (dontTouchThisVariblePlease % elementsPerRow == 0)
            {
                Console.WriteLine();
            }
            if (lastElement.Previous == null)
            {
                Console.Write($"{lastElement.Value,3}");
                return lastElement;
            }
            Console.Write($"{lastElement.Value,3}");
            return PrintLinkedListBackwards(lastElement.Previous, elementsPerRow, dontTouchThisVariblePlease + 1);
        }

        //Linked list (adding last and printing backwards with a while loop)
        static void Solution4()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 1; i < 51; i++)
            {
                list.AddLast(i);
            }

            int counter = 0;
            LinkedListNode<int> node = list.Last;
            while (true)
            {
                if (counter % 20 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{node.Value,3}");
                node = node.Previous;
                if (node == null)
                {
                    break;
                }
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
