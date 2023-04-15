namespace TDD_Poker;

public class Card
{
    public int ActualValue
    {
        get
        {
            var valueConverter = new Dictionary<string, int>
            {
                { "A", 14 },
                { "K", 13 },
                { "Q", 12 },
                { "J", 11 },
                { "T", 10 },
            };
            return valueConverter.ContainsKey(Input) ? valueConverter.GetValueOrDefault(Input) : int.Parse(Input);
        }
    }

    public string Input { get; set; }

    public string Output
    {
        get
        {
            var outputConverter = new Dictionary<int, string>
            {
                { 14, "Ace" },
                { 13, "K" },
                { 12, "Q" },
                { 11, "J" }
            };
            return outputConverter.ContainsKey(ActualValue) ? outputConverter.GetValueOrDefault(ActualValue) : ActualValue.ToString();
        }
    }

    public string Suit { get; set; }
}