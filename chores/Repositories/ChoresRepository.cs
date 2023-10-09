



namespace chores.Repositories;

public class ChoresRepository
{

    private List<Chore> _FakeDb;

    public ChoresRepository()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(1, "Sweep Floor", "Take Broom and sweep floor", false, 3));
        _FakeDb.Add(new Chore(2, "Vacuum", "Vacuum Living Room", false, 2));
        _FakeDb.Add(new Chore(3, "Load Dishwasher", "Rinse dishes & load the dishwasher", false, 3));
        _FakeDb.Add(new Chore(4, "Sweep Floor", "Take Broom and sweep floor", false, 1));
    }

    internal Chore CreateChore(Chore choreData)
    {
        int choreId = _FakeDb[_FakeDb.Count - 1].Id;
        choreData.Id = choreId + 1;
        _FakeDb.Add(choreData);
        return choreData;
    }

    internal List<Chore> GetAllChores()
    {
        return _FakeDb;
    }

    internal Chore GetOneChoreById(int choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        return chore;
    }

    internal void RemoveChore(int choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        _FakeDb.Remove(chore);
    }

    internal void RemoveChore(Chore chore)
    {
        _FakeDb.Remove(chore);
    }
}