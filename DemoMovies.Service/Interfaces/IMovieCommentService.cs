namespace DemoMovies.Service.Interfaces
{
    public interface IMovieCommentService
    {
        void Add(string comment, int movieId, int userId);
    }
}
