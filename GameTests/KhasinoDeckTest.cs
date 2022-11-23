using Khasino;
using Xunit;

namespace GameTests;

public class KhasinoDeckTest
{
    [Fact]
    public void GetDeck_Should_ReturnSetOfFourtyCards()
    {
        var khasinoDeck = new KhasinoDeck();

        var deck = khasinoDeck.Deck;
        
        Assert.Equal(40, deck.Count);
    }
}