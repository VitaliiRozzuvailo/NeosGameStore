using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NeosGameStore.Domain.Abstract;
using System.Collections.Generic;
using NeosGameStore.Domain.Entities;
using NeosGameStore.WebUI.Controllers;

namespace NeosGameStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            //// Организация (arrange)
            //Mock<IGameRepository> mock = new Mock<IGameRepository>();
            //mock.Setup(m => m.Games).Returns(new List<Game>()
            //{
            //     new Game { GameId = 1, Name = "Игра1"},
            //    new Game { GameId = 2, Name = "Игра2"},
            //    new Game { GameId = 3, Name = "Игра3"},
            //    new Game { GameId = 4, Name = "Игра4"},
            //    new Game { GameId = 5, Name = "Игра5"}
            //});

            //GameController controller = new GameController(mock.Object);
            //controller.pageSize = 3;

            //// Действие (act)
            //IEnumerable<Game> result = (IEnumerable<Game>)controller.List(2).Model;
        }
    }
}
