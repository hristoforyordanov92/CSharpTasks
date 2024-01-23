Console.Write("Enter the first integer: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Enter the second integer: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"{x} == {y} -> {IntegerEquality(x, y)}");

Console.WriteLine();

static bool IntegerEquality(int x, int y)
{
    return x == y;
}