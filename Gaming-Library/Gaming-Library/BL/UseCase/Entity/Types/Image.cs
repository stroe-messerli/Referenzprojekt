using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Entity.Types
{
    [Equals]

    public sealed class Image
    {
        public Image(Bitmap image)
        {
            GameImage = image;
        }

        public Bitmap GameImage { get; }
        public static bool operator ==(Image left, Image right) => Operator.Weave(left, right);
        public static bool operator !=(Image left, Image right) => Operator.Weave(left, right);
    }
}
