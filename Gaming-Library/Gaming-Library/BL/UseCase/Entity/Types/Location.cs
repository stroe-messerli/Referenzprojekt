using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Entity.Types
{
    [Equals]

    sealed class Location
    {
        public Location(string location)
        {
            GameLocation = location;
        }

        public string GameLocation { get; }

    }
}
