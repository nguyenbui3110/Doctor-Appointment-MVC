
namespace DoctorAppointment.Domain.Data;

public interface IRepository<TEntity>
{
    IQueryable<TEntity> GetAll();
    public IQueryable<TEntity> QueryGetById(int id);
    Task<TEntity?> GetByIdAsync(int id);

    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
    public Task<(IEnumerable<TEntity>, int)> ApplyPaing(IQueryable<TEntity> queryable, int page, int pageSize);
}
