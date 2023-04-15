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

        if (compareResult < 0)
        {
            winnerName = players[1].Name;
            var winnerActualValue = players[1].Cards.Max(card => card.ActualValue);
            var winnerCard = players[1].Cards.First(card => card.ActualValue == winnerActualValue);
            winnerOutput = winnerCard.Output;
        }

        return $"{winnerName} wins. - with High card: {winnerOutput}";
    }
}