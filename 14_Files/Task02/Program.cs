using System.Diagnostics;

namespace Task02
{
    internal class Program
    {
        const string firstFile = @"file1.txt";
        const string secondFile = @"file2.txt";

        static void Main(string[] args)
        {
            CreateSourceFiles();

            string outputFile = @"output.txt";

            if (File.Exists(outputFile))
                File.Delete(outputFile);

            using (StreamWriter writer = new(outputFile, true))
            {
                ReadFromWriteTo(firstFile, writer);
                ReadFromWriteTo(secondFile, writer);
            }

            // open the output file
            Process.Start("explorer", outputFile);
        }

        static void ReadFromWriteTo(string readFromFilePath, StreamWriter writer)
        {
            using (var reader = new StreamReader(readFromFilePath))
            {
                string lineContent = reader.ReadLine();
                while (lineContent != null)
                {
                    writer.WriteLine(lineContent);
                    lineContent = reader.ReadLine();
                }
            }
        }

        // create the source files automatically. not required by the task
        static void CreateSourceFiles()
        {
            string[] file1Content = [
                "file 1: line 1",
                "file 1: line 2",
                "file 1: line 3"
            ];
            File.WriteAllLines(firstFile, file1Content);

            string[] file2Content = [
                "file 2: line 1",
                "file 2: line 2",
                "file 2: line 3"
            ];
            File.WriteAllLines(secondFile, file2Content);
        }
    }
}
