using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.OutputPort;
using Gaming_Library.FE.Dialog.Adapter.View;

namespace Gaming_Library.FE.Dialog.Adapter.Presenter
{
    public sealed class ResponseModelConverter : IResponseModelConverter
    {
        private readonly Injector _injector;

        public struct Injector
        {
            public Injector(ResponseModel responseModel)
            {
                ResponseModel = responseModel;
            }

            public ResponseModel ResponseModel { get; }
        }


        public static IResponseModelConverter Create(Injector injector)
        {
            return new ResponseModelConverter(injector);
        }

        public ViewModel CreateViewModel()
        {
            var viewModel = new ViewModel();
            viewModel.IsModified = _injector.ResponseModel.IsModified;
            viewModel.Game.Attributes = _injector.ResponseModel.Game.Attributes;
            viewModel.Game.Genre = _injector.ResponseModel.Game.Genres[0].GameGenre;
            viewModel.Game.Image = _injector.ResponseModel.Game.Image;
            viewModel.Game.Location = _injector.ResponseModel.Game.Location.GameLocation;
            viewModel.Game.Publisher = _injector.ResponseModel.Game.Publisher.GamePublisher;
            viewModel.Game.SteamId = _injector.ResponseModel.Game.SteamId.ToString();

            foreach (var tag in _injector.ResponseModel.Game.Tags) {
                viewModel.Game.Tags.Append(tag.ToString());
            }

            viewModel.Game.Title = _injector.ResponseModel.Game.Title.GameTitle;
            viewModel.Game.Year = _injector.ResponseModel.Game.Year.ToString();

            return viewModel;
        }

        private ResponseModelConverter(Injector injector)
        {
            _injector = injector;
        }
    }
}
