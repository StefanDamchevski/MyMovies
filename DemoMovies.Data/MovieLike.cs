using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMovies.Data
{
    public class MovieLike
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}