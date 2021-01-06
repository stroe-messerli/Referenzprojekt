using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.DA.Repository.Newtonsoft
{
    public class NewtonsoftSaveGamesRepository : ISaveGamesRepository
    {

        public static ISaveGamesRepository Create()
        {
            return new NewtonsoftSaveGamesRepository();
        }

        private NewtonsoftSaveGamesRepository()
        {

        }
        public void SaveToFile(List<GameData> itemsToSave, string path)
        {
            //Newtonsoft.Json.
            throw new NotImplementedException();
        }
    }
}
