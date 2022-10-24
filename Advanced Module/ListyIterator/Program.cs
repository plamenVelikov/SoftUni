﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }

                        break;
                }
            }
        }
    }
}
