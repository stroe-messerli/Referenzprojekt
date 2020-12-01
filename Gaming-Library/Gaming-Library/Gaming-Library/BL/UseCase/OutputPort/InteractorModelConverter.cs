using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Interactor;

namespace Gaming_Library.BL.UseCase.OutputPort
{
    class InteractorModelConverter : Gaming_Library.BL.UseCase.OutputPort.IInteractorModelConverter
    {
        public struct Injector
        {

            public Interactor.InteractorModel InteractorModel;

            public Injector(InteractorModel interactorModel)
            {
                InteractorModel = interactorModel;
            }
        };

        private readonly Injector _injector;

        public static InteractorModelConverter Create(Injector injector)
        {
            return new InteractorModelConverter(injector);
        }
        private InteractorModelConverter(Injector injector)
        {
            _injector = injector;
        }


        public ResponseModel CreateResponseModel()
        {
            var responseModel = new ResponseModel();
            responseModel.IsModified = _injector.InteractorModel.IsModified;

            responseModel.Game.Attributes = _injector.InteractorModel.Game.Attributes;
            responseModel.Game.Genres = _injector.InteractorModel.Game.Genres;
            responseModel.Game.Image = _injector.InteractorModel.Game.Image;
            responseModel.Game.Location = _injector.InteractorModel.Game.Location;
            responseModel.Game.Publisher = _injector.InteractorModel.Game.Publisher;
            responseModel.Game.SteamId = _injector.InteractorModel.Game.SteamId;
            responseModel.Game.Tags = _injector.InteractorModel.Game.Tags;
            responseModel.Game.Title = _injector.InteractorModel.Game.Title;
            responseModel.Game.Year = _injector.InteractorModel.Game.Year;

            return responseModel;
        }
    }
}
