namespace Khasino;

public class TwoPlayerKhasinoGame : KhasinoGame {

    public ICollection<ICollection<ICard>> GetDishedOutCards()
    {
        var dish = new List<ICollection<ICard>>();
        var playerOneCards = new List<ICard>();
        var playerTwoCards = new List<ICard>();
        var copyOfDeck = GameDeck.Deck.ToList();

        if (copyOfDeck.Count == 0) return dish;
        
        for (var i = 0; i < 20; i+=2)
        {
            playerTwoCards.Add(copyOfDeck[i]);
            playerOneCards.Add(copyOfDeck[i + 1]);

            GameDeck.Deck.Remove(copyOfDeck[i]);
            GameDeck.Deck.Remove(copyOfDeck[i + 1]);
        }
        
        dish.Add(playerOneCards);
        dish.Add(playerTwoCards);
        
        return dish;
    }
}