using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json;
//This holds all the functions that deal with json
public class JSonScribe
{
    DeckBuilderApp app = new DeckBuilderApp();
    DeckBuilderManager manage = new DeckBuilderManager();
    public void deckPrinter(List<Card> deck)
    {
        string deckJson = JsonSerializer.Serialize(deck);
        Console.WriteLine(deckJson);
    }
    //third class
    public void deckFileMaker(List<Card> deck)
    {
        string serializedDeck = "";
        foreach (Card card in app.Deck)
        {
            serializedDeck += JsonSerializer.Serialize(app.Deck);
        }
        File.Create($"{manage.deckName}.json");
        string filename = $"{manage.deckName}.json";
        File.WriteAllText(filename, serializedDeck);
    }
}