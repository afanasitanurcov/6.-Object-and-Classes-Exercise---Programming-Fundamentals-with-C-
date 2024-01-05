using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleParts = Console.ReadLine().Split(", ");

            string title = articleParts[0];
            string content = articleParts[1];
            string author = articleParts[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();
                
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;

                    case "Rename":
                        article.ChangeTitle(command[1]);
                        break;
                }
            }
            Console.WriteLine(article);
        }


        }
        public class Article
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
           
            public void Edit (string content)
            {
                Content = content;
            }
            public void ChangeAuthor(string author)
            {
                Author = author;
            }
            public void ChangeTitle(string title)
            {
                Title = title;
            }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
       

    }

