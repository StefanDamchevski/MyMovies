using System;

namespace DemoMovies.ViewModels
{
    public class ModifyCommentModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public string Username { get; set; }
        public bool IsApproved { get; set; }
    }
}
