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
        [TestCase("Black: 2H 3D 5S 9C KD  White: 2C 3H 4S 8C AH", "White wins. - with High card: Ace")]
        [TestCase("Black: 2H 3D 5S 9C QD  White: 2C 3H 4S 8C KH", "White wins. - with High card: K")]
        [TestCase("Black: 2H 3D 5S 9C AD  White: 2C 3H 4S 8C 5H", "Black wins. - with High card: Ace")]
        [TestCase("Black: 2H 3D 5S 9C JD  White: 2C 3H 4S 8C QH", "White wins. - with High card: Q")]
        [TestCase("Black: 2H 3D 5S 9C TD  White: 2C 3H 4S 8C JH", "White wins. - with High card: J")]
        [TestCase("Black: 2H 3D 5S 8C 9D  White: 2C 3H 4S 8C TH", "White wins. - with High card: 10")]
        public void A01_BothHighCard(string input, string expected)
        {
            AssertShowResultShouldBe(input, expected);
        }

        private void AssertShowResultShouldBe(string input, string expected)
        {
            var actual = _pokerGame.ShowResult(input);
            actual.Should().Be(expected);
        }
    }
}