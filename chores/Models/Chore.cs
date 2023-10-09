namespace chore.Models;

public class Chore
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int Priority { get; set; }

    public Chore(int id, string name, string description, bool completed, int priority)
    {
        Id = id;
        Name = name;
        Description = description;
        Completed = completed;
        Priority = priority;
    }
}