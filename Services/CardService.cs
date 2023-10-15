using System.Collections.Generic;
using System.Linq;

public class CardService : ICardService
{
    private readonly DataContext _context;

    public CardService(DataContext context)
    {
        _context = context;
    }

    public List<Card> GetCards()
    {
        return _context.Cards.ToList();
    }
}