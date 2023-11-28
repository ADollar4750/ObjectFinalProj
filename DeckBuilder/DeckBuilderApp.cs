using System.Net.Security;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public class DeckBuilderApp
{
    public List<Card> Deck = new List<Card>();
    public void AddCard(Card userCard)
    {
        Deck.Add(userCard);
    }
    // public void RemoveCard(Card userCard)
    // {
    //     Deck.Remove(userCard);
    // }

}