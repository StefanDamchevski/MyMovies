using DemoMovies.Service.Dto;
using System.Collections.Generic;

namespace DemoMovies.ViewModels
{
    public class MovieOverviewDataModel
    {
        public List<OverviewViewModel> MovieOverview { get; set; }
        public SideBarData SideBarData { get; set; }
    }
}
