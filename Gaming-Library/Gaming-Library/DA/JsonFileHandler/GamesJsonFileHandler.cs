using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.DA
{
    public class GamesJsonFileHandler : IJsonFileHandler
    {

        public static IJsonFileHandler Create()
        {
            return new GamesJsonFileHandler();
        }
        private GamesJsonFileHandler()
        {
        }


        public List<GameData> LoadAllFromFile()
        {
            throw new NotImplementedException();
        }

        public void SaveToFile(List<GameData> itemsToSave)
        {
            throw new NotImplementedException();
        }
    }
}
