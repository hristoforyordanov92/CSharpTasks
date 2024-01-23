int max = int.MinValue;

Console.Write("Enter the amount of numbers to check: ");
int amountOfNumbers = int.Parse(Console.ReadLine());

for (int i = 0; i < amountOfNumbers; i++)
{
    Console.Write("Enter number {0} out of {1}: ", i + 1, amountOfNumbers);
    int number = int.Parse(Console.ReadLine());
    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine($"The highest number is {max}.");
Console.WriteLine();