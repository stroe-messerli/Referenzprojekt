using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;
using Gaming_Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.BL.UseCase.Interactor.PathComposer;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    class Start : ICommand
    {
        private Injector _injector;
        public sealed class Injector
        {
            public UseCase.Interactor.Model InteractorModel;

        };

        public void Do(IRequest request)
        {
            var pathtype = _injector.InteractorModel.Game.SteamId != null ? PathTypes.STEAM : PathTypes.NON_STEAM;
            var pathComposer = GamePathComposerFactory.CreatePathComposer(pathtype);
            var execPath = pathComposer.ComposeExecutablePath(_injector.InteractorModel);
            Process.Start(execPath);
        }

        public int GetId()
        {
            return GetType().GetHashCode();
        }
    }
}
