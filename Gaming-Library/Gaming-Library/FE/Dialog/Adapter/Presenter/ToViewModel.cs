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
    public sealed class ToViewModel : IToViewModel
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


        public static IToViewModel Create(Injector injector)
        {
            return new ToViewModel(injector);
        }
        private ToViewModel(Injector injector)
        {
            _injector = injector;
        }

        public Model CreateViewModel()
        {
            var viewModel = new View.Model();

            viewModel.IsModified = _injector.ResponseModel.IsModified;

            foreach (var game in _injector.ResponseModel.Games) {
                var viewGame = new View.Model.GameData();
                viewGame.Attributes = game.Attributes;
                viewGame.Genre = game.Genres[0].GameGenre;
                viewGame.Image = game.Image.GameImage;
                viewGame.Location = game.Location.GameLocation;
                viewGame.Publisher = game.Publisher.GamePublisher;
                viewGame.SteamId = game.SteamId.ToString();
                viewGame.Title = game.Title.GameTitle;
                viewGame.Year = game.Year.ToString();
                viewGame.Tags = new string[0];
                foreach (var tag in game.Tags) {
                    viewGame.Tags = viewGame.Tags.Append(tag.GameTag).ToArray();

                }

                viewModel.Games.Add(viewGame);
            }
            return viewModel;
        }
    }
}
