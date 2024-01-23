Console.Write("Enter the triangle's base 'b': ");
int triangleBase = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the triangle's height 'h': ");
int triangleHeight = Convert.ToInt32(Console.ReadLine());

double result = (double)(triangleBase * triangleHeight) / 2;
Console.WriteLine("\n'A' - triangle's area\n");
Console.WriteLine("A = (b * h) / 2");
Console.WriteLine("A = ({0} * {1}) / 2", triangleBase, triangleHeight);
Console.WriteLine("A = {0} / 2", result * 2);
Console.WriteLine("A = {0:F2} square units\n", result);