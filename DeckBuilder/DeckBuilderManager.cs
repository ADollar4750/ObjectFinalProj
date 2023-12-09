using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using Microsoft.VisualBasic;
//this runs fuctions with most of the program in gathering all the info
public class DeckBuilderManager
{
    public string deckName;
    public string userInput = "";

    //properties with private data members
    private string nameofCard = "";
    private string manaofCard = "";
    private string ifLengndary = "";
    private string abilityofCard = "";


    DeckBuilderApp app = new DeckBuilderApp();
    JSonScribe scribe = new JSonScribe();
    public void Manager(string userInput)
    {
        bool running = false;
        while (running != true)
        {


            if (userInput == "1")
            {
                Console.WriteLine("Please type in the name of your deck:");
                deckName = Console.ReadLine();
                Console.WriteLine(@"Would you like to:
            Add card: 1
            Remove card: 2
            Stop program: 3");


                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine(@"What card type will you be adding?
                Creature
                Instant
                Sorcery
                Artifact
                Enchantment
                Land");


                    userInput = Console.ReadLine();
                    if (userInput == "Creature")
                    {
                        string creatureTypeofCard = "";
                        string powerofCard = "";
                        string toughnessofCard = "";

                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Creature type that includes if it is a artifact or enchantment creature: ");
                        creatureTypeofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Creatures power: ");
                        powerofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Creatures toughtness: ");
                        toughnessofCard = Console.ReadLine();

                        Creature userCreature = new Creature()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            CreatureType = creatureTypeofCard,
                            Ability = abilityofCard,
                            Power = int.Parse(powerofCard),
                            Toughness = int.Parse(toughnessofCard),
                        };
                        app.AddCard(userCreature);
                    }

                    else if (userInput == "Instant")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Instant userInstant = new Instant()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Ability = abilityofCard,
                        };
                        app.AddCard(userInstant);
                    }

                    else if (userInput == "Sorcery")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Sorcery userSorcery = new Sorcery()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.AddCard(userSorcery);
                    }
                    else if (userInput == "Artifact")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Artifact userArtifact = new Artifact()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.AddCard(userArtifact);
                    }
                    else if (userInput == "Enchantment")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Enchantment userEnchantment = new Enchantment()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.AddCard(userEnchantment);
                    }
                    else if (userInput == "Land")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Land userLand = new Land()
                        {
                            Name = nameofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.AddCard(userLand);
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine(@"What card type will you be adding?
                Creature
                Instant
                Sorcery
                Artifact
                Enchantment
                Land");


                    userInput = Console.ReadLine();
                    if (userInput == "Creature")
                    {
                        string creatureTypeofCard = "";
                        string powerofCard = "";
                        string toughnessofCard = "";

                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Creature type that includes if it is a artifact or enchantment creature: ");
                        creatureTypeofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Creatures power: ");
                        powerofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Creatures toughtness: ");
                        toughnessofCard = Console.ReadLine();

                        Creature userCreature = new Creature()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            CreatureType = creatureTypeofCard,
                            Ability = abilityofCard,
                            Power = int.Parse(powerofCard),
                            Toughness = int.Parse(toughnessofCard),
                        };
                        app.RemoveCard(userCreature);
                    }

                    else if (userInput == "Instant")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Instant userInstant = new Instant()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Ability = abilityofCard,
                        };
                        app.RemoveCard(userInstant);
                    }

                    else if (userInput == "Sorcery")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Sorcery userSorcery = new Sorcery()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.RemoveCard(userSorcery);
                    }
                    else if (userInput == "Artifact")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Artifact userArtifact = new Artifact()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.RemoveCard(userArtifact);
                    }
                    else if (userInput == "Enchantment")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type in the Mana Cost: ");
                        manaofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Enchantment userEnchantment = new Enchantment()
                        {
                            Name = nameofCard,
                            ManaCost = manaofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.RemoveCard(userEnchantment);
                    }
                    else if (userInput == "Land")
                    {
                        Console.WriteLine("Please type in the Name: ");
                        nameofCard = Console.ReadLine();
                        Console.WriteLine("Please type if the card is legendary: ");
                        ifLengndary = Console.ReadLine();
                        Console.WriteLine("Please type the cards Ability");
                        abilityofCard = Console.ReadLine();

                        Land userLand = new Land()
                        {
                            Name = nameofCard,
                            Legendary = bool.Parse(ifLengndary),
                            Ability = abilityofCard,
                        };
                        app.RemoveCard(userLand);
                    }
                }
                else if (userInput == "3")
                {
                    running = true;
                    scribe.deckFileMaker(app.Deck);
                }
            }
            else if (userInput == "2")
            {

            }
            else if (userInput == "3")
            {

            }
        }
    }
}