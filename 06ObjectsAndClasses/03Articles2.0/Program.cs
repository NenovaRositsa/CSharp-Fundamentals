using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int countArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < countArticles; i++)
            {
                string[] articlesArgs = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string title = articlesArgs[0];
                string content = articlesArgs[1];
                string author = articlesArgs[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                List<Article> sortedArticles = articles.OrderBy(x => x.Title).ToList();
                sortedArticles.ForEach(x => Console.WriteLine(x));
            }
            else if (criteria == "content")
            {
                List<Article> sortedArticles = articles.OrderBy(x => x.Content).ToList();
                sortedArticles.ForEach(article => Console.WriteLine(article));
            }
            else if (criteria == "author")
            {
                List<Article> sortedArticles = articles.OrderBy(x => x.Author).ToList();
                sortedArticles.ForEach(x => Console.WriteLine(x));
            }
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
