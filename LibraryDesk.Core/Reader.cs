namespace LibraryDesk.Core;

public class Reader
{
    public Reader(int id, string name)
    {
        Id = id;
        Name = name;
        IsActive = true;
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }
}
