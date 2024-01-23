Console.Write("Enter the first side of the trianle: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second side of the trianle: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third side of the trianle: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < b + a)
{
    Console.WriteLine("This can be a triangle.");
}
else
{
    Console.WriteLine("This can't be a triangle.");
}