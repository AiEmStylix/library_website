using library_api.DTOs;
using library_api.Interfaces;

namespace library_api.Endpoints;

public static class PublisherEndpoint
{
    public static void MapPublisherEndpoint(this RouteGroupBuilder app)
    {
        var publisherGroup = app.MapGroup("/publishers").WithTags("Publishers");

        publisherGroup.MapGet("/",
            async (IPublisherService service) => Results.Ok(await service.GetAllPublishersAsync()));

        publisherGroup.MapGet("/{id:int}", async (IPublisherService service, int id) =>
        {
            var publisher = await service.GetPublisherByIdAsync(id);
            return publisher is not null ? Results.Ok(publisher) : Results.NotFound();
        });

        publisherGroup.MapPost("/", async (IPublisherService service, CreatePublisherDto dto) =>
        {
            var created = await service.CreatePublisherAsync(dto);
            return Results.Created($"/publishers/{created.Id}", created);
        });

        publisherGroup.MapPut("/{id:int}", async (IPublisherService service, int id, UpdatePublisherDto dto) =>
        {
            var updated = await service.UpdatePublisherAsync(id, dto);
            return updated ? Results.NoContent() : Results.NotFound();
        });

        publisherGroup.MapDelete("/{id:int}", async (IPublisherService service, int id) =>
        {
            var deleted = await service.DeletePublisherAsync(id);
            return deleted ? Results.NoContent() : Results.NotFound();
        });
    }
}