using chore.Models;
using chore.Repositories;

namespace chores.Services;

public class ChoresService
{

    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _repo.GetAllChores();
        return chores;
    }

}