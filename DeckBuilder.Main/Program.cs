//runs program

DeckBuilderManager deckBuilder = new DeckBuilderManager();

Console.WriteLine("Welcome to the Magic the Gathering Deck Builder!");
Console.WriteLine("What would you like to do?");
Console.WriteLine(@"1: Make a deck
2: Delete a deck
3: Print a deck");
deckBuilder.userInput = Console.ReadLine();

deckBuilder.Manager(deckBuilder.userInput);

Console.WriteLine("This is a test");