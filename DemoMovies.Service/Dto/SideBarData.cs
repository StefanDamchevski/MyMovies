using System.Collections.Generic;

namespace DemoMovies.Service.Dto
{
    public class SideBarData
    {
        public List<SidebarMovie> TopViews { get; set; }
        public List<SidebarMovie> RecentlyCreated { get; set; }
    }
}
