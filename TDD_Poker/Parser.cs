namespace TDD_Poker;

public class Parser
{
    public List<Player> Parse(string input)
    {
        var playerSection = input.Split("  ", StringSplitOptions.RemoveEmptyEntries);
        var playerName = playerSection[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
        var cardSection = playerSection[0].Split(":", StringSplitOptions.RemoveEmptyEntries)[1];
        var cards = cardSection.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var tempList = new List<Card>();

        foreach (var card in cards)
        {
            tempList.Add(new Card
            {
                Output = card.Substring(0, 1),
                Suit = card.Substring(1, 1)
            });
        }

        return new List<Player>
        {
            new Player
            {
                Name = playerName,
                Cards = tempList
            }
        };
    }
}