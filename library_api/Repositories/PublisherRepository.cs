using library_api.Data;
using library_api.Interfaces;
using library_api.Models;

namespace library_api.Repositories;

public class PublisherRepository(LibraryDbContext context) :Repository<Publisher>(context), IPublisherRepository
{
    
}