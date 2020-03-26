using NUnit.Framework;

namespace NumberPuzzle.UnitTest
{
    public class NumberPuzzleConsoleGameTest
    {

        [Test]
        public void TestIsSolved()
        {
            var game = new NumberPuzzleGameModel(new[] {1,2,3,4,5,6,7,8,0});
            Assert.IsTrue(game.IsSolved);
        }

        [Test]
        public void TestIsNotSolved()
        {
            var game = new NumberPuzzleGameModel(new[] { 1, 2, 3, 4, 5, 6, 7, 0, 8 });
            Assert.IsFalse(game.IsSolved);
        }

        [Test]
        public void TestIllegalMove()
        {
            var game = new NumberPuzzleGameModel(
                new[] { 
                    1, 2, 3, 
                    0, 5, 6, 
                    7, 4, 8 });
            game.Play(2);
            Assert.AreEqual('3', game[2]);
            Assert.IsFalse(game.IsSolved);
        }
    }
}