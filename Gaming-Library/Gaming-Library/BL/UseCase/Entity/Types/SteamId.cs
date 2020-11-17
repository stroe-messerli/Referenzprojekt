using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class SteamId
    {
        public SteamId(int? id)
        {
            Id = id;
        }

        private readonly int? Id;
        public static bool operator ==(SteamId left, SteamId right) => Operator.Weave(left, right);
        public static bool operator !=(SteamId left, SteamId right) => Operator.Weave(left, right);
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
