namespace LibraryDesk.Core;

/// <summary>
/// Defines the possible statuses of a book loan.
/// </summary>
public enum LoanStatus
{
    /// <summary>
    /// A new loan that has not yet been activated.
    /// </summary>
    New,

    /// <summary>
    /// An active book loan.
    /// </summary>
    Active,

    /// <summary>
    /// Some books in the loan have been returned.
    /// </summary>
    PartiallyReturned,

    /// <summary>
    /// All books in the loan have been returned.
    /// </summary>
    Returned,

    /// <summary>
    /// The loan has been cancelled.
    /// </summary>
    Cancelled
}
