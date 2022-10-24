﻿namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Count(ch => char.IsLetter(ch));
                int symbolCount = lines[i].Count(ch => char.IsPunctuation(ch));
                sb.AppendLine($"Line {i + 1}: {lines[i]} ({letterCount})({symbolCount})");
            }
            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
