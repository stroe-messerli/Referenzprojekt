using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class YearOfPublication
    {
        public YearOfPublication(DateTime year)
        {
            PublicationYear = year;
        }

        private readonly DateTime PublicationYear;
        public static bool operator ==(YearOfPublication left, YearOfPublication right) => Operator.Weave(left, right);
        public static bool operator !=(YearOfPublication left, YearOfPublication right) => Operator.Weave(left, right);
        public override string ToString()
        {
            return PublicationYear.ToString("dd.MM.JJJ");
        }
    }
}
