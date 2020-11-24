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
            public BL.UseCase.Interactor.InteractorModel interactorModel;
        };

        private Injector _injector;

        public InteractorModelConverter Create(Injector injector)
        {
            return new InteractorModelConverter(injector);
        }

        public ResponseModel CreateResponseModel()
        {
            BL.UseCase.OutputPort.ResponseModel responseModel = new ResponseModel();

            responseModel.IsModified = _injector.interactorModel.Modifed;
            responseModel.Game.SteamId = _injector.interactorModel.EntityModel.SteamId;
            responseModel.Game.Title = _injector.interactorModel.EntityModel.Title;
            responseModel.Game.Publisher = _injector.interactorModel.EntityModel.Publisher;
            responseModel.Game.Location = _injector.interactorModel.EntityModel.Location;
            responseModel.Game.Year = _injector.interactorModel.EntityModel.Year;
            responseModel.Game.Image = _injector.interactorModel.EntityModel.Image;
            responseModel.Game.Tags = _injector.interactorModel.EntityModel.Tags;
            responseModel.Game.Genres = _injector.interactorModel.EntityModel.Genres;
            responseModel.Game.Attributes = _injector.interactorModel.EntityModel.Attributes;

            return responseModel;
        } 

        private InteractorModelConverter(Injector injector)
        {
            _injector = injector;
        }
    }
}
