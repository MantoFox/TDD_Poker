using FluentAssertions;

namespace TDD_Poker
{
    public class Tests
    {
        private PokerGame _pokerGame;

        [SetUp]
        public void A00_Setup()
        {
            _pokerGame = new PokerGame();
        }

        [Test]
        public void A01_BothHighCard()
        {
            var expected = "White wins. - with High card: Ace";
            var actual = _pokerGame.ShowResult("Black: 2H 3D 5S 9C KD  White: 2C 3H 4S 8C AH");
            actual.Should().Be(expected);
        }
    }
}