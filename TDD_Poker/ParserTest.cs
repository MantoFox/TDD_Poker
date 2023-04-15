using FluentAssertions;

namespace TDD_Poker;

public class ParserTest
{
    [Test]
    public void A01_OnePlayer()
    {
        var parser = new Parser();
        var actual = parser.Parse("Black: 2H 3D 5S 9C KD");

        var expected = new List<Player>
        {
            new Player
            {
                Name = "Black",
                Cards = new List<Card>
                {
                    new Card{Input = "2", Suit = "H"},
                    new Card{Input = "3", Suit = "D"},
                    new Card{Input = "5", Suit = "S"},
                    new Card{Input = "9", Suit = "C"},
                    new Card{Input = "K", Suit = "D"}
                }
            }
        };
        actual.Should().BeEquivalentTo(expected);
    }

    [Test]
    public void A02_TwoPlayer()
    {
        var parser = new Parser();
        var actual = parser.Parse("Black: 2H 3D 5S 9C KD  White: 2C 3H 4S 8C AH");

        var expected = new List<Player>
        {
            new Player
            {
                Name = "Black",
                Cards = new List<Card>
                {
                    new Card{Input = "2", Suit = "H"},
                    new Card{Input = "3", Suit = "D"},
                    new Card{Input = "5", Suit = "S"},
                    new Card{Input = "9", Suit = "C"},
                    new Card{Input = "K", Suit = "D"}
                }
            },
            new Player
            {
                Name = "White",
                Cards = new List<Card>
                {
                    new Card{Input = "2", Suit = "C"},
                    new Card{Input = "3", Suit = "H"},
                    new Card{Input = "4", Suit = "S"},
                    new Card{Input = "8", Suit = "C"},
                    new Card{Input = "A", Suit = "H"}
                }
            }
        };
        actual.Should().BeEquivalentTo(expected);
    }
}