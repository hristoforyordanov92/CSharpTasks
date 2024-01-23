Console.Write("Enter the first number: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
double b = Convert.ToInt32(Console.ReadLine());

if (a < 0 && b < 0)
{
    Console.WriteLine("The resulting sign is positive (+).");
}
else if (a < 0 || b < 0)
{
    Console.WriteLine("The resulting sign is negative (-).");
}
else
{
    Console.WriteLine("The resulting sign is positive (+).");
}