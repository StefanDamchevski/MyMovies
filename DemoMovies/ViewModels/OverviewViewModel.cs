namespace DemoMovies.ViewModels
{
    public class OverviewViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearReleased { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public int Views { get; set; }
        public int DaysCreated { get; set; }
        public bool IsApproved { get; set; }
    }
}
