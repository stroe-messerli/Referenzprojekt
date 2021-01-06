using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.DA.Repository
{
    public interface ISteamGameFinder
    {
        public List<string> FindGame(string term);
    }
}
