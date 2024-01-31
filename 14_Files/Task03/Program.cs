using System.Text;

namespace Task03
{
    internal class Program
    {
        const string firstFile = @"file1.txt";
        const string secondFile = @"file2.txt";

        static void Main(string[] args)
        {
            CreateSourceFiles();

            StringBuilder firstBuilder = new StringBuilder();
            StringBuilder secondBuilder = new StringBuilder();

            int equalLines = 0;
            int differentLines = 0;

            int currentLine = 1;

            using (StreamReader firstReader = new StreamReader(firstFile))
            using (StreamReader secondReader = new StreamReader(secondFile))
            {
                string firstLine = firstReader.ReadLine();
                string secondLine = secondReader.ReadLine();

                while (firstLine != null && secondLine != null)
                {
                    if (firstLine.Equals(secondLine))
                    {
                        equalLines++;
                        firstBuilder.Append($"{currentLine} ");
                    }
                    else
                    {
                        differentLines++;
                        secondBuilder.Append($"{currentLine} ");
                    }

                    firstLine = firstReader.ReadLine();
                    secondLine = secondReader.ReadLine();
                    currentLine++;
                }
            }

            Console.WriteLine($"Lines {firstBuilder}are equal. A total of {equalLines}.");
            Console.WriteLine($"Lines {secondBuilder}are different. A total of {differentLines}.");
            Console.WriteLine();
        }

        // create the source files automatically.
        static void CreateSourceFiles()
        {
            string[] firstFileContent = [
                "i am forko",
                "i am reworking this task's code",
                "my old code sucks so much",
                "i won a million dollars from the lottery",
                "i love eating dogs"
            ];
            File.WriteAllLines(firstFile, firstFileContent);

            string[] secondFileContent = [
                "i am forko",
                "i am reworking this task's code",
                "my old code sucks so much",
                "wish i could win a million dollars from the lottery",
                "i love petting dogs"
            ];
            File.WriteAllLines(secondFile, secondFileContent);
        }
    }
}
