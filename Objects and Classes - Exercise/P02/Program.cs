namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Reflection.Metadata;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = article[0];
                string content = article[1];
                string author = article[2];

                Article newArticle = new Article(title, content, author);
                Console.WriteLine(newArticle);
            }

        }
        static void EditArticle(Article newArticle)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string arg = command[1];

                if (command[0] == "Edit")
                {
                    newArticle.ChangeContent(arg);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(arg);
                }
                else if (command[0] == "Rename")
                {
                    newArticle.RenameTitle(arg);
                }
            }

            Console.WriteLine(newArticle);
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

        public void ChangeContent(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void RenameTitle(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}