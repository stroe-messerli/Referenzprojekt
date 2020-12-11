using Gaming_Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    class Delete : ICommand
    {
        private UseCase.Interactor.Model _interactorModel;

        public static ICommand Create(UseCase.Interactor.Model interactorModel)
        {
            return new Delete(interactorModel);
        }

        private Delete(UseCase.Interactor.Model interactorModel)
        {
            _interactorModel = interactorModel;
        }


        public void Do(IRequest request)
        {
            var deleteRequest = (InputPort.Requests.Delete)request;
            _interactorModel.Games.RemoveAt(deleteRequest.GameIndex);
            //var jsonFileHandler = DA.GamesJsonFileHandler.Create();
            //jsonFileHandler.SaveToFile(_injector.InteractorModel.Games);
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }


    }
}

