using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Gaming_Library.DA.Repository.Standard;
using Gaming_Library.BL.UseCase.Entity;
using System.IO;

namespace Game_Library.Test.DA.Repository.Standard
{
    [TestClass]
    public class StandardSteamGameFinderTest
    {
        private readonly string _fileName = "C:/Users/Xhan/Desktop/testGames.json";


        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateTest()
        {
            var repMock = new Mock<Gaming_Library.DA.Repository.ILoadGamesRepository>();
            var finder = StandardSteamGameFinder.Create(repMock.Object);
            Assert.IsNotNull(finder);
        }

        [TestMethod]
        public void FindGameOneMatchingTest()
        {
            var game = new GameData();
            game.Title = new Gaming_Library.BL.UseCase.Entity.Types.Title("Game1");
            var games = new List<GameData>()
            {
                game,
            };

            var repMock = new Mock<Gaming_Library.DA.Repository.ILoadGamesRepository>();
            repMock.Setup(x => x.LoadAllFromFile(_fileName)).Returns(games);

            var finder = StandardSteamGameFinder.Create(repMock.Object);

            var result = finder.FindGame("Game1", _fileName);
            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void FindGameNoneMatchingTest()
        {
            var games = new List<GameData>()
            {
            };

            var repMock = new Mock<Gaming_Library.DA.Repository.ILoadGamesRepository>();
            repMock.Setup(x => x.LoadAllFromFile(_fileName)).Returns(games);

            var finder = StandardSteamGameFinder.Create(repMock.Object);

            var result = finder.FindGame("Game2", _fileName);
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void FindGameMultipleMatchingTest()
        {
            var game = new GameData();
            game.Title = new Gaming_Library.BL.UseCase.Entity.Types.Title("Game1");

            var partialMatchingGame = new GameData();
            partialMatchingGame.Title = new Gaming_Library.BL.UseCase.Entity.Types.Title("Gam1");

            var games = new List<GameData>()
            {
                game,
                partialMatchingGame,
                new GameData(),
            };

            var repMock = new Mock<Gaming_Library.DA.Repository.ILoadGamesRepository>();
            repMock.Setup(x => x.LoadAllFromFile(_fileName)).Returns(games);

            var finder = StandardSteamGameFinder.Create(repMock.Object);

            var result = finder.FindGame("Game1", _fileName);
            Assert.IsTrue(result.Count == 2);
        }
    }
}
