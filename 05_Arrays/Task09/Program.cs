string originalString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
string tempString = originalString;
Console.WriteLine("string = " + originalString);

//clear the string from symbols and leave only words
while (originalString.IndexOf(",") >= 0)
{
    if (originalString.IndexOf(",") >= 0)
    {
        originalString = originalString.Remove(originalString.IndexOf(","), 1);
    }
}

//count the number of words
int wordCount = 0;
while (true)
{
    if (tempString.IndexOf(" ") >= 1)
    {
        wordCount++;
        tempString = tempString.Remove(0, tempString.IndexOf(" ") + 1);
    }
    else if (tempString.IndexOf(" ") == -1)
    {
        wordCount++;
        break;
    }
}

tempString = originalString;

//place words in an array
string[] words = new string[wordCount];
for (int i = 0; i < words.GetLength(0); i++)
{
    if (tempString.IndexOf(" ") >= 1)
    {
        words[i] = tempString.Substring(0, tempString.IndexOf(" ") + 1);
        tempString = tempString.Remove(0, tempString.IndexOf(" ") + 1);
    }
    else if (tempString.IndexOf(" ") == -1)
    {
        words[i] = tempString.Substring(0);
        break;
    }
}
Console.WriteLine();

//print words[]
for (int i = 0; i < words.GetLength(0); i++)
{
    Console.WriteLine("words[{0}] = {1}", i, words[i]);
}
Console.WriteLine();


//// By the way... There's a simpler solution that includes the Split() method.
//// I didn't know about it back then, this is why I wrote this THING above... :D
//string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
//string[] words = str.Split(' ');

//for (int i = 0; i < words.GetLength(0); i++)
//{
//    words[i] = words[i].Trim(',');
//    Console.WriteLine($"words[{i}] = {words[i]}");
//}
//Console.WriteLine();