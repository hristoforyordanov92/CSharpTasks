string myStr = "Hello World";
Console.WriteLine("myStr = \"{0}\"\n", myStr);

//2.1
Console.WriteLine("2.1");
string hello = myStr.Substring(0, 5);
string world = myStr.Substring(6, 5);
Console.WriteLine("First string: {0}\nSecond string: {1}\n", hello, world);

//2.2
Console.WriteLine("2.2");
sbyte requiredLength = 10;
bool isRequiredLength = myStr.Length == requiredLength;
Console.WriteLine("The string \"{0}\" is {1} characters long - {2} (it is actually {3} symbols long)\n", myStr, requiredLength, isRequiredLength, myStr.Length);

//2.3
Console.WriteLine("2.3");
Console.WriteLine("The index of 'W' is " + myStr.IndexOf('W') + "\n");

//2.4
Console.WriteLine("2.4");
Console.WriteLine("This is how it looks like when I yell - " + myStr.ToUpper() + "\n");

//2.5
Console.WriteLine("2.5");
Console.WriteLine("myStr = \"{0}\"\n", myStr);

//2.6
Console.WriteLine("2.6");
myStr = myStr.Replace("World", "Programming");
Console.WriteLine("myStr = \"{0}\"\n", myStr);