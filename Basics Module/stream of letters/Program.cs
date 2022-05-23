using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = String.Empty;
            string sentence = String.Empty;

            int counterC = 0;
            int counterO = 0;
            int counterN = 0;
            int commandCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine(sentence);
                    return;
                }
                switch (input)
                {
                    case "c":
                        counterC++;
                        if (counterC > 1)
                        {
                            word += "c";
                        }
                        else
                        {
                            commandCounter++;
                            if (commandCounter == 3)
                            {
                                sentence += word + " ";
                                counterC = 0;
                                counterO = 0;
                                counterN = 0;
                                commandCounter = 0;
                                word = String.Empty;
                            }
                        }
                        break;

                    case "o":
                        counterO++;
                        if (counterO > 1)
                        {
                            word += "o";
                        }
                        else
                        {
                            commandCounter++;
                            if (commandCounter == 3)
                            {
                                sentence += word + " ";
                                counterC = 0;
                                counterO = 0;
                                counterN = 0;
                                commandCounter = 0;
                                word = String.Empty;
                            }
                        }
                        break;
                    case "n":
                        counterN++;
                        if (counterN > 1)
                        {
                            word += "n";
                        }
                        else
                        {
                            commandCounter++;
                            if (commandCounter == 3)
                            {
                                sentence += word + " ";
                                counterC = 0;
                                counterO = 0;
                                counterN = 0;
                                commandCounter = 0;
                                word = String.Empty;
                            }
                        }
                        break;
                    default:
                        char inputChar = char.Parse(input);
                        int ascii = Convert.ToInt32(inputChar);
                        if (ascii >= 65 && ascii <= 90 || ascii >= 97 && ascii <= 122)
                        {
                            word += input;
                        }

                        break;
                }
            }
        }
    }
}
