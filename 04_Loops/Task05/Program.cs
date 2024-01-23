Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter K: ");
int k = int.Parse(Console.ReadLine());

double nRes = 1;
double kRes = 1;
double total;

for (int i = 1; i <= n; i++)
{
    nRes *= i;
}

for (int i = 1; i <= k; i++)
{
    kRes *= i;
}

total = nRes / kRes;
Console.WriteLine("{0} / {1} = {2}", nRes, kRes, total);