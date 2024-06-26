﻿#if NETCOREAPP3_1_OR_GREATER
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Couchbase.Analytics;
using Couchbase.KeyValue;
using Couchbase.Management.Eventing;
using Couchbase.Management.Search;
using Couchbase.Query;

namespace Couchbase.Stellar.KeyValue;

#nullable enable

internal class StellarScope : IScope
{
    private const string DefaultScopeName = "_default";
    private readonly StellarBucket _stellarBucket;
    private readonly StellarCluster _stellarCluster;
    private readonly ConcurrentDictionary<string, ICouchbaseCollection> _collections = new();

    public StellarScope(string name, StellarBucket stellarBucket, StellarCluster stellarCluster)
    {
        Name = name;
        _stellarBucket = stellarBucket;
        _stellarCluster = stellarCluster;
        IsDefaultScope = Name == DefaultScopeName;
    }

    public ICouchbaseCollection this[string name] => Collection(name);

    public string Name { get; }

    public IBucket Bucket => _stellarBucket;

    public bool IsDefaultScope { get; }

    public Task<IAnalyticsResult<T>> AnalyticsQueryAsync<T>(string statement, AnalyticsOptions? options = null)
    {
        _stellarCluster.ThrowIfBootStrapFailed();

        options ??= new AnalyticsOptions();
        options.BucketName = Name;
        return _stellarCluster.AnalyticsQueryAsync<T>(statement, options);
    }

    public IEventingFunctionManager EventingFunctions => throw new NotImplementedException();
    public ISearchIndexManager SearchIndexes => throw new NotImplementedException();

    public ICouchbaseCollection Collection(string collectionName)
    {
        return _collections.GetOrAdd(collectionName, new StellarCollection(collectionName, this, _stellarCluster));
    }

    public ValueTask<ICouchbaseCollection> CollectionAsync(string collectionName) => ValueTask.FromResult(Collection(collectionName));

    public async Task<IQueryResult<T>> QueryAsync<T>(string statement, QueryOptions? options = null)
    {
        _stellarCluster.ThrowIfBootStrapFailed();

        options ??= QueryOptions.Default;
        options.BucketName = Bucket.Name;
        options.ScopeName = Name;

        return await _stellarCluster.QueryAsync<T>(statement, options).ConfigureAwait(false);
    }
}
#endif
