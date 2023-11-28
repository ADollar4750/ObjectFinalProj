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
        Creature expected = new Creature(){
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
}