using Ordering.Domain.Common;
using System;
using System.Linq.Expressions;

namespace Ordering.Application.Contracts.Persistence
{
    internal interface IEntityBaseRepository<T> where T : EntityBase
    {
        Task<IReadOnlyList<T>> GetAllEntityBaseAsync();
        Task<IReadOnlyList<T>> GetEntityBaseAsync(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> GetEntityBaseAsync(Expression<Func<T, bool>> predicate = null,
                                                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                    string includeString = null,
                                                    bool disableTracking = true);
        Task<IReadOnlyList<T>> GetEntityBaseAsync(Expression<Func<T, bool>> predicate = null,
                                                   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                   List<Expression<Func<T, object>>> includes = null,
                                                   bool disableTracking = true);
        Task<T> GetEntityBaseByIdAsync(int id);
        Task<T> AddEntityBaseAsync(T entity);
        Task UpdateEntityBaseAsync(T entity);
        Task DeleteEntityBaseAsync(T entity);
    }
}
