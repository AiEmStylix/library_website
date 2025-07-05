using library_api.DTOs;
using library_api.Models;

namespace library_api.Extensions;

public static class BookMapping
{
    // Maps the Book entity to a DTO, including Author and Publisher names
    public static BookDto ToDto(this Book book) =>
        new(
            book.Id,
            book.Title,
            book.Author?.Name ?? "Unknown Author",
            book.Publisher?.Name ?? "Unknown Publisher",   // Correctly access the Publisher's name
            book.Isbn,
            book.PublishedDate
        );

    // Maps a CreateBookDto to a new Book entity
    public static Book ToModel(this CreateBookDto dto) =>
        new()
        {
            Title = dto.Title,
            AuthorId = dto.AuthorId,          // Set the foreign key
            PublisherId = dto.PublisherId,    // Set the foreign key
            Isbn = dto.Isbn,
            PublishedDate = dto.PublishedDate
        };

    // Updates an existing Book entity from an UpdateBookDto
    public static void UpdateFromDto(this Book book, UpdateBookDto dto)
    {
        book.Title = dto.Title;
        book.AuthorId = dto.AuthorId;          // Update the foreign key
        book.PublisherId = dto.PublisherId;    // Update the foreign key
        book.Isbn = dto.Isbn;
        book.PublishedDate = dto.PublishedDate;
    }
}