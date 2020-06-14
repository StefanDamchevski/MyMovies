using System;

namespace DemoMovies.Service.Dto
{
    public class SidebarMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int Views { get; set; }
        public bool IsApproved { get; set; }
    }
}
