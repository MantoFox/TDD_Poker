namespace TDD_Poker;

public class Parser
{
    public List<Player> Parse(string input)
    {
        var playerSection = input.Split("  ", StringSplitOptions.RemoveEmptyEntries)[0];
        var player = GetPlayer(playerSection);

        return new List<Player>
        {
            player
        };
    }

    private static Player GetPlayer(string playerSection)
    {
        var playerName = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
        var cardSection = playerSection.Split(":", StringSplitOptions.RemoveEmptyEntries)[1];
        var cards = cardSection.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(card => new Card { Output = card.Substring(0, 1), Suit = card.Substring(1, 1) })
            .ToList();

        return new Player
        {
            Name = playerName,
            Cards = cards
        };
    }
}