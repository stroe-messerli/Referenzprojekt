using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;

namespace Gaming_Library.BL.UseCase.Entity
{
    [Equals]
    class GameData
    {
        public SteamId SteamId;
        public Title Title;
        public Publisher Publisher;
        public Location Location;
        public YearOfPublication Year;
        public Image Image;
        public Tag[] Tags;
        public Genre[] Genres;
        public GameAttributes Attributes;
    }
}
