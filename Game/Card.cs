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
    public CardNumber getNumber()
    {
        return _number;
    }

    public CardSymbol getSymbol()
    {
        return _symbol;
    }
}