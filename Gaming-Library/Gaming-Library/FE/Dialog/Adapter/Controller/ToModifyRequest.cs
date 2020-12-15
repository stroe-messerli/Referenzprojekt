using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.FE.Dialog.Adapter.View;

namespace Gaming_Library.FE.Dialog.Adapter.Controller
{
    public class ToModifyRequest
    {

        private View.Model _viewModel;
        private int _gameIndex;
        public static ToModifyRequest Create(int gameIndex, View.Model viewModel)
        {
            return new ToModifyRequest(gameIndex, viewModel);
        }

        private ToModifyRequest(int gameIndex, View.Model viewModel)
        {
            _viewModel = viewModel;
            _gameIndex = gameIndex;
        }

        public BL.UseCase.InputPort.Requests.Modify CreateModifyRequest()
        {
            var modifyRequest = new BL.UseCase.InputPort.Requests.Modify(_gameIndex);

            modifyRequest.Game.Attributes = _viewModel.Games.ElementAt(_gameIndex).Attributes;
            modifyRequest.Game.Genre = _viewModel.Games.ElementAt(_gameIndex).Genre;
            modifyRequest.Game.Image = _viewModel.Games.ElementAt(_gameIndex).Image;
            modifyRequest.Game.Location = _viewModel.Games.ElementAt(_gameIndex).Location;
            modifyRequest.Game.SteamId = _viewModel.Games.ElementAt(_gameIndex).SteamId;
            modifyRequest.Game.Tags = _viewModel.Games.ElementAt(_gameIndex).Tags;
            modifyRequest.Game.Title = _viewModel.Games.ElementAt(_gameIndex).Title;
            modifyRequest.Game.Year = _viewModel.Games.ElementAt(_gameIndex).Year;

            return modifyRequest;
        }
    }
}
