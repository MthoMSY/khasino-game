namespace Khasino;

public class KhasinoDeck: IDeck
{
    private ISet<ICard> deck = new HashSet<ICard>
    {
        new Card(CardSymbol.Club, CardNumber.One),
        new Card(CardSymbol.Spade, CardNumber.One),
        new Card(CardSymbol.Heart, CardNumber.One),
        new Card(CardSymbol.Diamond, CardNumber.One),

        new Card(CardSymbol.Club, CardNumber.Two),
        new Card(CardSymbol.Spade, CardNumber.Two),
        new Card(CardSymbol.Heart, CardNumber.Two),
        new Card(CardSymbol.Diamond, CardNumber.Two),

        new Card(CardSymbol.Club, CardNumber.Three),
        new Card(CardSymbol.Spade, CardNumber.Three),
        new Card(CardSymbol.Heart, CardNumber.Three),
        new Card(CardSymbol.Diamond, CardNumber.Three),

        new Card(CardSymbol.Club, CardNumber.Four),
        new Card(CardSymbol.Spade, CardNumber.Four),
        new Card(CardSymbol.Heart, CardNumber.Four),
        new Card(CardSymbol.Diamond, CardNumber.Four),

        new Card(CardSymbol.Club, CardNumber.Five),
        new Card(CardSymbol.Spade, CardNumber.Five),
        new Card(CardSymbol.Heart, CardNumber.Five),
        new Card(CardSymbol.Diamond, CardNumber.Five),

        new Card(CardSymbol.Club, CardNumber.Six),
        new Card(CardSymbol.Spade, CardNumber.Six),
        new Card(CardSymbol.Heart, CardNumber.Six),
        new Card(CardSymbol.Diamond, CardNumber.Six),

        new Card(CardSymbol.Club, CardNumber.Seven),
        new Card(CardSymbol.Spade, CardNumber.Seven),
        new Card(CardSymbol.Heart, CardNumber.Seven),
        new Card(CardSymbol.Diamond, CardNumber.Seven),

        new Card(CardSymbol.Club, CardNumber.Eight),
        new Card(CardSymbol.Spade, CardNumber.Eight),
        new Card(CardSymbol.Heart, CardNumber.Eight),
        new Card(CardSymbol.Diamond, CardNumber.Eight),

        new Card(CardSymbol.Club, CardNumber.Nine),
        new Card(CardSymbol.Spade, CardNumber.Nine),
        new Card(CardSymbol.Heart, CardNumber.Nine),
        new Card(CardSymbol.Diamond, CardNumber.Nine),

        new Card(CardSymbol.Club, CardNumber.Ten),
        new Card(CardSymbol.Spade, CardNumber.Ten),
        new Card(CardSymbol.Heart, CardNumber.Ten),
        new Card(CardSymbol.Diamond, CardNumber.Ten)
    };
        
    public ISet<ICard> getDeck()
    {
        return deck;
    }
}