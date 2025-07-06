using library_api.DTOs;
using library_api.Interfaces;

namespace library_api.Endpoints
{
    /// <summary>
    /// Contains extension methods for mapping book-related API endpoints.
    /// </summary>
    public static class BookEndpoints
    {
        /// <summary>
        /// Maps all endpoints related to books.
        /// </summary>
        /// <param name="app">The endpoint route builder to map the routes to.</param>
        public static void MapBookEndpoints(this RouteGroupBuilder app)
        {
            // Group endpoints for better organization and to apply common settings
            var bookGroup = app.MapGroup("/books").WithTags("Books");

            bookGroup.MapGet("/", async (IBookService service) =>
                Results.Ok(await service.GetAllBooksAsync()));

            bookGroup.MapGet("/{id:int}", async (int id, IBookService service) =>
            {
                var book = await service.GetBookByIdAsync(id);
                return book is not null ? Results.Ok(book) : Results.NotFound();
            });

            bookGroup.MapPost("/", async (CreateBookDto dto, IBookService service) =>
            {
                var createdBook = await service.CreateBookAsync(dto);
                return Results.Created($"/books/{createdBook.Id}", createdBook);
            });

            bookGroup.MapPut("/{id:int}", async (int id, UpdateBookDto dto, IBookService service) =>
            {
                var updated = await service.UpdateBookAsync(id, dto);
                return updated ? Results.NoContent() : Results.NotFound();
            });

            bookGroup.MapDelete("/{id:int}", async (int id, IBookService service) =>
            {
                var deleted = await service.DeleteBookAsync(id);
                return deleted ? Results.NoContent() : Results.NotFound();
            });
        }
    }
}