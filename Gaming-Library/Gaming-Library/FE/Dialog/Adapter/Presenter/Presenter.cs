using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.OutputPort;
using Gaming_Library.FE.Dialog.Adapter.View;

namespace Gaming_Library.FE.Dialog.Adapter.Presenter
{
    public class Presenter : IPresenter
    {
        private Injector _injector;

        public sealed class Injector
        {
            public View.Model ViewModel;
            public View.IView View;

            public Injector(Model viewModel, IView view)
            {
                ViewModel = viewModel;
                View = view;
            }
        }

        public static IPresenter Create(Injector injector)
        {
            return new Presenter(injector);
        }
        private Presenter(Injector injector)
        {
            _injector = injector;
        }

        public void Update(BL.UseCase.OutputPort.ResponseModel responseModel)
        {
            var injector = new ToViewModel.Injector(responseModel);
            var responseModelConverter = ToViewModel.Create(injector);
            _injector.ViewModel = responseModelConverter.CreateViewModel();
            _injector.View.UpdateView();
        }
    }
}
