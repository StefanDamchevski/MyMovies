using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMovies.Data
{
    public partial class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Cast { get; set; }
        [Required]
        public int YearReleased { get; set; }
        public int Views { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        public List<MovieComment> MovieComment { get; set; }
        public bool IsApproved { get; set; }
    }
}