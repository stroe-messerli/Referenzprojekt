using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity;
using Gaming_Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.DA;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    class Load : ICommand
    {
        private UseCase.Interactor.Model _interactorModel;

        public static ICommand Create(Model interactorModel)
        {
            return new Load(interactorModel);

        }

        private Load(Model interactorModel)
        {
            _interactorModel = interactorModel;
        }


        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }

        public void Do(IRequest request)
        {
            createTestObjects();
            //var jsonFileHandler = GamesJsonFileHandler.Create();
            //var games = jsonFileHandler.LoadAllFromFile();
            //_injector.InteractorModel.Games = games;
        }

        private void createTestObjects()
        {
            var game = new GameData();
            game.Genres = new Entity.Types.Genre[1] { new Entity.Types.Genre("Action") };
            game.Title = new Entity.Types.Title("Among Us");
            game.Year = new Entity.Types.YearOfPublication(new DateTime(2018, 1, 1));
            game.Image = new BL.UseCase.Entity.Types.Image(Properties.Resources.amongus);
            game.Location = new Entity.Types.Location("C:\\");
            game.Publisher = new Entity.Types.Publisher("SomeCoorp");
            game.SteamId = new Entity.Types.SteamId(945360);
            game.Tags = new Entity.Types.Tag[0];
            game.Attributes = new Entity.Types.GameAttributes();

            _interactorModel.Games.Add(game);

            //game.Genre = "Action";
            //game.Title = "Counter Strike:Global Offensive";
            //game.Year = "01.01.2012";
            //game.Image = new BL.UseCase.Entity.Types.Image(Resources.csgo);
            //viewModel.Games.Add(game);
        }
    }
}
