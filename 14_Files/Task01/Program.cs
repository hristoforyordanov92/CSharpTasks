using System.Diagnostics;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"source.txt";

            // not required by the task, but it's for lazy people :)
            CreateSourceFile(sourceFile);

            string outputFile = @"output.txt";

            int lineIndex = 1;

            using (StreamReader reader = new(sourceFile))
            using (StreamWriter writer = new(outputFile))
            {
                string lineContent = reader.ReadLine();
                while (lineContent != null)
                {
                    writer.WriteLine($"{lineIndex}: {lineContent}");

                    lineContent = reader.ReadLine();
                    lineIndex++;
                }
            }

            // open the output file to observe the result
            // basically 'explorer' is the application, 'outputFile' is the argument that we can give it.
            Process.Start("explorer", outputFile);
        }

        // this method is not required by the task, but creating the file by hand is booooring and i'm lazy
        static void CreateSourceFile(string fileName)
        {
            var lines = "this text will be split into lines. each word will be its own line".Split(' ');
            File.WriteAllLines(fileName, lines);
        }
    }
}
