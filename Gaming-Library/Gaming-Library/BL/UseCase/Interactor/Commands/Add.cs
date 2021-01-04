using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;
using Gaming_Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.BL.UseCase.Interactor.PathComposer;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    public class Add : ICommand
    {
        private Model _model;

        public static ICommand Create(Model model)
        {
            return new Add(model);
        }
        private Add(Model model)
        {
            _model = model;
        }
        public void Do(IRequest request)
        {
            var addRequest = (InputPort.Requests.Add)request;

            _model.Games.Add(new Entity.GameData()
            {
                SteamId = new SteamId(Convert.ToInt32(addRequest.Game.SteamId)),
                Title = new Title(addRequest.Game.Title),
                Publisher = new Publisher(addRequest.Game.Publisher),
                Location = new Location(addRequest.Game.Location),
                Image = new Image(addRequest.Game.Image),
                Tags = new Tag[0] { },
                Year = new YearOfPublication(new DateTime(Convert.ToInt32(addRequest.Game.Year), 1, 1)),
                Genres = new Genre[1] { new Genre(addRequest.Game.Genre) },
            });
            foreach (var tag in addRequest.Game.Tags) {
                var index = _model.Games.Count - 1;
                _model.Games[index].Tags = _model.Games[index].Tags.Append(new Tag(tag)).ToArray();

            }

            //JSON.serialize(bla);
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
