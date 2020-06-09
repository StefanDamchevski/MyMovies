using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoMovies.Data
{
    public class MovieComment
    {
        public int Id { get; set; }
        [Required]
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
