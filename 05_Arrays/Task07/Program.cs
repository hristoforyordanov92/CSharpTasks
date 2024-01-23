Console.Write("Matrix rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Matrix columns: ");
int cols = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, cols];
int fillData = 1;

//vertical fill
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = fillData;
        fillData++;
    }
}

Console.WriteLine();
Console.WriteLine("Vertical fill:");
//print matrix
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("{0,3}", matrix[j, i]);
    }
    Console.WriteLine();
}
Console.WriteLine();
fillData = 1;

Console.WriteLine("Horizontal fill:");
//horizontal fill
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[j, i] = fillData;
        fillData++;
    }
}

//print matrix
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("{0,3}", matrix[j, i]);
    }
    Console.WriteLine();
}
Console.WriteLine();