using System;

namespace DemoMovies.ViewModels
{
    public class MovieCommentsModel
    {
        public string Comment { get; set; }
        public int DaysAgo { get; set; }
        public string Username { get; set; }
        public bool IsApproved { get; set; }
    }
}
