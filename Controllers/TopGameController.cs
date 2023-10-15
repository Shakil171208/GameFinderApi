using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/topgames")]
public class TopGameController : ControllerBase
{
    private readonly ITopGameService _topGameService;

    public TopGameController(ITopGameService topGameService)
    {
        _topGameService = topGameService;
    }

    [HttpGet]
    public IActionResult GetTopGame()
    {
        var topGame = _topGameService.GetTopGame();

        if (topGame == null)
        {
            return NotFound();
        }

        return Ok(topGame);
    }

    [HttpPost]
    public IActionResult AddTopGame([FromBody] TopGame topGame)
     {
        if (topGame == null)
        {
            return BadRequest("Invalid data");
        }

        _topGameService.AddTopGame(topGame);

        return CreatedAtAction(nameof(GetTopGame), new { id = topGame.Id }, topGame);
    }
}