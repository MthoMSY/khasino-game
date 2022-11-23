namespace Khasino;

public class KhasinoGame
{
    public KhasinoDeck GameDeck { get; }

    public KhasinoGame()
    {
        GameDeck = new KhasinoDeck();
    }
    public void Shuffle()
    {
        var randomGenerator = new Random();
        var deckListToShuffle = GameDeck.Deck.ToList();

        var count = deckListToShuffle.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i) {
            var r = randomGenerator.Next(0, 40);
            // swap
            (deckListToShuffle[i], deckListToShuffle[r]) = (deckListToShuffle[r], deckListToShuffle[i]);
        }
        
        GameDeck.Deck = deckListToShuffle.ToHashSet();
    }
}