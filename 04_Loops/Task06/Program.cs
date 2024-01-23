Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter K: ");
int k = int.Parse(Console.ReadLine());

double nFactorial = 1;
double kFactorial = 1;
double nkFactorial = 1;
double result;

for (int i = 1; i <= n; i++)
{
    nFactorial *= i;
}

for (int i = 1; i <= k; i++)
{
    kFactorial *= i;
}

for (int i = 1; i <= n - k; i++)
{
    if (n - k <= 0)
    {
        nkFactorial = 1;
        break;
    }
    else
    {
        nkFactorial *= i;
    }
}

result = nFactorial * kFactorial / nkFactorial;
Console.WriteLine("{0} * {1} / {2} = {3}", nFactorial, kFactorial, nkFactorial, result);