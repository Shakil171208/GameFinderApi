using System.Collections.Generic;

public interface ITopGameService
{
    List<TopGame> GetTopGame();
    void AddTopGame(TopGame topGame);
    TopGame UpdateTopGame(int gameId, TopGame topGame);
}
