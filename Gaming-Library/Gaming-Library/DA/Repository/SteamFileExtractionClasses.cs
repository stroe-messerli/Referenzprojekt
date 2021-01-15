using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.DA.Repository
{
    public class SteamGameList
    {
        public AppList applist { get; set; }
    }
    public class AppList
    {
        public List<App> apps { get; set; }
    }

    public class App
    {
        public int appid { get; set; }
        public string name { get; set; }
    }
}
