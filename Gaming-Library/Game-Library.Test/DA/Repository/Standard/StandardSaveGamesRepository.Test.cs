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
    public class StandardSaveGamesRepositoryTest
    {
        private readonly string _fileName = "C:/Users/Xhan/Desktop/testGames.json";


        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateFileHandlerTest()
        {
            var fileHandler = StandardSaveGamesRepository.Create();
            Assert.IsNotNull(fileHandler);
        }

        [TestMethod]
        public void SaveAllMultipleTest()
        {
            var fileHandler = StandardSaveGamesRepository.Create();

            var games = new List<GameData>
            {
                new GameData(),
                new GameData(),
                new GameData()
            };

            fileHandler.SaveToFile(games, _fileName);

            var gamesString = File.ReadAllText(_fileName);
            games = System.Text.Json.JsonSerializer.Deserialize<List<GameData>>(gamesString);
            Assert.IsTrue(games.Count == 3);
        }

        [TestMethod]
        public void SaveAllTest()
        {
            var fileHandler = StandardSaveGamesRepository.Create();

            var games = new List<GameData>
            {
                new GameData()
            };
            var filename = "C:/Users/Xhan/Desktop/testGames.json";
            fileHandler.SaveToFile(games, filename);
            fileHandler.SaveToFile(null, filename);

            var gamesString = File.ReadAllText(filename);
            games = System.Text.Json.JsonSerializer.Deserialize<List<GameData>>(gamesString);
            Assert.IsTrue(games.Count == 1);
        }


        [TestMethod]
        public void SaveAllNoItemsTest()
        {
            var fileHandler = StandardSaveGamesRepository.Create();

            var filename = "C:/Users/Xhan/Desktop/testGames.json";
            fileHandler.SaveToFile(null, filename);

            var gamesString = File.ReadAllText(filename);
            var games = System.Text.Json.JsonSerializer.Deserialize<List<GameData>>(gamesString);
            Assert.IsTrue(games.Count == 0);
        }
    }
}
