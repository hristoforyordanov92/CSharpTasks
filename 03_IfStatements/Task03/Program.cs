Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a + " is greater than " + b);
}
else
{
    Console.WriteLine(b + " is greater than " + a);
}