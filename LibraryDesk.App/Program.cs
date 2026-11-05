using System.Text;
using LibraryDesk.Core;

Console.OutputEncoding = Encoding.UTF8;

var issue = new BookIssue("A-1001", "Іваненко");

issue.AddCopy("Примірник SKU-1", 3);
issue.AddCopy("Примірник SKU-2", 12);

Console.WriteLine(issue.CalculateTotalCopies());
Console.WriteLine(issue.IsValid());
Console.WriteLine(issue.TryChangeStatus(1));
Console.Write(issue.BuildReport());