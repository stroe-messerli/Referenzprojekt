using System;
using System.IO;
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

        public List<App> FindGame(string term, string FilePath)
        {
            var applist = System.Text.Json.JsonSerializer.Deserialize<SteamGameList>(File.ReadAllText(FilePath));

            return applist.applist.apps.FindAll(item => item.name.Contains(term));
        }
    }
}
