using library_api.Data;
using library_api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace library_api.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly LibraryDbContext Context;
    private readonly DbSet<T> _dbSet;

    protected Repository(LibraryDbContext context)
    {
        Context = context;
        _dbSet = Context.Set<T>();
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public virtual void Update(T entity)
    {
        _dbSet.Attach(entity);
        Context.Entry(entity).State = EntityState.Modified;
    }

    public virtual void Delete(T entity)
    {
        if (Context.Entry(entity).State == EntityState.Detached)
        {
            _dbSet.Attach(entity);
        }
        _dbSet.Remove(entity);
    }

    public virtual async Task<int> SaveChangesAsync()
    {
        return await Context.SaveChangesAsync();
    }
}