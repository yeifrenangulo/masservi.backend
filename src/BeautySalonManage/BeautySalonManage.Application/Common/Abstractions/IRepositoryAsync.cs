﻿using Ardalis.Specification;
using System.Linq.Expressions;

namespace BeautySalonManage.Application.Common.Abstractions;

public interface IRepositoryAsync<TEntity> : IRepositoryBase<TEntity>, IReadRepositoryBase<TEntity> where TEntity : class
{
    Task DeleteRangeAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
    Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
    Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
}
