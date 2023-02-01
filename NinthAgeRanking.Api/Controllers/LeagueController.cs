using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NinthAgeCmsToArmyBook.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LeagueController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> GetChangesForArmy()
    {
        return Ok();
    }
}