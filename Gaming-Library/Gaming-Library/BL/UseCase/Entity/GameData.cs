using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaming_Library.BL.UseCase.Entity.Types;

namespace Gaming_Library.BL.UseCase.Entity
{
    [Equals]
    public class GameData
    {
#nullable enable
        public SteamId? SteamId;
#nullable disable
        public Title Title;
        public Publisher Publisher;
        public Location Location;
        public YearOfPublication Year;
        public Image Image;
        public Tag[] Tags;
        public Genre[] Genres;
        public GameAttributes Attributes;

        public static bool operator ==(GameData left, GameData right) => Operator.Weave(left, right);
        public static bool operator !=(GameData left, GameData right) => Operator.Weave(left, right);
    }
}
