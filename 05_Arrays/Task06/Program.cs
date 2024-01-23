int matrixRows = 3;
int matrixCols = 3;
int[,] matrix = new int[matrixRows, matrixCols];
Random rnd = new Random();

Console.WriteLine();

//populate and print the matrix
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(0, 100);
        Console.Write("{0,3}", matrix[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine();

//find highest in rows
Console.WriteLine("HIGHEST number in each ROW:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int max = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (max < matrix[i, j])
        {
            max = matrix[i, j];
        }
    }
    Console.WriteLine("Row {0} has the highest value of {1}.", i + 1, max);
}
Console.WriteLine();

Console.WriteLine("LOWEST number in each ROW:");
//find lowest in rows
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int min = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (min > matrix[i, j])
        {
            min = matrix[i, j];
        }
    }
    Console.WriteLine("Row {0} has the lowest value of {1}.", i + 1, min);
}
Console.WriteLine();

Console.WriteLine("HIGHEST number in each COLUMN:");
//find highest in columns
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int max = matrix[0, i];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (max < matrix[j, i])
        {
            max = matrix[j, i];
        }
    }
    Console.WriteLine("Column {0} has the highest value of {1}.", i + 1, max);
}
Console.WriteLine();

Console.WriteLine("LOWEST number in each COLUMN:");
//find lowest in columns
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int min = matrix[0, i];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (min > matrix[j, i])
        {
            min = matrix[j, i];
        }
    }
    Console.WriteLine("Column {0} has the lowest value of {1}.", i + 1, min);
}
Console.WriteLine();

int matrixMax = matrix[0, 0];
int matrixMin = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrixMax < matrix[j, i])
        {
            matrixMax = matrix[j, i];
        }
        if (matrixMin > matrix[j, i])
        {
            matrixMin = matrix[j, i];
        }
    }
}
Console.WriteLine("The HIGHEST value in this matrix is {0}.", matrixMax);
Console.WriteLine("The LOWEST value in this matrix is {0}.\n", matrixMin);