namespace LibraryDesk.Core;

public class LoanItem
{
    public LoanItem(Book book, DateOnly dueDate)
    {
        Book = book;
        DueDate = dueDate;
        IsReturned = false;
    }

    public Book Book { get; set; }

    public DateOnly DueDate { get; set; }

    public bool IsReturned { get; set; }
}
