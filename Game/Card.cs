namespace Khasino;

public class Card : ICard
{

    private readonly CardSymbol _symbol;
    private readonly CardNumber _number;

    public Card(CardSymbol symbol, CardNumber number)
    {
        _symbol = symbol;
        _number = number;
    }
    public CardNumber GetNumber()
    {
        return _number;
    }

    public CardSymbol GetSymbol()
    {
        return _symbol;
    }

    public override string ToString()
    {
        return "{ " + _number + " : " + _symbol + " }";
    }
}