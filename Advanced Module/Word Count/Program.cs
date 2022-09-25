using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            using (StreamReader readerText = new StreamReader(textFilePath))
            {
                using (StreamReader readerWords = new StreamReader(wordsFilePath))
                {
                    string[] words = readerWords.ReadLine().Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        while (!readerText.EndOfStream)
                        {
                            string line = readerText.ReadLine();
                            
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (line.ToLower().Contains(words[i]))
                                {
                                    if (!dict.ContainsKey(words[i]))
                                    {
                                        dict.Add(words[i], 1);
                                    }
                                    else
                                    {
                                        dict[words[i]]++;
                                    }
                                }
                            }
                            
                        }
                        foreach (var word in dict.OrderByDescending(x => x.Value))
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}
