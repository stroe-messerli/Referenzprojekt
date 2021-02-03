using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;
using System.Drawing;

namespace Gaming_Library.FE.Dialog.Adapter.View
{
    public sealed class Model
    {
        public sealed class GameData
        {
            public string SteamId;
            public string Title;
            public string Publisher;
            public string Location;
            public string Year;
            public Bitmap Image;
            public string ImagePath;
            public string[] Tags;
            public string Genres;
            public GameAttributes Attributes;

            public GameData()
            {
                Attributes = new GameAttributes();
            }
        }

        public bool IsInvalidGame;
        public bool IsModified;
        public List<GameData> Games { get; set; }

        public Model()
        {
            Games = new List<GameData>();
        }

        public void Clone(Model model)
        {
            Games = model.Games;
        }
    }
}
