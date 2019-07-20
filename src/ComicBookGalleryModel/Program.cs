using ComicBookGalleryModel.Models;
using System;
using System.Linq;
using System.Data.Entity;

namespace ComicBookGalleryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Series series1 = new Series() { Title = "The Amazing Spide-Man" };
            Series series2 = new Series() { Title = "The Invincible Iron man" };

            Artist artist1 = new Artist() { Name = "Stan Lee"};
            Artist artist2 = new Artist() { Name = "Steve Ditko" };
            Artist artist3 = new Artist() { Name = "Jack Kirby" };
            

            using (var context = new Context())
            {
                context.ComicBooks.Add(new ComicBook()
                {
                    Series = series,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                });

                context.ComicBooks.Add(new ComicBook()
                {
                    Series = series,
                    IssueNumber = 2,
                    PublishedOn = DateTime.Today
                });


                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .ToList();

                foreach (var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.DisplayText);
                }

                Console.ReadLine();  
            }
        }
    }
}
