int[] arrayA = new int[10];
int[] arrayB = new int[10];

Random rnd = new Random();

//fill those arrays with some fake data
for (int i = 0; i < 10; i++)
{
    arrayA[i] = rnd.Next(0, 20);
    arrayB[i] = rnd.Next(0, 20);
}

for (int i = 0; i < arrayA.Length; i++)
{
    for (int j = 0; j < arrayB.Length; j++)
    {
        if (arrayA[i] == arrayB[j])
        {
            Console.WriteLine("arrayA[{0}] = arrayB[{1}] = {2}", i, j, arrayA[i]);
        }
    }
}