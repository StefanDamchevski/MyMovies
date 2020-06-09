using DemoMovies.Data;
using DemoMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

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
                MovieComments = movie.MovieComment
                                    .Select(x => ConvertToMovieCommentsModel(x))
                                    .ToList(),
            };
        }
        public static MovieCommentsModel ConvertToMovieCommentsModel(MovieComment movieComment)
        {
            return new MovieCommentsModel
            {
                Comment = movieComment.Comment,
                DateCreated = movieComment.DateCreated,
                Username = movieComment.User.UserName,
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
        public static ModifyUsersModel ConvertToModifyUserModel(User user)
        {
            return new ModifyUsersModel
            {
                Id = user.Id,
                Username = user.UserName,
            };
        }
        public static ModifyCurrentUserModel ConvertToModifyCurrentUserModel(User user)
        {
            return new ModifyCurrentUserModel
            {
                Id = user.Id,
                Username = user.UserName,
                Password = user.Password,
                RepeatPassword = user.Password,
            };
        }
        public static User ConvertFromUserModifyCurrnetUserModel(ModifyCurrentUserModel currentUserModel)
        {
            return new User
            {
                Id= currentUserModel.Id,
                UserName = currentUserModel.Username,
                Password = currentUserModel.Password,
            };
        }
    }
}