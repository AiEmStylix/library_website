using System.ComponentModel.DataAnnotations;

namespace library_api.DTOs;

public record AuthorDto(int Id, string Name);

public record CreateAuthorDto([Required] string Name);

public record updateAuthorDto([Required] string Name);