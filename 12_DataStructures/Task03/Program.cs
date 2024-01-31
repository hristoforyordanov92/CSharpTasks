namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "apple",
                "orange",
                "fruit",
                "strawberry",
                "carrot",
                "apple",
                "orange",
                "bicycle",
                "oracle",
                "carrot",
                "program",
                "orange",
                "motorcycle",
                "egg",
                "cotton",
                "martin",
                "giraffe",
                "fox",
                "orange",
                "carrot"
            };

            Dictionary<string, int> wordCount = new();
            List<string> keys = new();

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

            for (int i = 0; i < wordCount.Count; i++)
            {
                Console.WriteLine($"Word \"{keys[i]}\" is met {wordCount[keys[i]]} times.");
            }
        }
    }
}
