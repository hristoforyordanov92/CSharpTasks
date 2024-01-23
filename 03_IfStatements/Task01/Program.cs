Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("The number is neither even, nor odd.");
}
else if (num % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}