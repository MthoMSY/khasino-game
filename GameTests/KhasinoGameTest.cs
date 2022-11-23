using System.Linq;
using Khasino;
using Xunit;
using Xunit.Abstractions;

namespace GameTests;

public class KhasinoGameTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public KhasinoGameTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Shuffle_Should_ShuffleOrderOfDeckOfCardsRandomly()
    {
        var game = new KhasinoGame();
        var initialDeck = game.GameDeck.Deck;
        
        game.Shuffle();

        Assert.NotEqual(initialDeck, game.GameDeck.Deck);
    }
}