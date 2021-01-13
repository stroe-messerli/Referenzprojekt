using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;
using Gaming_Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    public class Modify : ICommand
    {
        private Model _model;

        public static ICommand Create(Model model)
        {
            return new Modify(model);
        }
        private Modify(Model model)
        {
            _model = model;
        }
        public void Do(IRequest request)
        {
            var modifyRequest = (InputPort.Requests.Modify)request;

            if (modifyRequest.Game.Attributes != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).Attributes = modifyRequest.Game.Attributes;
            }
            if (modifyRequest.Game.Genre != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).Genres = new Genre[1] { new Genre(modifyRequest.Game.Genre) };
            }
            if (modifyRequest.Game.Image != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).Image = new Image(modifyRequest.Game.Image);
            }
            if (modifyRequest.Game.Location != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).Location = new Location(modifyRequest.Game.Location);
            }
            if (modifyRequest.Game.Publisher != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).Publisher = new Publisher(modifyRequest.Game.Publisher);
            }
            if (modifyRequest.Game.SteamId != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).SteamId = new SteamId(Convert.ToInt32(modifyRequest.Game.SteamId));
            }
            if (modifyRequest.Game.Tags != null) {
                //_model.Games.ElementAt(modifyRequest.GameIndex).Tags = (Tag[])modifyRequest.Game.Tags;
            }
            if (modifyRequest.Game.Title != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).Title = new Title(modifyRequest.Game.Title);
            }
            if (modifyRequest.Game.Year != null) {
                _model.Games.ElementAt(modifyRequest.GameIndex).Year = new YearOfPublication(new DateTime(Convert.ToInt32(modifyRequest.Game.Year), 1, 1));
            }
            _model.IsModified = true;

            var saveGamesRepository = DA.Repository.Standard.StandardSaveGamesRepository.Create();
            saveGamesRepository.SaveToFile(_model.Games, "games.json");
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
