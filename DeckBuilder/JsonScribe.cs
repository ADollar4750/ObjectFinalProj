using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json;

public class JSonScribe
{
    public void deckSerizalizer(List<Card> deck)
    {
        string deckJson = JsonSerializer.Serialize(deck);
        Console.WriteLine(deckJson);
    }
}