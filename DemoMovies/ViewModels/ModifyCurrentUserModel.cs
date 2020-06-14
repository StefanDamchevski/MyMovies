using System.ComponentModel.DataAnnotations;

namespace DemoMovies.ViewModels
{
    public class ModifyCurrentUserModel
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public bool IsAdmin { get; set; }
    }
}
