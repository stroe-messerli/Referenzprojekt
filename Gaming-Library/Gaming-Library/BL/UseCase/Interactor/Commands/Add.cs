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
    public class Add : ICommand
    {
        private Injector _injector;

        public sealed class Injector
        {
            public Model Model;
        }

        public static ICommand Create(Injector injector)
        {
            return new Add(injector);
        }
        private Add(Injector injector)
        {
            _injector = injector;
        }
        public void Do(IRequest request)
        {
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
