using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.OutputPort
{
    public struct ResponseModel
    {
        public struct GameData
        {
            public Entity.Types.SteamId SteamId;
            public Entity.Types.Title Title;
            public Entity.Types.Publisher Publisher;
            public Entity.Types.Location Location;
            public Entity.Types.YearOfPublication Year;
            public Entity.Types.Image Image;
            public Entity.Types.Tag[] Tags;
            public Entity.Types.Genre[] Genres;
            public Entity.Types.GameAttributes Attributes;
        }

        public bool IsModified { get; }
        public GameData Game { get; }
    }
}

