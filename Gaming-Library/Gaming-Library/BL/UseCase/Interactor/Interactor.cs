using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.PropertyGridInternal;
using Gaming_Library.BL.UseCase.InputPort;
using Gaming_Library.BL.UseCase.Interactor.Commands;
using Gaming_Library.BL.UseCase.OutputPort;

namespace Gaming_Library.BL.UseCase.Interactor
{
    public class Interactor : IInteractor
    {
        private Injector _injector;

        public sealed class Injector
        {

            public InteractorModel InteractorModel;
            public OutputPort.IPresenter Presenter;
            public Commands.ICommands Commands;

            public Injector(InteractorModel interactorModel, IPresenter presenter, ICommands commands)
            {
                InteractorModel = interactorModel;
                Presenter = presenter;
                Commands = commands;
            }
        }

        public static IInteractor Create(Injector injector)
        {
            return new Interactor(injector);
        }

        private Interactor(Injector injector)
        {
            _injector = injector;
        }


        public void Update(RequestModel requestmodel)
        {
            var injector = new InputPort.Requests.Processor.Injector(requestmodel, _injector.Commands);
            var processor = InputPort.Requests.Processor.Create(injector);
            processor.Execute();
            UpdatePresenter();
        }

        private void UpdatePresenter()
        {
            var injector = new OutputPort.InteractorModelConverter.Injector(_injector.InteractorModel);
            var interactorModelConverter = OutputPort.InteractorModelConverter.Create(injector);
            var responseModel = interactorModelConverter.CreateResponseModel();
            _injector.Presenter.Update(responseModel);
        }

    }
}
