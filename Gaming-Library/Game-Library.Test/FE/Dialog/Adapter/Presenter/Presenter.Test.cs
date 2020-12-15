using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Gaming_Library.BL.UseCase.InputPort;
using Gaming_Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.BL.UseCase.Interactor;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Gaming_Library.BL.UseCase.OutputPort;
using Gaming_Library.BL.UseCase.Entity;
using Gaming_Library.FE.Dialog.Adapter.View;
using Gaming_Library;

namespace Game_Library.FE.Dialog.Adapter.Presenter
{
    [TestClass]
    public class Presenter_Test
    {

        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreatePresenterTest()
        {
            var viewModel = new Gaming_Library.FE.Dialog.Adapter.View.Model();
            var views = new List<IView>();

            var injector = new Gaming_Library.FE.Dialog.Adapter.Presenter.Presenter.Injector(viewModel, views);
            var presenter = Gaming_Library.FE.Dialog.Adapter.Presenter.Presenter.Create(injector);

            Assert.IsNotNull(presenter);
        }

        [TestMethod]
        public void UpdateViewTest()
        {
            var viewModel = new Gaming_Library.FE.Dialog.Adapter.View.Model();
            var views = new List<IView>();

            var injector = new Gaming_Library.FE.Dialog.Adapter.Presenter.Presenter.Injector(viewModel, views);
            var presenter = Gaming_Library.FE.Dialog.Adapter.Presenter.Presenter.Create(injector);

            Assert.IsNotNull(presenter);
        }
    }
}
