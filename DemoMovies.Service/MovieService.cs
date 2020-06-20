using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DemoMovies.Service
{
    public class MovieService:IMovieService
    {
        private IMovieRepository MovieRepository { get; set; }
        public MovieService(IMovieRepository movieRepo)
        {
            MovieRepository = movieRepo;
        }
        public List<Movie> GetAll()
        {
            return MovieRepository.GetAll();
        }
        public Movie GetById(int id)
        {
            return MovieRepository.GetById(id);
        }
        public void Add(Movie movie)
        {
            MovieRepository.Add(movie);
        }
        public List<Movie> GetByTitle(string title)
        {
            return MovieRepository.GetByTitle(title);
        }
        public Movie GetMovieDetails(int id)
        {
            Movie movie = MovieRepository.GetById(id);
            movie.Views += 1;
            MovieRepository.Update(movie);
            return movie;
        }

        public void Delete(int id)
        {
            MovieRepository.Delete(id);
        }

        public void UpdateMovie(Movie movie)
        {
            MovieRepository.Update(movie);
        }
        public SideBarData GetSideBarData()
        {
            List<Movie> movies = MovieRepository.GetAll();

            List<SidebarMovie> topViews = GetTopFViews(movies);

            List<SidebarMovie> recentlyCreated = GetRecentlyCreated(movies);

            SideBarData sidebarData = AddToSideBarData(topViews, recentlyCreated);

            return sidebarData;
        }

        private static SideBarData AddToSideBarData(List<SidebarMovie> topViews, List<SidebarMovie> recentlyCreated)
        {
            SideBarData sidebarData = new SideBarData();
            sidebarData.RecentlyCreated = recentlyCreated;
            sidebarData.TopViews = topViews;
            return sidebarData;
        }

        private static List<SidebarMovie> GetRecentlyCreated(List<Movie> movies)
        {
            return movies.OrderByDescending(x => x.DateCreated)
                .Take(5)
                .Select(x => new SidebarMovie()
                {
                    Id = x.Id,
                    Title = x.Title,
                    DateCreated = x.DateCreated,
                    Views = x.Views,
                    IsApproved = x.IsApproved,
                })
                .ToList();
        }

        private static List<SidebarMovie> GetTopFViews(List<Movie> movies)
        {
            return movies.OrderByDescending(x => x.Views)
                .Take(5)
                .Select(x => new SidebarMovie()
                {
                    Id = x.Id,
                    Title = x.Title,
                    DateCreated = x.DateCreated,
                    Views = x.Views,
                    IsApproved = x.IsApproved,
                })
                .ToList();
        }

        public void Approve(int id)
        {
            Movie movie = MovieRepository.GetById(id);
            movie.IsApproved = true;
            MovieRepository.Update(movie);
        }
    }
}