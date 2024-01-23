//Just some code to make everything look good
string nameLabel = "Name";
string ageLabel = "Age";
Console.WriteLine($"{nameLabel,-25}{ageLabel}");

//The actual task
PrintPersonInfo("Hristofor Yordanov", 25);
PrintPersonInfo("Jack Johnson", 42);
PrintPersonInfo("Corey Taylor", 43);

Console.WriteLine();

static void PrintPersonInfo(string name, int age)
{
    Console.WriteLine($"{name,-25}{age}");
}