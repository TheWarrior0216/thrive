using Microsoft.AspNetCore.Http.HttpResults;

namespace thrive.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{

  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]

  public ActionResult<List<Chore>> GetAllChores()
  {
    try
    {
      List<Chore> chores = _choresService.getAllChores();
      return Ok(chores);
    }
    catch (Exception exception)
    {

      return BadRequest(exception.Message);
    }
  }
}
