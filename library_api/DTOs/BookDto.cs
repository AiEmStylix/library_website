using System.ComponentModel.DataAnnotations;

namespace library_api.DTOs;

/// <summary>
/// Data sent TO the client. It includes human-readable names.
/// </summary>
public record BookDto(
    int Id,
    string Title,
    string AuthorName,
    string PublisherName,
    string? Isbn,
    DateTime PublishedDate
);

/// <summary>
/// Data received FROM the client to create a new book. It uses IDs for relationships.
/// </summary>
public record CreateBookDto(
    [Required] string Title,
    [Required] int AuthorId,
    [Required] int PublisherId,
    string? Isbn,
    DateTime PublishedDate
);

/// <summary>
/// Data received FROM the client to update a book.
/// </summary>
public record UpdateBookDto(
    [Required] string Title,
    [Required] int AuthorId,
    [Required] int PublisherId,
    string? Isbn,
    DateTime PublishedDate
);