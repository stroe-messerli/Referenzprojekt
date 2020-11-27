using Gaming_Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    class Delete : ICommand
    {
        private Injector _injector;
        public sealed class Injector
        {
            public UseCase.Interactor.Model model;

        };

        public static ICommand Create(Injector injector)
        {
            return new Delete(injector);
        }

        private Delete(Injector injector)
        {
            _injector = injector;
        }


        public void Do(IRequest request)
        {

        }

        public int GetId()
        {
            return GetType().GetHashCode();
        }


    }
}

