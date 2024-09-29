using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Data.Utility;

public interface IRepository<T> where T : class
{
    Task<List<T>?> GetAll(Expression<Func<T, bool>>? filter = null!);

    Task<T?> Get(Expression<Func<T, bool>> filter);

    Task Create(T entity);

    Task Delete(Expression<Func<T, bool>> filter);

    Task<T?> Update(Expression<Func<T, bool>> filter, UpdateDefinition<T> updateDefinition);

    Task Replace(T newEntity, Expression<Func<T, bool>>? filter);

    IMongoQueryable<T> AsQueryable();
}