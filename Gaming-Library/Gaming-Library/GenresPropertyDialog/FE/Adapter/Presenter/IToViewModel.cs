using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.View;

namespace Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.Presenter
{
    public interface IToViewModel
    {
        Model CreateViewModel();
    }
}
