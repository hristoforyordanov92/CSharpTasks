//Multiple integers
int num1, num2, num3, num4, result1;
Console.Write("Enter first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fourth number: ");
num4 = Convert.ToInt32(Console.ReadLine());
result1 = num1 + num2 + num3 + num4;
Console.WriteLine("The sum of the four numbers is {0}.", result1);

Console.WriteLine();

//Single integer
int result2 = 0;
Console.Write("Enter first number: ");
result2 += Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
result2 += Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
result2 += Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fourth number: ");
result2 += Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The sum of the four numbers is {0}.", result2);