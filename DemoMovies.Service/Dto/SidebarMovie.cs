using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMovies.Service.Dto
{
    public class SidebarMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int Views { get; set; }
    }
}
