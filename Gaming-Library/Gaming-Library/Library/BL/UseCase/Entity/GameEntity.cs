using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Entity
{
    class GameEntity : IGameEntity
    {
        private Injector _injector;

        public struct Injector
        {
            GameData EntityModel;
            //repository
        }

        public static IGameEntity Create(Injector injector)
        {
            return new GameEntity(injector);
        }

        private GameEntity(Injector injector)
        {
            _injector = injector;
        }

    }
}
