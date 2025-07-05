using library_api.DTOs;
using library_api.Models;

namespace library_api.Extensions;

public static class PublisherMapping
{
    public static PublisherDto ToDto(this Publisher publisher) => new(publisher.Id, publisher.Name);

    public static Publisher ToModel(this CreatePublisherDto dto) => new()
    {
        Name = dto.Name
    };

    public static void UpdateFromDto(this Publisher publisher, UpdatePublisherDto dto)
    {
        publisher.Name = dto.Name;
    }
}