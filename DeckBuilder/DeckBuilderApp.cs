using System.Net.Security;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class DeckBuilderApp
{
    public List<Card> deck = new List<Card>();
    public void AddCard()
    {
        Creature test = new Creature()
        {
            Name = "Tyson",
            ManaCost = "1 Blue, 1 Red, 2 Any",
            Legendary = true,
            CreatureType = "human",
            Ability = "When Tyson enters the battlefield deal 5 damage to any target.",
            Power = 5,
            Toughness = 3,
        };
        deck.Add(test);
    }

}