using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.OutputPort
{
    class InteractorModelConverter : Gaming_Library.BL.UseCase.OutputPort.IInteractorModelConverter
    {
        public struct Injector
        {
            InteractorModel interactorModel;
        };

        private Injector _injector;

        public InteractorModelConverter Create(Injector injector)
        {
            return new InteractorModelConverter(injector);
        }

        public ResponseModel CreateResponseModel()
        {
            BL.UseCase.OutputPort.ResponseModel responseModel {new ResponseModel};

            responseModel
        } 

        private InteractorModelConverter(Injector injector)
        {
            _injector = injector;
        }
    }
}
