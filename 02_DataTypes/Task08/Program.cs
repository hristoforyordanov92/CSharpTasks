int firstInteger = 5;
int secondInteger = 8;

Console.WriteLine("First integer: {0}\nSecond integer: {1}\n", firstInteger, secondInteger);
Console.WriteLine("Swapping values...\n");

int temp = firstInteger;
firstInteger = secondInteger;
secondInteger = temp;
Console.WriteLine("First integer: {0}\nSecond integer: {1}\n", firstInteger, secondInteger);