using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Filmoteka.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
        public GenreDto Genre { get; set; }
        [Required]

        public static readonly DateTime StartDate = new DateTime(0001, 01, 01);
        public static readonly byte Empty = 0;
    }
}