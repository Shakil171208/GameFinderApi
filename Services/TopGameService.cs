using System.Collections.Generic;
using System.Linq;

public class TopGameService : ITopGameService
{
    private readonly DataContext _context;

    public TopGameService(DataContext context)
    {
        _context = context;
    }

    public List<TopGame>  GetTopGame()
    { 
         var result = _context.TopGames.ToList();
         
         return result;
    }

    public void AddTopGame(TopGame topGame)
    {
        _context.TopGames.Add(topGame);
        _context.SaveChanges();
    }

}
