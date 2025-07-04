using library_api.DTOs;
using library_api.Interfaces;
using library_api.Extensions;

namespace library_api.Services;

public class AuthorServices(IAuthorRepository repository) : IAuthorService
{
    public async Task<AuthorDto?> GetAuthorByIdAsync(int id)
    {
        var author = await repository.GetByIdAsync(id);
        return author?.ToDto();
    }

    public async Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync()
    {
        var authors = await repository.GetAllAsync();
        return authors.Select(author => author.ToDto());
    }

    public async Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto createAuthorDto)
    {
        var author = createAuthorDto.ToModel();

        await repository.AddAsync(author);
        await repository.SaveChangesAsync();
        return author.ToDto();
    }

    public async Task<bool> UpdateAuthorAsync(int id, updateAuthorDto updateAuthorDto)
    {
        var existingAuthor = await repository.GetByIdAsync(id);

        if (existingAuthor is null) return false;
        
        existingAuthor.UpdateFromDto(updateAuthorDto);
        
        repository.Update(existingAuthor);
        await repository.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAuthorAsync(int id)
    {
        var authorToDelete = await repository.GetByIdAsync(id);
        if (authorToDelete is null) return false;
        repository.Delete(authorToDelete);
        await repository.SaveChangesAsync();
        return true;
    }
}