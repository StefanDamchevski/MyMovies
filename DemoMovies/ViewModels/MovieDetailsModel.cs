﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMovies.ViewModels
{
    public class MovieDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; } 
        public string Genre { get; set; }
        public string Cast { get; set; }
        public int YearReleased { get; set; }
        public int Views { get; set; }
        public DateTime DateCreated { get; set; }
    }
}