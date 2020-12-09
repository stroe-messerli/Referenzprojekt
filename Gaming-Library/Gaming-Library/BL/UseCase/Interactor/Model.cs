using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Interactor
{
    public sealed class Model
    {
        public List<Entity.GameData> Games { get; set; }
        public bool IsModified { get; }

        public Model()
        {
            Games = new List<Entity.GameData>();
        }
    }
}
