using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace DeckBuilder.Test;

public class AppTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CreatureAddTest()
    {
        DeckBuilderApp test = new DeckBuilderApp();
        Creature expected = new Creature()
        {
            Name = "Tim",
            ManaCost = "0",
            Legendary = true,
            CreatureType = "human",
            Ability = "Sacrifice Tim to destroy target token.",
            Power = 0,
            Toughness = 2,
        };
        test.AddCard(expected);

        Assert.AreEqual("Tim", test.Deck[0].Name);
    }

    [Test]
    public void LandAddTest()
    {
        DeckBuilderApp test = new DeckBuilderApp();
        Land expected = new Land()
        {
            Name = "Bajuka Bog",
            Legendary = false,
            Ability = "Bojuka Bog enters the battlefiled tapped. When Bojuka BOg enters the battlefiled,exile all cards from target player's graveyard. Tap it add one Black to your mana pool.",
        };
        test.AddCard(expected);

        Assert.AreEqual(null, test.Deck[0].ManaCost);
    }
    [Test]
    public void InstantAddTest()
    {
        DeckBuilderApp test = new DeckBuilderApp();
        Instant expected = new Instant()
        {
            Name = "Counter Spell",
            ManaCost = "2 Blue",
            Ability = "Counter target spell.",
        };
        test.AddCard(expected);

        Assert.AreEqual(false, test.Deck[0].Legendary);
    }
    [Test]
    public void RemoveCardTest()
    {
        DeckBuilderApp test = new DeckBuilderApp();
        Instant expected = new Instant()
        {
            Name = "Counter Spell",
            ManaCost = "2 Blue",
            Ability = "Counter target spell.",
        };
        test.AddCard(expected);
        test.RemoveCard(expected);
        bool actual = test.Deck.Contains(expected);
        Assert.AreNotEqual(true, actual);
    }
}