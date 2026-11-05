namespace LibraryDesk.Core;

/// <summary>
/// Represents a book in the library catalog.
/// </summary>
public class Book
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Book"/> class.
    /// </summary>
    /// <param name="inventoryNumber">The inventory number of the book.</param>
    /// <param name="title">The title of the book.</param>
    /// <param name="author">The author of the book.</param>
    public Book(string inventoryNumber, string title, string author)
    {
        InventoryNumber = inventoryNumber;
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    /// <summary>
    /// Gets or sets the inventory number of the book.
    /// </summary>
    public string InventoryNumber { get; set; }

    /// <summary>
    /// Gets or sets the title of the book.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the author of the book.
    /// </summary>
    public string Author { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the book is available for issue.
    /// </summary>
    public bool IsAvailable { get; set; }
}
