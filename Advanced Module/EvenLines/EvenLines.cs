namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection.PortableExecutable;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                StringBuilder sb = new StringBuilder();
                string line = string.Empty;
                int count = 0;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (count % 2 == 0)
                    {
                        string replacedSymbs = ReplaceSymbols(line);
                        string reversedWords = ReverseWords(replacedSymbs);
                        sb.AppendLine(reversedWords);
                    }
                    count++;
                }
                return sb.ToString().TrimEnd();
            }
            
            
            
        }
        private static string ReplaceSymbols(string line)
        {
            string[] symbsToReplace = { "-", ",", ".", "!", "?" };
            foreach (var symbol in symbsToReplace)
            {
                line = line.Replace(symbol, "@");
            }
            return line;
        }
        private static string ReverseWords(string replacedSymbs)
        {
            string[] str = replacedSymbs.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            return string.Join(" ", str);
        }
    }
}
