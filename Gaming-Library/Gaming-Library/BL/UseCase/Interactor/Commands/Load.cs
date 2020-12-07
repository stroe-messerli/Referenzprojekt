using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.DA;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    class Load : ICommand
    {
        private Injector _injector;

        public sealed class Injector
        {
            public UseCase.Interactor.Model InteractorModel;
        }

        public static ICommand Create(Injector injector)
        {
            return new Load(injector);

        }

        private Load(Injector injector)
        {
        }


        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }

        public void Do(IRequest request)
        {
            var jsonFileHandler = GamesJsonFileHandler.Create();
            var games = jsonFileHandler.LoadAllFromFile();
            _injector.InteractorModel.Games = games;
        }
    }
}
