﻿using ComicBookGalleryModel.Models;
using System.Data.Entity;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<ComicBook> ComicBooks { get; set; }

    }
}
