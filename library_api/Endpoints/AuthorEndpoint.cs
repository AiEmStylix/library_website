using library_api.DTOs;
using library_api.Interfaces;

namespace library_api.Endpoints;

public static class AuthorEndpoint
{
    public static void MapAuthorEndpoints(this RouteGroupBuilder app)
    {
        var authorGroup = app.MapGroup("/authors").WithTags("Authors");

        authorGroup.MapGet("/", async (IAuthorService service) => Results.Ok(await service.GetAllAuthorsAsync()));

        authorGroup.MapGet("/{id:int}", async (int id, IAuthorService service) =>
        {
            var author = await service.GetAuthorByIdAsync(id);
            return author is not null ? Results.Ok(author) : Results.NotFound();
        });

        authorGroup.MapPost("/", async (CreateAuthorDto dto, IAuthorService service) =>
        {
            var createdAuthor = await service.CreateAuthorAsync(dto);
            return Results.Created($"/authors/{createdAuthor.Id}", createdAuthor);
        });

        authorGroup.MapPut("/{id:int}", async (int id, updateAuthorDto dto, IAuthorService service) =>
        {
            var updated = await service.UpdateAuthorAsync(id, dto);
            return updated ? Results.NoContent() : Results.NotFound();
        });

        authorGroup.MapDelete("{id:int}", async (int id, IAuthorService service) =>
        {
            var deleted = await service.DeleteAuthorAsync(id);
            return deleted ? Results.NoContent() : Results.NotFound();
        });
    }
}