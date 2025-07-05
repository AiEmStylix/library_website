using library_api.DTOs;
using library_api.Extensions;
using library_api.Interfaces;

namespace library_api.Services;

public class BookServices(IBookRepository repository) : IBookService
{
    public async Task<BookDto?> GetBookByIdAsync(int id)
    {
        var book = await repository.GetByIdAsync(id);
        
        return book?.ToDto();
    }

    public async Task<IEnumerable<BookDto>> GetAllBooksAsync()
    {
        var books = await repository.GetAllAsync();
        
        return books.Select(book => book.ToDto());
    }

    public async Task<BookDto> CreateBookAsync(CreateBookDto createBookDto)
    {
        var book = createBookDto.ToModel();
        
        await repository.AddAsync(book);
        await repository.SaveChangesAsync();
        return book.ToDto();
    }

    public async Task<bool> UpdateBookAsync(int id, UpdateBookDto updateBookDto)
    {
        // Make sure you are calling "GetByIdUNFILTEREDAsync" here
        var existingBook = await repository.GetByIdUnfilteredAsync(id);
    
        if (existingBook is null) return false;
    
        // ... rest of the method
        existingBook.UpdateFromDto(updateBookDto);
        repository.Update(existingBook);
        await repository.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteBookAsync(int id)
    {
        var bookToDelete = await repository.GetByIdUnfilteredAsync(id);
        if (bookToDelete is null || bookToDelete.IsDeleted) return false;
        repository.Delete(bookToDelete);
        await repository.SaveChangesAsync();
        return true;
    }
}
