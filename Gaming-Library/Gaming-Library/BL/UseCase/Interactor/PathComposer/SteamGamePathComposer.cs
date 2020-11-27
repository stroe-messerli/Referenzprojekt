using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Interactor.PathComposer
{
    class SteamGamePathComposer : IGamePathComposer
    {
        public static IGamePathComposer Create()
        {
            return new SteamGamePathComposer();
        }
        private SteamGamePathComposer()
        {
        }

        public string ComposeExecutablePath(Model interactorModel)
        {
            return "steam://rungameid/" + interactorModel.Game.SteamId.ToString();
        }
    }
}
