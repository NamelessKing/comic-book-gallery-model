using ComicBookGalleryModel.Models;
using System.Data.Entity;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
        public DbSet<ComicBook> ComicBooks { get; set; }

    }
}
