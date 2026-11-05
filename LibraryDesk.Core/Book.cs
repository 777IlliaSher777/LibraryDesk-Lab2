namespace LibraryDesk.Core;

public class Book
{
    public Book(string inventoryNumber, string title, string author)
    {
        InventoryNumber = inventoryNumber;
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public string InventoryNumber { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public bool IsAvailable { get; set; }
}
