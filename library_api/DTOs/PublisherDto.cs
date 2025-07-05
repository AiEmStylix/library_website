namespace library_api.DTOs;

public record PublisherDto(int Id, string Name);

public record CreatePublisherDto(string Name);

public record UpdatePublisherDto(string Name);