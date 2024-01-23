Console.Write("Enter a circle's radius 'r': ");
double radius = Convert.ToDouble(Console.ReadLine());

//\u03A0 is the unicode symbol for PI, but it doesn't show on my console ;(
double perimeter = 2 * Math.PI * radius;
Console.WriteLine("\nPerimeter (circumference):");
Console.WriteLine("P = 2 * pi * r");
Console.WriteLine("P = 2 * {0:F2} * {1:F2}", Math.PI, radius);
Console.WriteLine("P = {0:F2} units", perimeter);

double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine("\nArea:");
Console.WriteLine("S = pi * (r * r)");
Console.WriteLine("S = {0:F2} * ({1:F2} * {1:F2})", Math.PI, radius);
Console.WriteLine("S = {0:F2} * {1:F2}", Math.PI, Math.Pow(radius, 2));
Console.WriteLine("S = {0:F2} square units\n", area);