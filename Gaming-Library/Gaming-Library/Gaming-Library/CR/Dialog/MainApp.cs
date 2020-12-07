using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaming_Library.BL.UseCase.Interactor;

namespace Gaming_Library
{
    static class MainApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BL.UseCase.Interactor.InteractorModel interactorModel;
            FE.Dialog.Adapter.View.ViewModel viewModel;
            var commands = BL.UseCase.Interactor.Commands.Commands.Create();
            //commands.Add(BL.UseCase.Interactor.Commands)
            //var injector = BL.UseCase.Interactor.Interactor.Injector(interactorModel, presenter, commands);
            //var interactor = BL.UseCase.Interactor.Interactor.Create(;

            Application.Run(new LibraryDialog());

        }
    }
}
