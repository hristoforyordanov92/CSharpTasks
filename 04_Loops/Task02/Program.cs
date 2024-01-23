Console.Write("N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Numbers that can be divided by 3 AND 7 will be missing from the table below.");

for (int i = 1; i <= n; i++)
{
    if (i % 3 != 0 || i % 7 != 0)
    {
        Console.Write("{0,5}", i);
    }
    else
    {
        Console.Write("     ");
    }

    if (i % 20 == 0)
    {
        Console.WriteLine();
    }
}