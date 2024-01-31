namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> toBulgarian = new Dictionary<string, string>();
            PopulateDictionary(toBulgarian);

            string text = "I am a programmer and i have a computer. I don't like bananas. My bicycle is broken. Fuck.";
            string translatedText;
            Console.WriteLine($"Original string:\n{text}");

            Console.WriteLine();

            Console.WriteLine($"Translated string:");
            TranslateText(text, toBulgarian, out translatedText);
            Console.WriteLine(translatedText);

            Console.WriteLine();
        }

        //Overly complicated method to translate sentences
        static void TranslateText(string text, Dictionary<string, string> dictionary, out string translation)
        {
            translation = "";

            string[] arrayOfWords = text.Split(' ');
            List<string> listOfWords = new(arrayOfWords);

            //Remove words like "a"
            string[] wordsToBeRemoved = { "a" };
            RemoveShortWordsFromList(listOfWords, wordsToBeRemoved);

            //Remove fullstops from each word and save the indexes of words which had a fullstop
            List<int> fullstopIndexes = new();
            RemoveAndRememberFullstops(listOfWords, fullstopIndexes);

            //Translate the words and make uppercase or leave lowercase the first letter
            TranslateWords(listOfWords, dictionary);

            //Pupulate all words into a new sentence variable and add fullstops
            GenerateText(ref translation, listOfWords, fullstopIndexes);
        }

        static void RemoveShortWordsFromList(List<string> list, string[] shortWordsToBeRemoved)
        {
            for (int i = 0; i < shortWordsToBeRemoved.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] == shortWordsToBeRemoved[i])
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }
        }

        static void RemoveAndRememberFullstops(List<string> list, List<int> listOfFullstops)
        {
            for (int word = 0; word < list.Count; word++)
            {
                for (int indexOfLetter = 0; indexOfLetter < list[word].Length; indexOfLetter++)
                {
                    if (list[word][indexOfLetter] == '.')
                    {
                        listOfFullstops.Add(word);
                        list[word] = list[word].Remove(indexOfLetter, 1);
                    }
                }
            }
        }

        static void TranslateWords(List<string> list, Dictionary<string, string> dictionary)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (dictionary.ContainsKey(list[i].ToLower()))
                {
                    string toLower = list[i].ToLower();
                    if (list[i][0] != toLower[0])
                    {
                        string toUpper = dictionary[list[i].ToLower()].Substring(0, 1);
                        toUpper = toUpper.ToUpper();
                        toUpper += dictionary[list[i].ToLower()].Substring(1);
                        list[i] = toUpper;
                    }
                    else
                    {
                        list[i] = dictionary[list[i]];
                    }
                }
            }
        }

        static void GenerateText(ref string text, List<string> list, List<int> listOfFullstops)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == listOfFullstops[0])
                {
                    text += list[i];
                    text += ". ";
                    listOfFullstops.RemoveAt(0);
                }
                else
                {
                    text += list[i] + " ";
                }
            }
        }

        //Populate the dictionary with all words that are translated. They must be lower case only.
        static void PopulateDictionary(Dictionary<string, string> dictionary)
        {
            dictionary.Add("i", "аз");
            dictionary.Add("am", "съм");
            dictionary.Add("have", "имам");
            dictionary.Add("computer", "компютър");
            dictionary.Add("programmer", "програмист");
            dictionary.Add("and", "и");
            dictionary.Add("don't", "не");
            dictionary.Add("like", "харесвам");
            dictionary.Add("bananas", "банани");
            dictionary.Add("my", "моето");
            dictionary.Add("bicycle", "колело");
            dictionary.Add("is", "е");
            dictionary.Add("broken", "счупено");
            dictionary.Add("fuck", "дейба ма'а му, дейба");
        }
    }
}
