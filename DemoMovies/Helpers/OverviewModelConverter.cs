using DemoMovies.Data;
using DemoMovies.ViewModels;
using System;

namespace DemoMovies.Helpers
{
    public static class OverviewModelConverter
    {
        public static OverviewViewModel OveviewModelConvert(Movie movie)
        {
            var overviewModel = new OverviewViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                YearReleased = movie.YearReleased,
                ImageUrl = movie.ImageUrl,
                Genre = movie.Genre,
                Views = movie.Views,
                DaysCreated = DateTime.Now.Subtract(movie.DateCreated).Days,
            };
            return overviewModel;
        }
    }
}
