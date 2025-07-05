using library_api.DTOs;

namespace library_api.Interfaces;

public interface IPublisherService
{
    Task<PublisherDto?> GetPublisherByIdAsync(int id);
    Task<IEnumerable<PublisherDto>> GetAllPublishersAsync();
    Task<PublisherDto> CreatePublisherAsync(CreatePublisherDto createPublisherDto);
    Task<bool> UpdatePublisherAsync(int id, UpdatePublisherDto updatePublisherDto);
    Task<bool> DeletePublisherAsync(int id);
}