using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.DA.Repository.Standard
{
    public class StandardSteamGameFinder : ISteamGameFinder
    {
        private ILoadGamesRepository _repository;


        public static ISteamGameFinder Create(ILoadGamesRepository repository)
        {
            return new StandardSteamGameFinder(repository);
        }
        private StandardSteamGameFinder(ILoadGamesRepository repository)
        {
            _repository = repository;
        }

        public List<string> FindGame(string term)
        {
            var registeredGames = _repository.LoadAllFromFile("");
            var foundGames = new List<string>();

            //System.JsonLibrary.FindAll(term)

            return foundGames;
        }
    }
}
