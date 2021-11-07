using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArticle = Console.ReadLine()
                .Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries);

            string title = inputArticle[0];
            string content = inputArticle[1];
            string author = inputArticle[2];

            Article article = new Article(title, content, author);

            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { ": "}, StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];

                if (command == "Edit")
                {
                    string newContent = input[1];
                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = input[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command == "Rename")
                {
                    string newTitle = input[1];
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article);
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

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newtitle)
        {
            this.Title = newtitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
}
