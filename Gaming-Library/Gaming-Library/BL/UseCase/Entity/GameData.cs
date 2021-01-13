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
    public sealed class GameData
    {
#nullable enable
        public SteamId? SteamId { get; set; }
#nullable disable
        public Title Title { get; set; }
        public Publisher Publisher { get; set; }
        public Location Location { get; set; }
        public YearOfPublication Year { get; set; }
        public Image Image { get; set; }
        public Tag[] Tags { get; set; }
        public Genre[] Genres { get; set; }
        public GameAttributes Attributes { get; set; }

        public static bool operator ==(GameData left, GameData right) => Operator.Weave(left, right);
        public static bool operator !=(GameData left, GameData right) => Operator.Weave(left, right);
    }
}
