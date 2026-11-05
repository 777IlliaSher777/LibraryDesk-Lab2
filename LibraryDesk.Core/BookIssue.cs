namespace LibraryDesk.Core;

using System;
using System.Collections.Generic;
using System.Globalization;

/// <summary>
/// Represents a book issue assigned to a reader.
/// </summary>
public class BookIssue
{
    /// <summary>
    /// Finds a book issue by its identifier.
    /// </summary>
    /// <param name="issues">The list of issues to search.</param>
    /// <param name="issueId">The identifier of the required issue.</param>
    /// <returns>The matching issue, or null if no issue is found.</returns>
    public static BookIssue? FindById(
        List<BookIssue> issues,
        string issueId)
    {
        for (int index = 0; index < issues.Count; index++)
        {
            if (issues[index].Id == issueId)
            {
                return issues[index];
            }
        }

        return null;
    }

    private const int _statusNew = 0;
    private const int _statusActive = 1;
    private const int _statusPartiallyReturned = 2;
    private const int _statusCancelled = 3;

    private const int _minReaderNameLength = 2;
    private const int _maxCopyLines = 100;

    private readonly List<string[]> _copies = new List<string[]>();

    /// <summary>
    /// Gets the issue identifier.
    /// </summary>
    public string Id { get; private set; }

    /// <summary>
    /// Gets the name of the reader associated with the issue.
    /// </summary>
    public string ReaderName { get; private set; }

    /// <summary>
    /// Gets the current status of the issue.
    /// </summary>
    public int Status { get; private set; }

    /// <summary>
    /// Gets the date and time when the issue was created.
    /// </summary>
    public DateTime CreatedAt { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookIssue"/> class.
    /// </summary>
    /// <param name="issueId">The identifier of the issue.</param>
    /// <param name="readerName">The name of the reader.</param>
    public BookIssue(string issueId, string readerName)
    {
        Id = issueId;
        ReaderName = readerName;
        Status = _statusNew;
        CreatedAt = DateTime.Now;
    }

    /// <summary>
    /// Adds a copy to the issue.
    /// </summary>
    /// <param name="copyId">The identifier of the copy.</param>
    /// <param name="quantity">The number of copies.</param>
    public void AddCopy(string copyId, int quantity)
    {
        string[] copyEntry = new string[2];
        copyEntry[0] = copyId;
        copyEntry[1] = quantity.ToString(CultureInfo.InvariantCulture);

        _copies.Add(copyEntry);
    }

    /// <summary>
    /// Calculates the total number of copies.
    /// </summary>
    /// <returns>The total number of copies.</returns>
    public int CalculateTotalCopies()
    {
        int totalCopies = 0;
        int lineCount = 0;

        for (int index = 0; index < _copies.Count; index++)
        {
            int quantity = int.Parse(
                _copies[index][1],
                CultureInfo.InvariantCulture);

            totalCopies = totalCopies + quantity;
            lineCount = lineCount + 1;
        }

        if (totalCopies < 0)
        {
            totalCopies = 0;
        }

        return totalCopies;
    }

    /// <summary>
    /// Changes the issue status according to the permitted transitions.
    /// </summary>
    /// <param name="newStatus">The new issue status.</param>
    /// <returns>True if the status was changed successfully; otherwise, false.</returns>
    public bool TryChangeStatus(int newStatus)
    {
        if (Status == _statusNew && newStatus == _statusActive)
        {
            Status = _statusActive;
            return true;
        }

        if (Status == _statusActive && newStatus == _statusPartiallyReturned)
        {
            Status = _statusPartiallyReturned;
            return true;
        }

        if (Status == _statusNew && newStatus == _statusCancelled)
        {
            Status = _statusCancelled;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Checks whether the issue data is valid.
    /// </summary>
    /// <returns>True if the issue data is valid; otherwise, false.</returns>
    public bool IsValid()
    {
        if (!string.IsNullOrEmpty(Id)
            && ReaderName.Length > _minReaderNameLength
            && _copies.Count < _maxCopyLines
            && Status >= _statusNew
            && Status <= _statusCancelled)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Generates a text report about the issue.
    /// </summary>
    /// <returns>A text report describing the issue.</returns>
    public string BuildReport()
    {
        string report = string.Empty;

        for (int index = 0; index < _copies.Count; index++)
        {
            report = report
                + "Примірник: " + _copies[index][0]
                + "; кількість: " + _copies[index][1]
                + "\n";
        }

        report = report
            + "Загальна кількість виданих примірників: "
            + CalculateTotalCopies()
            + "\n";

        return report;
    }
}
