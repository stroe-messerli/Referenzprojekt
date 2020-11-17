using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;

namespace Gaming_Library.FE.Dialog.Adapter.View
{
    public struct ViewModel
    {
        public struct GameData
        {
            public string SteamId;
            public string Title;
            public string Publisher;
            public string Location;
            public string Year;
            public BL.UseCase.Entity.Types.Image Image;
            public string[] Tags;
            public string Genre;
            public BL.UseCase.Entity.Types.GameAttributes Attributes;
        }

        public bool IsInvalidGame;
        public bool IsModified;
        public GameData Game;
    }
}
