using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMovies.Service.Dto
{
    public class SideBarData
    {
        public List<SidebarMovie> TopViews { get; set; }
        public List<SidebarMovie> RecentlyCreated { get; set; }
    }
}
