using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.InputPort;

namespace Gaming_Library.BL.UseCase.Interactor.PathComposer
{
    interface IGamePathComposer
    {
        public string ComposeExecutablePath(Model interactorModel);
    }
}
