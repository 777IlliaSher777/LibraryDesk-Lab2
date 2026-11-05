namespace LibraryDesk.Core;

public class Loan
{
    public Loan(int id, Reader reader)
    {
        Id = id;
        Reader = reader;
        CreatedAt = DateTimeOffset.Now;
        Status = LoanStatus.New;
        Items = new List<LoanItem>();
    }

    public int Id { get; set; }

    public Reader Reader { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public LoanStatus Status { get; set; }

    public List<LoanItem> Items { get; set; }

    public void AddItem(LoanItem item)
    {
        Items.Add(item);
    }
}
