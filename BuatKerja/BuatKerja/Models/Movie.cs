using System;
using System.Collections.Generic;
using System.Text;

namespace BuatKerja.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public string Year { get; set; }
        public string Synopsis { get; set; }
        public bool IsFeatured { get; set; }
    }
}
