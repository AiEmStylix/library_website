using library_api.DTOs;
using library_api.Models;

namespace library_api.Extensions;

public static class AuthorMapping
{
    public static AuthorDto ToDto(this Author author) => new(author.Id, author.Name);

    public static Author ToModel(this CreateAuthorDto dto) => new()
    {
        Name = dto.Name
    };

    public static void UpdateFromDto(this Author author, updateAuthorDto dto)
    {
        author.Name = dto.Name;
    }
}