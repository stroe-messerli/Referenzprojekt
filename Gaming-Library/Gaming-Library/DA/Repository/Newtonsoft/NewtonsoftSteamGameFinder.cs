using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.DA.Repository.Newtonsoft
{
    public class NewtonsoftSteamGameFinder : ISteamGameFinder
    {
        private ILoadGamesRepository _repository;

        public static ISteamGameFinder Create(ILoadGamesRepository repository)
        {
            return new NewtonsoftSteamGameFinder(repository);
        }
        private NewtonsoftSteamGameFinder(ILoadGamesRepository repository)
        {
            _repository = repository;
        }


        public List<string> FindGame(string term, string path)
        {
            var registeredGames = _repository.LoadAllFromFile(path);
            var foundGames = new List<string>();

            //Newtonsoft.Jsonlibarary.FindAll(term)
            return foundGames;
        }
    }
}
