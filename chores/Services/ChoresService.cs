

using System.Data.Common;

namespace chores.Services;

public class ChoresService
{

    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _repo.GetAllChores();
        return chores;
    }

    internal Chore GetOneChoreById(int choreId)
    {
        Chore chore = _repo.GetOneChoreById(choreId);
        if (chore == null) throw new Exception($"no chore with that id {choreId}");
        return chore;
    }

    internal string RemoveChore(int choreId)
    {
        Chore chore = this.GetOneChoreById(choreId);

        _repo.RemoveChore(choreId);

        return $"{chore.Name} has been completed";
    }
}