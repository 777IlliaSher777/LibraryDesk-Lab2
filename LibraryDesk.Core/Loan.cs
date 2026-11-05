namespace LibraryDesk.Core;

/// <summary>
/// Represents a book loan assigned to a reader.
/// </summary>
public class Loan
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Loan"/> class.
    /// </summary>
    /// <param name="id">The identifier of the loan.</param>
    /// <param name="reader">The reader associated with the loan.</param>
    public Loan(int id, Reader reader)
    {
        Id = id;
        Reader = reader;
        CreatedAt = DateTimeOffset.Now;
        Status = LoanStatus.New;
        Items = new List<LoanItem>();
    }

    /// <summary>
    /// Gets or sets the identifier of the loan.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the reader associated with the loan.
    /// </summary>
    public Reader Reader { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the loan was created.
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the current status of the loan.
    /// </summary>
    public LoanStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the list of items included in the loan.
    /// </summary>
    public List<LoanItem> Items { get; set; }

    /// <summary>
    /// Adds an item to the loan.
    /// </summary>
    /// <param name="item">The item to add to the loan.</param>
    public void AddItem(LoanItem item)
    {
        Items.Add(item);
    }
}
