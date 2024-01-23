string myStr = "Programming";
Console.WriteLine("The first 3 letters of the word \"{0}\" are \"{1}\".\n", myStr, myStr.Substring(0, 3));

Console.WriteLine("The index of 'o' in '{0}' is {1} (starting from 0).\n", myStr, myStr.IndexOf('o'));

Console.Write("Enter a number: ");
double number = double.Parse(Console.ReadLine());
Console.WriteLine("Square root of {0} is {1}.\n", number, Math.Sqrt(number));

string str1 = "15";
string str2 = "25";
Console.WriteLine("String calculator:");
Console.WriteLine("{0} + {1} = {2}\n", str1, str2, Convert.ToInt32(str1) + Convert.ToInt32(str2));