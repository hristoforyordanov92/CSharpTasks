string[] names = { "Dr. Radeva", "Boiko Borisov", "Delqn Peevski", "Orhan Mudar", "Fiki" };
string[] namesBackwards = new string[names.Length];

for (int i = 0; i < names.Length; i++)
{
    string currentName = names[names.Length - i - 1];
    namesBackwards[i] = currentName;
    Console.WriteLine(currentName);
}
