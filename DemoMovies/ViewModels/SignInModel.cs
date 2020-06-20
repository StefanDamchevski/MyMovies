using System.ComponentModel.DataAnnotations;

namespace DemoMovies.ViewModels
{
    public class SignInModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength (8)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "The password must contain at least one captial letter and one digit")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
