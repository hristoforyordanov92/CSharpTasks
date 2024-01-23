Console.Write("Enter the points: ");
int points = Convert.ToInt32(Console.ReadLine());

if (points < 4)
{
    points *= 5;
}
else if (points < 7)
{
    points *= 10;
}
else
{
    points *= 50;
}
Console.WriteLine(points);