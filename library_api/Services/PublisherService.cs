using library_api.DTOs;
using library_api.Extensions;
using library_api.Interfaces;

namespace library_api.Services;

public class PublisherService(IPublisherRepository repository) : IPublisherService
{
    public async Task<PublisherDto?> GetPublisherByIdAsync(int id)
    {
        var publisher = await repository.GetByIdAsync(id);
        return publisher?.ToDto();
    }

    public async Task<IEnumerable<PublisherDto>> GetAllPublishersAsync()
    {
        var publishers = await repository.GetAllAsync();
        return publishers.Select(publisher => publisher.ToDto());
    }

    public async Task<PublisherDto> CreatePublisherAsync(CreatePublisherDto createPublisherDto)
    {
        var publisher = createPublisherDto.ToModel();

        await repository.AddAsync(publisher);
        await repository.SaveChangesAsync();
        return publisher.ToDto();
    }

    public async Task<bool> UpdatePublisherAsync(int id, UpdatePublisherDto updatePublisherDto)
    {
        var updatedPublisher = await repository.GetByIdAsync(id);
        if (updatedPublisher is null) return false;
        
        updatedPublisher.UpdateFromDto(updatePublisherDto);
        repository.Update(updatedPublisher);
        await repository.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeletePublisherAsync(int id)
    {
        var publisherToDelete = await repository.GetByIdAsync(id);
        if (publisherToDelete is null) return false;
        
        repository.Delete(publisherToDelete);
        await repository.SaveChangesAsync();
        return true;
    }
}