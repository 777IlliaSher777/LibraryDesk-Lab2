using LibraryDesk.Core;

Reader reader = new Reader(1, "Ілля Шереметьєв");

Book book1 = new Book(
    "BK-001",
    "Кобзар",
    "Тарас Шевченко");

Book book2 = new Book(
    "BK-002",
    "Лісова пісня",
    "Леся Українка");

Loan loan = new Loan(1, reader);

loan.AddItem(new LoanItem(
    book1,
    new DateOnly(2026, 11, 15)));

loan.AddItem(new LoanItem(
    book2,
    new DateOnly(2026, 11, 20)));

loan.Status = LoanStatus.Active;

Console.WriteLine("LIBRARY DESK");
Console.WriteLine("-------------------------");
Console.WriteLine($"Номер видачі: {loan.Id}");
Console.WriteLine($"Читач: {loan.Reader.Name}");
Console.WriteLine($"Дата створення: {loan.CreatedAt}");
Console.WriteLine($"Стан: {loan.Status}");
Console.WriteLine("Видані книжки:");

foreach (LoanItem item in loan.Items)
{
    Console.WriteLine(
        $"{item.Book.Title} — {item.Book.Author}");

    Console.WriteLine(
        $"Інвентарний номер: {item.Book.InventoryNumber}");

    Console.WriteLine(
        $"Дата повернення: {item.DueDate}");
}
