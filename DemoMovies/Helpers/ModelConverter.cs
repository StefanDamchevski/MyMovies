﻿using DemoMovies.Data;
using DemoMovies.ViewModels;
using System;

namespace DemoMovies.Helpers
{
    public static class ModelConverter
    {
        public static OverviewViewModel OveviewModelConvert(Movie movie)
        {
            return new OverviewViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                YearReleased = movie.YearReleased,
                ImageUrl = movie.ImageUrl,
                Genre = movie.Genre,
                Views = movie.Views,
                DaysCreated = DateTime.Now.Subtract(movie.DateCreated).Days,
            };
        }
        public static MovieDetailsModel DetailsModelConvert(Movie movie)
        {
            return new MovieDetailsModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Cast = movie.Cast,
                Genre = movie.Genre,
                ImageUrl = movie.ImageUrl,
                YearReleased = movie.YearReleased,
                Description = movie.Description,
                Views = movie.Views,
                DateCreated = movie.DateCreated,
            };
        }
        public static Movie CreateModelToMovieConvert(MovieCreateModel movieCreateModel)
        {
            return new Movie
            {
                Title = movieCreateModel.Title,
                ImageUrl = movieCreateModel.ImageUrl,
                Description = movieCreateModel.Description,
                Genre = movieCreateModel.Genre,
                Cast = movieCreateModel.Cast,
                YearReleased = movieCreateModel.YearReleased,
            };
        }
        public static ModifyOverviewModel ConvertToModifyOverviewModel(Movie movie)
        {
            return new ModifyOverviewModel
            {
                Id = movie.Id,
                Title = movie.Title,
            };
        }
        public static MovieModifyModel ConvertToMovieModifyModel(Movie movie)
        {
            return new MovieModifyModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Cast = movie.Cast,
                Genre = movie.Genre,
                ImageUrl = movie.ImageUrl,
                YearReleased = movie.YearReleased,
                Description = movie.Description,
                Views = movie.Views,
                DateCreated = movie.DateCreated,
            };
        }
        public static Movie ConvertFromMovieModifyModel(MovieModifyModel movieModify)
        {
            return new Movie
            {
                Id = movieModify.Id,
                Title = movieModify.Title,
                Cast = movieModify.Cast,
                Genre = movieModify.Genre,
                ImageUrl = movieModify.ImageUrl,
                YearReleased = movieModify.YearReleased,
                Description = movieModify.Description,
                Views = movieModify.Views,
                DateCreated = movieModify.DateCreated,
            };
        }
    }
}