using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.OutputPort;

namespace Gaming_Library.FE.Dialog.Adapter.Presenter
{
    public class Presenter : IPresenter
    {
        private Injector _injector;

        public struct Injector
        {
            public View.ViewModel ViewModel;
            public View.IView View;
        }

        public static IPresenter Create(Injector injector)
        {
            return new Presenter(injector);
        }

        public void Update(BL.UseCase.OutputPort.ResponseModel responseModel)
        {
            var injector = new ResponseModelConverter.Injector(responseModel);
            var responseModelConverter = ResponseModelConverter.Create(injector);
            _injector.ViewModel = responseModelConverter.CreateViewModel();
            _injector.View.UpdateView();
        }

        private Presenter(Injector injector)
        {
            _injector = injector;
        }

    }
}
