using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
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


        public List<App> FindGame(string term, string path)
        {
            var applist = JsonConvert.DeserializeObject<SteamGameList>(File.ReadAllText(path));

            return applist.applist.apps.FindAll(item => item.name.Contains(term));
        }
    }
}
