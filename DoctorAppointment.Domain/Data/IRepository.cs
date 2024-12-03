using System;
using System.Linq.Expressions;

namespace DoctorAppointment.Domain.Data;

public interface IRepository<TEntity>
{
    IQueryable<TEntity> GetAll();
    Task<TEntity?> GetByIdAsync(int id);

    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
    public Task<(IEnumerable<TEntity>, int)> ApplyPaing(IQueryable<TEntity> queryable, int page, int pageSize);
}
