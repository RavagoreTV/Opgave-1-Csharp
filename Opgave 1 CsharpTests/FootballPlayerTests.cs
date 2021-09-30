using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1_Csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1_Csharp.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void NameTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.Name = "Victor";

            Assert.AreEqual("Victor", footballPlayer.Name);

            Assert.ThrowsException<ArgumentException>(
                () => footballPlayer.Name = "V");
        }

        [TestMethod()]
        public void PriceTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.Price = 1000000;

            Assert.AreEqual(1000000, footballPlayer.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => footballPlayer.Price = -650);
        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.ShirtNumber = 50;

            Assert.AreEqual(50, footballPlayer.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => footballPlayer.ShirtNumber = 0);
        }
    }
}