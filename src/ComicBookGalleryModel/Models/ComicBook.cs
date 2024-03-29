﻿using System;
using System.Collections.Generic;

namespace ComicBookGalleryModel.Models
{
    public class ComicBook
    {

        public ComicBook()
        {
            Artists = new List<Artist>();
        }

        public int Id { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }

        public int SeriesId { get; set; }
        public Series Series { get; set; }


        public ICollection<Artist> Artists { get; set; }


        public string DisplayText
        {
            get
            {
                return $"{Series.Title} #{IssueNumber}";
            }
        }


    }
}
