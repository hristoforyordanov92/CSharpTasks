namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText =
                "This is the house that Jack built. " +
                "This is the malt that lay in the house that Jack built. " +
                "This is the rat that ate the malt That lay in the house that Jack built.";

            string[] words = inputText.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            List<string> keys = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!wordCount.ContainsKey(words[i]))
                {
                    wordCount.Add(words[i], 1);
                    keys.Add(words[i]);
                }
                else
                {
                    wordCount[words[i]]++;
                }
            }

            Console.WriteLine("Unique words: ");
            for (int i = 0; i < wordCount.Count; i++)
            {
                if (wordCount[keys[i]] == 1)
                {
                    Console.Write($"{keys[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}
