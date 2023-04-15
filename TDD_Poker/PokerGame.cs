namespace TDD_Poker;

public class PokerGame
{
    public string ShowResult(string input)
    {
        var parser = new Parser();
        var players = parser.Parse(input);
        var compareResult = players[0].Cards.Max(card => card.ActualValue) -
                            players[1].Cards.Max(card => card.ActualValue);
        var winnerName = "";
        var winnerOutput = "";
        var winnerPlayer = new Player();
        var winnerCard = new Card();
        var remainCard1 = players[0].Cards;
        var remainCard2 = players[1].Cards;
        var exceptCard1 = new List<Card>();
        var exceptCard2 = new List<Card>();

        if (compareResult == 0)
        {
            exceptCard1.Add(remainCard1.OrderByDescending(card => card.ActualValue).First());
            remainCard1 = remainCard1.Except(exceptCard1).ToList();
            exceptCard2.Add(remainCard2.OrderByDescending(card => card.ActualValue).First());
            remainCard2 = remainCard2.Except(exceptCard2).ToList();
            compareResult = remainCard1.Max(card => card.ActualValue) -
                            remainCard2.Max(card => card.ActualValue);
        }
        if (compareResult < 0)
        {
            winnerPlayer = players[1];
            winnerCard = remainCard2.OrderByDescending(card => card.ActualValue).First();
        }

        if (compareResult > 0)
        {
            winnerPlayer = players[0];
            winnerCard = remainCard1.OrderByDescending(card => card.ActualValue).First();
        }

        winnerName = winnerPlayer.Name;
        winnerOutput = winnerCard.Output;

        return $"{winnerName} wins. - with High card: {winnerOutput}";
    }
}