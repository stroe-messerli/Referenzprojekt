using System;
using System.Linq;
using Gaming_Library.GenresPropertyDialog.BL.UseCase.OutputPort;
using Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.View;

namespace Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.Presenter
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

            foreach (var genre in _injector.ResponseModel.Genres.Genres) {
                viewModel.Genres.Genres = viewModel.Genres.Genres.Append(genre.GameGenre).ToList();
            }
            return viewModel;
        }
    }
}
