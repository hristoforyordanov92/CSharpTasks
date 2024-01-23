// first solution
Console.WriteLine("Date: " + DateTime.Now.ToShortDateString());
Console.WriteLine("Time: " + DateTime.Now.ToShortTimeString());

Console.WriteLine();

// second solution
DateTime currentDateTime = DateTime.Now;
Console.WriteLine("Date: " + currentDateTime.ToString("dd-MM-yyyy"));
Console.WriteLine("Time: " + currentDateTime.ToString("HH:mm:ss"));