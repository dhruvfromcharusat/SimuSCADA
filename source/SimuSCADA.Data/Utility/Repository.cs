using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using SimuSCADA.Data.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Data.Utility;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly IMongoDatabase _database;

    public Repository(IOptions<MongoDatabaseOptions> mongoDBSettings)
    {
        MongoClient client = new(mongoDBSettings.Value.ConnectionString);
        _database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
    }

    public async Task Create(T entity)
    {
        await GetCollection().InsertOneAsync(entity).ConfigureAwait(false);
    }

    public async Task Delete(Expression<Func<T, bool>>? filter)
    {
        await GetCollection().DeleteOneAsync(filter).ConfigureAwait(false);
    }

    public async Task<T?> Get(Expression<Func<T, bool>> filter)
    {
        return await GetCollection().Find(filter).FirstOrDefaultAsync().ConfigureAwait(false);
    }

    public async Task<List<T>?> GetAll(Expression<Func<T, bool>>? filter = null)
    {
        if (filter == null)
        {
            return await AsQueryable().Where(_ => true).ToListAsync().ConfigureAwait(false);
        }

        return await AsQueryable().Where(filter).ToListAsync().ConfigureAwait(false);
    }

    public async Task Replace(T newEntity, Expression<Func<T, bool>>? filter)
    {
        await GetCollection().ReplaceOneAsync(filter, newEntity).ConfigureAwait(false);
    }

    public async Task<T?> Update(Expression<Func<T, bool>> filter, UpdateDefinition<T> updateDefinition)
    {
        return await GetCollection().FindOneAndUpdateAsync(filter, updateDefinition, new FindOneAndUpdateOptions<T> { ReturnDocument = ReturnDocument.After }).ConfigureAwait(false);
    }

    public IMongoQueryable<T> AsQueryable()
    {
        return GetCollection().AsQueryable();
    }

    private IMongoCollection<T> GetCollection()
    {
        var collectionName = typeof(T).Name;
        return _database.GetCollection<T>(collectionName);
    }
}