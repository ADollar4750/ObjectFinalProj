using System.Net.Security;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
//holds the functions
public class DeckBuilderApp
{
    //generic collection type
    public List<Card> Deck = new List<Card>();
    public void AddCard(Card userCard)
    {
        Deck.Add(userCard);
    }
    public void RemoveCard(Card userCard)
    {
        Deck.Remove(userCard);
    }

}