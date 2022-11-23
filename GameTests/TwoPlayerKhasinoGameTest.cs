using System.Collections.Generic;
using System.Linq;
using Khasino;
using Xunit;

namespace GameTests;

public class TwoPlayerKhasinoGameTest
{
    [Fact]
    public void Dish_Should_ReturnAListWithTwoListsOfSizeTen()
    {
        var game = new TwoPlayerKhasinoGame();

        var dish = game.GetDishedOutCards();
        var playerOneCards = dish.First();
        var playerTwoCards = dish.Last();
        

        Assert.Equal(10 , playerOneCards.Count);
        Assert.Equal(10 , playerTwoCards.Count);
    }
    
    [Fact]
    public void Dish_Should_DecreaseDeckLenghtByTwentyForEachCallAndNotFailWhenCalledWithNoCardsOnDeck()
    {
        var emptyDish = new List<List<ICard>>();
        var game = new TwoPlayerKhasinoGame();
        Assert.Equal(40, game.GameDeck.Deck.Count);

        game.GetDishedOutCards();
        Assert.Equal(20, game.GameDeck.Deck.Count);
        
        game.GetDishedOutCards();
        Assert.Equal(0, game.GameDeck.Deck.Count);
        
        var dish = game.GetDishedOutCards();
        Assert.Equal(emptyDish, dish);
    }
}