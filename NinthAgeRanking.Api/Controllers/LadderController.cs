using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using NinthAgeCmsToArmyBook.Shared.Ladder;

namespace NinthAgeCmsToArmyBook.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LadderController : ControllerBase
{
    private readonly IRankingReadmodelRepository _rankingReadmodelRepository;

    public LadderController(IRankingReadmodelRepository rankingReadmodelRepository)
    {
        _rankingReadmodelRepository = rankingReadmodelRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<PlayerRankingReadModel>>> GetRankings()
    {
        return Ok(new List<PlayerRankingReadModel>
        {
            new() { Id = ObjectId.GenerateNewId(), Name = "peter", Wins = 12, Losses = 34 },
            new() { Id = ObjectId.GenerateNewId(), Name = "peter2", Wins = 132, Losses = 434 },
            new() { Id = ObjectId.GenerateNewId(), Name = "peter3", Wins = 142, Losses = 344 },
            new() { Id = ObjectId.GenerateNewId(), Name = "peter4", Wins = 112, Losses = 314 }
        });
    }
}