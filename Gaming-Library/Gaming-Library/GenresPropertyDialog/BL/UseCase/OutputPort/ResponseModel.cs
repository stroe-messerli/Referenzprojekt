using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.OutputPort
{
    public sealed class ResponseModel
    {
        public bool IsModified;
        public Entity.GenreData Genres { get; set; }

        public ResponseModel()
        {
        }

        public void Clone(ResponseModel model)
        {
            IsModified = model.IsModified;
            Genres = model.Genres;
        }
    }
}

