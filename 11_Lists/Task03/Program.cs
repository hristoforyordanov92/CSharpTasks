namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                numbers.Add(i);
            }

            // we have to be careful here, because if we were to use an ordinary 'for' loop from 0 to numbers.Count, we MIGHT end up with problems.
            // when we remove an item from the List, we create an empty index/slot in the collection. and since empty indexes/slots are not supposed to exist in the List,
            // all elements will move by 1 position to the left to fill the empty spot. so if we currently removed item with index 'i' (let's say index 9),
            // then all elements will move with 1 index to the left. this means that index 9 will now contain the item that a few moments ago was at index 10.
            // so the loop finishes and we increase 'i' by 1, becoming 10. but remember, since the items moved to the left by 1 index, we effectively never checked the item with the previous index 10 (current index 9).
            // so if we use an ordinary 'for' loop from 0 to N, we also have to correct 'i' by reducing it by 1 every single time we remove an item
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 10 == 0)
            //    {
            //        numbers.RemoveAt(i);
            //        i--;
            //    }
            //}

            // another way to solve it is by just creating a reverse loop and go from the back towards the front of the List.
            // this means that even if we remove an item at a specific index, the rest of the items will start moving to the left, but those are the ones we already checked, so it doesn't matter to us
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] % 10 == 0)
                {
                    numbers.RemoveAt(i);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{numbers[i],3}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
