using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Gaming_Library.DA;
using Gaming_Library.BL.UseCase.Entity;
using System.IO;

namespace Game_Library.Test.DA.JsonFileHandler
{
    [TestClass]
    public class JsonFileHandlerTest
    {

        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateFileHandlerTest()
        {
            var fileHandler = GamesJsonFileHandler.Create();
            Assert.IsNotNull(fileHandler);
        }

        [TestMethod]
        public void LoadGamesTest()
        {
            var fileHandler = GamesJsonFileHandler.Create();
            Assert.IsTrue(fileHandler.LoadAllFromFile().Count == 0);
        }

        [TestMethod]
        public void SaveAllTest()
        {
            var fileHandler = GamesJsonFileHandler.Create();
            var games = new List<GameData>
            {
                new GameData(),
                new GameData(),
                new GameData()
            };

            Assert.IsTrue(fileHandler.LoadAllFromFile().Count == 3);
        }
    }
}
