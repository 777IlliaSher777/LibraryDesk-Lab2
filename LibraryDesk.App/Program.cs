using System.Text;
using LibraryDesk.Core;

Console.OutputEncoding = Encoding.UTF8;

var issue = new vidacha("A-1001", "Іваненко");

issue.Add("Примірник SKU-1", 3);
issue.Add("Примірник SKU-2", 12);

Console.WriteLine(issue.ProcessData());
Console.WriteLine(issue.Ck());
Console.WriteLine(issue.Chg(1));
Console.Write(issue.Rep());