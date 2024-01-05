using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = string.Empty;
            string content = string.Empty;
            string author = string.Empty;

            Article article = new Article(title, content, author);

            List<Article> list = new List<Article>(); 

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(", ").ToList();
                title = command[0];
                content = command[1];
                author = command[2];

                article.Edit(content);
                article.ChangeTitle(title);
                article.ChangeAuthor(author);

            Console.WriteLine(article);
               
            }
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

        public void Edit(string content)
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
