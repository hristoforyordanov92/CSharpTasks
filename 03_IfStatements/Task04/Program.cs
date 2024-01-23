Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("First solution:");

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a + " is the greatest number.");
    }
    else
    {
        Console.WriteLine(c + " is the greatest number.");
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine(b + " is the greatest number.");
    }
    else
    {
        Console.WriteLine(c + " is the greatest number.");
    }
}

Console.WriteLine();
Console.WriteLine("Second solution");

// second solution
int greatestNumber = a;

if (greatestNumber < b)
    greatestNumber = b;

if (greatestNumber < c)
    greatestNumber = c;

Console.WriteLine(greatestNumber + " is the greatest number.");