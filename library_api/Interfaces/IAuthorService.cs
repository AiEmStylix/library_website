using library_api.DTOs;

namespace library_api.Interfaces;

public interface IAuthorService
{
    Task<AuthorDto?> GetAuthorByIdAsync(int id);
    Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync();
    Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto createAuthorDto);
    Task<bool> UpdateAuthorAsync(int id, updateAuthorDto updateAuthorDto);
    Task<bool> DeleteAuthorAsync(int id);
}