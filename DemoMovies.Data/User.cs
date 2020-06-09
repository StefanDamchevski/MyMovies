using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoMovies.Data
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        public List<MovieComment> UserComment { get; set; }
    }
}