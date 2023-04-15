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
            winnerOutput = players[1].Cards.First(card => card.ActualValue == winnerActualValue).Output;
        }
        else if (compareResult > 0)
        {
            winnerName = players[0].Name;
            var winnerActualValue = players[0].Cards.Max(card => card.ActualValue);
            winnerOutput = players[0].Cards.First(card => card.ActualValue == winnerActualValue).Output;
        }

        return $"{winnerName} wins. - with High card: {winnerOutput}";
    }
}