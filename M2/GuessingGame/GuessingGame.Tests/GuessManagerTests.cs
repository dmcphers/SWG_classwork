using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GuessingGame.BLL;

namespace GuessingGame.Tests
{
    [TestFixture]
    public class GuessManagerTests
    {
        private int _middleOfRange;

        public GuessManagerTests()
        {
            // Pick the number in the middle of the range
            _middleOfRange = (GameManager.MaximumGuess + GameManager.MinimumGuess) / 2;
        }

        [Test]
        public void InvalidGuessTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start();

            GuessResult actual = gameInstance.ProcessGuess(GameManager.MaximumGuess + 1);
            Assert.AreEqual(GuessResult.Invalid, actual);
        }

        [Test]
        public void HigherGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(_middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(_middleOfRange - 1);
            Assert.AreEqual(GuessResult.Higher, actual);
        }

        [Test]
        public void LowerGuessResultTest()
        {
            // Pick the number in the middle of the range
            GameManager gameInstance = new GameManager();
            gameInstance.Start(_middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(_middleOfRange + 1);
            Assert.AreEqual(GuessResult.Lower, actual);
        }

        [Test]
        public void VictoryGuessResultTest()
        {
            // Pick the number in the middle of the range
            GameManager gameInstance = new GameManager();
            gameInstance.Start(_middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(_middleOfRange);
            Assert.AreEqual(GuessResult.Victory, actual);
        }
    }
}
