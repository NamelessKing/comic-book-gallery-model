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
            using (var context = new Context())
            {
                context.ComicBooks.Add(new ComicBook()
                {
                    Series = new Series() { Title = "The Amazing Spide-Man"},
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                });

                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .ToList();

                foreach (var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.SeriesTitle);
                }

                Console.ReadLine();  
            }
        }
    }
}
