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

        if (compareResult < 0)
        {
            winnerPlayer = players[1];
        }
        else if (compareResult > 0)
        {
            winnerPlayer = players[0];
        }

        winnerName = winnerPlayer.Name;
        var winnerCard = winnerPlayer.Cards.OrderByDescending(card => card.ActualValue).First();
        winnerOutput = winnerCard.Output;

        return $"{winnerName} wins. - with High card: {winnerOutput}";
    }
}