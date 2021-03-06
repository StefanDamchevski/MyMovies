﻿using DemoMovies.Data;
using System.Collections.Generic;

namespace DemoMovies.Service.Interfaces
{
    public interface IMovieLikeService
    {
        void AddLike(int movieId, int userId);
        List<MovieLike> GetAll();
        void Remove(int movieId, int userId);
        void AddDislike(int movieId, int userId);
    }
}
