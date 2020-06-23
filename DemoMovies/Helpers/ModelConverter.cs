using DemoMovies.Data;
using DemoMovies.ViewModels;
using System;
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
                IsApproved = movie.IsApproved,
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
                MovieLikes = movie.MovieLikes.Select(x => ConvertToMovieLikeModel(x)).ToList(),
            };
        }

        private static MovieLikeModel ConvertToMovieLikeModel(MovieLike x)
        {
            return new MovieLikeModel
            {
                Id = x.Id,
                RecipeId = x.MovieId,
                UserId = x.UserId,
                Status = x.Status,
            };
        }

        public static MovieCommentsModel ConvertToMovieCommentsModel(MovieComment movieComment)
        {
            return new MovieCommentsModel
            {
                Comment = movieComment.Comment,
                DaysAgo = DateTime.Now.Subtract(movieComment.DateCreated).Days,
                Username = movieComment.User.UserName,
                IsApproved = movieComment.IsAproved,
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
                IsApproved = movie.IsApproved,
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
                IsAdmin = user.IsAdmin,
            };
        }
        public static ModifyCurrentUserModel ConvertToModifyCurrentUserModel(User user)
        {
            return new ModifyCurrentUserModel
            {
                Id = user.Id,
                Username = user.UserName,
            };
        }
        public static User ConvertFromUserModifyCurrnetUserModel(ModifyCurrentUserModel currentUserModel)
        {
            return new User
            {
                Id= currentUserModel.Id,
                UserName = currentUserModel.Username,
            };
        }

        public static ModifyCommentModel ConvertToModifyCommentsModel(MovieComment movieComment)
        {
            return new ModifyCommentModel
            {
                Id = movieComment.Id,
                Comment = movieComment.Comment,
                DateCreated = movieComment.DateCreated,
                Username = movieComment.User.UserName,
                IsApproved = movieComment.IsAproved,
            };
        }
        public static UserDetailsModel ConvertToUserDetailsModel(User user)
        {
            return new UserDetailsModel
            {
                Id = user.Id,
                Username = user.UserName,
                IsAdmin = user.IsAdmin,
            };
        }
    }
}