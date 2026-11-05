namespace LibraryDesk.Core;

/// <summary>
/// Represents a library reader.
/// </summary>
public class Reader
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Reader"/> class.
    /// </summary>
    /// <param name="id">The identifier of the reader.</param>
    /// <param name="name">The name of the reader.</param>
    public Reader(int id, string name)
    {
        Id = id;
        Name = name;
        IsActive = true;
    }

    /// <summary>
    /// Gets or sets the identifier of the reader.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the reader.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the reader account is active.
    /// </summary>
    public bool IsActive { get; set; }
}
