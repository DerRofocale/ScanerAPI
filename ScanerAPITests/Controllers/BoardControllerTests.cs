using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScanerAPI.Controllers;
using ScanerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanerAPI.Controllers.Tests
{
    [TestClass()]
    public class BoardControllerTests
    {
        [TestMethod()]
        public void PostTest()
        {
            // Arrange
            Board board = new Board() { holes = 0, mold = 0, wane = 0, lenght = 1200, width = 100.0d };
            BoardController boardController = new BoardController();

            // Assert
            var actual = boardController.Post(board);
            var a = actual.Result;
            Assert.AreEqual("true", actual.Result.ToString());
        }
    }
}