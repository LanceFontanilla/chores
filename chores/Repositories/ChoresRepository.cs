using chore.Models;

namespace chore.Repositories;

public class ChoresRepository
{

    private List<Chore> _FakeDb;

    public ChoresRepository()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(1, "Sweep Floor", "Take Broom and sweep floor", false, 3));
        _FakeDb.Add(new Chore(1, "Vacuum", "Vacuum Living Room", false, 2));
        _FakeDb.Add(new Chore(1, "Load Dishwasher", "Rinse dishes & load the dishwasher", false, 3));
        _FakeDb.Add(new Chore(1, "Sweep Floor", "Take Broom and sweep floor", false, 1));
    }

    internal List<Chore> GetAllChores()
    {
        return _FakeDb;
    }
}