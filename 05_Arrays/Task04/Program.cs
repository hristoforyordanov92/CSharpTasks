int[] numbers = new int[50];
int index = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        numbers[index] = i;
        index++;
    }
}

for (int i = 0; i < index; i++)
{
    // just a new line for good looks
    if (i % 10 == 0)
        Console.WriteLine();

    Console.Write("{0,4}", numbers[i]);
}
Console.WriteLine();