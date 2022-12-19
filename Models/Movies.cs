using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Filmoteka.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Required]
        //[Range(1,20)]
        public byte NumberInStock { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        public byte NumberAvailible { get; set; }

        public static readonly DateTime StartDate = new DateTime(0001, 01, 01);
        public static readonly byte Empty = 0;
    }
}