namespace LibraryDesk.Core;

/// <summary>
/// Represents an individual book item in a loan.
/// </summary>
public class LoanItem
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LoanItem"/> class.
    /// </summary>
    /// <param name="book">The book included in the loan.</param>
    /// <param name="dueDate">The date when the book must be returned.</param>
    public LoanItem(Book book, DateOnly dueDate)
    {
        Book = book;
        DueDate = dueDate;
        IsReturned = false;
    }

    /// <summary>
    /// Gets or sets the book associated with the loan item.
    /// </summary>
    public Book Book { get; set; }

    /// <summary>
    /// Gets or sets the due date for returning the book.
    /// </summary>
    public DateOnly DueDate { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the book has been returned.
    /// </summary>
    public bool IsReturned { get; set; }
}
