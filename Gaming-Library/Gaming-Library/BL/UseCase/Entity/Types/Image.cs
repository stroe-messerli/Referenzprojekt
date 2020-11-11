using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Entity.Types
{
    [Equals]

    sealed class Image
    {
        public Image(Image image)
        {
            GameImage = image;
        }

        public Image GameImage { get; }

    }
}
