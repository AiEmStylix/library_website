namespace library_api.DTOs;

public record AuthorDto(int Id, string Name);

public record CreateAuthorDto(string Name);

public record updateAuthorDto(string Name);