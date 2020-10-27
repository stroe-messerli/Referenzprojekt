using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Gaming_Library.BL.UseCase.Entity
{
    struct GameData
    {
        public int SteamId;
        public String Title;
        public String Genre;//vllt. eigener Type mit Eigenschaften
        public String Publisher;
        public String Location;
        public String YearOfPublication;
        public Image Image;
        //String [] Tags
        //Genre[] genres;
        //GameAttribute[] attributes;
    }
}
