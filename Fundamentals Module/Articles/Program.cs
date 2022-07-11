using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleProps = Console.ReadLine().Split(", ");
            Article article = new Article(articleProps[0], articleProps[1], articleProps[2]);
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] commInput = Console.ReadLine().Split(' ');
                string command = commInput[0];
                List<string> commInputList = new List<string>();
                commInputList.AddRange(commInput);
                commInputList.RemoveAt(0);
                switch (command)
                {
                    case "Edit:":
                        article.Edit(string.Join(' ', commInputList));
                        break;
                    case "ChangeAuthor:":
                        article.ChangeAuthor(string.Join(' ', commInputList));
                        break;
                    case "Rename:":
                        article.Rename(string.Join(' ', commInputList));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public void Rename(string title) => Title = title;

        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
