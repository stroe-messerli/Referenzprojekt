using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.InputPort.Requests
{
    class Modify : IRequest
    {
        public readonly int GameIndex;

        public Modify(int GameIndex)
        {
            this.GameIndex = GameIndex;
        }
    }
}
