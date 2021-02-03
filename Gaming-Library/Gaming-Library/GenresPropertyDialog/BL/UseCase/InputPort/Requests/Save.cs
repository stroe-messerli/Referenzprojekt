using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.GenresPropertyDialog.BL.UseCase.Entity;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.InputPort.Requests
{
    public sealed class Save : IRequest
    {
        public GenreData Genres { get; }

        public Save(GenreData genres)
        {
            Genres = genres;
        }
    }
}
