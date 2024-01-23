int[] inputArray = new int[10];

FillArrayWithData(inputArray);

PrintArray(inputArray);

Console.Write("Enter your integer number: ");
int inputData = int.Parse(Console.ReadLine());
Console.WriteLine();

bool dataFound = NumberInArray(inputArray, inputData);
Console.WriteLine($"The array {(dataFound ? "contains" : "does not contain")} your input data.");

Console.WriteLine();

//The method required by the task
static bool NumberInArray(int[] array, int number)
{
    bool contains = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"array[{i}] contains your data ({number}).");
            contains = true;
        }
    }

    return contains;
}

//A method to fill an array with some random numbers
static void FillArrayWithData(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = rnd.Next(1, 20);
    }
}

//A method to print an array
static void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i],3} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}