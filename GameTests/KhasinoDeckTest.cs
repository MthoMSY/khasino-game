using Khasino;
using Xunit;

namespace GameTests;

public class KhasinoDeckTest
{
    [Fact]
    public void getDeck_Should_ReturnSetOfFourtyCards()
    {
        var khasinoDeck = new KhasinoDeck();

        var deck = khasinoDeck.getDeck();
        
        Assert.Equal(40, deck.Count);
    }
}