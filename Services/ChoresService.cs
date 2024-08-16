
namespace thrive.Services;

public class ChoresService
{

  private readonly ChoresRepository _choresRepository;

  public ChoresService(ChoresRepository choresRepository)
  {
    _choresRepository = choresRepository;
  }


  internal List<Chore> getAllChores()
  {
    List<Chore> chores = _choresRepository.GetAllChores();
    return chores;
  }
}