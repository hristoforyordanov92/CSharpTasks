Console.Write("N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    // this format and the if statement are not required, but make for a prettier visualization of a lot of numbers.
    // you can try with N = 2000 for example
    Console.Write("{0,5}", i);
    if (i % 20 == 0)
    {
        Console.WriteLine();
    }
}

Console.WriteLine();