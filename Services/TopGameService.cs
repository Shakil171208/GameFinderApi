using System.Collections.Generic;
using System.Linq;

public class TopGameService : ITopGameService
{
    private readonly DataContext _context;

    public TopGameService(DataContext context)
    {
        _context = context;
    }

    public List<TopGame> GetTopGame()
    {
        var result = _context.TopGames.ToList();

        return result;
    }

    public void AddTopGame(TopGame topGame)
    {
        _context.TopGames.Add(topGame);
        _context.SaveChanges();
    }

    public TopGame UpdateTopGame(int gameId, TopGame topGame)
    {
        var existingGame = _context.TopGames.FirstOrDefault(g => g.GameId == gameId);

        if (existingGame == null)
        {
            return new TopGame();
        }

        existingGame.GameId = topGame.GameId;
        existingGame.Name = topGame.Name;
        existingGame.Description = topGame.Description;
        existingGame.Genre = topGame.Genre;
        existingGame.ImageUrl = topGame.ImageUrl;
        existingGame.ReleasedDate = topGame.ReleasedDate;

        _context.SaveChanges();

        return existingGame;
    }

    public void DeleteTopGame(int id)
    {
        var game = _context.TopGames.FirstOrDefault(g => g.Id == id);
        if (game != null)
        {
            _context.TopGames.Remove(game);
            _context.SaveChanges();
        }
    }
}
