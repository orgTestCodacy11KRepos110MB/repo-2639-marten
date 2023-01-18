using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using JasperFx.Core;
using BenchmarkDotNet.Attributes;
using Marten;
using Marten.Linq;
using Marten.Testing.Documents;

namespace MartenBenchmarks;

[SimpleJob(warmupCount: 2)]
[MemoryDiagnoser]
public class LinqActions
{
    [GlobalSetup]
    public void Setup()
    {
        var docs = Target.GenerateRandomData(500).ToArray();
        docs.Skip(100).Each(x => x.Color = Colors.Green);
        docs.Take(100).Each(x => x.Color = Colors.Blue);

        BenchmarkStore.Store.Advanced.Clean.DeleteDocumentsByType(typeof(Target));
        BenchmarkStore.Store.BulkInsert(docs);
    }

    [Benchmark]
    public void CreateLinqCommand()
    {
        using var session = BenchmarkStore.Store.QuerySession();
        var cmd = session.Query<Target>().Where(x => x.Flag && x.Color == Colors.Blue)
            .OrderBy(x => x.Date)
            .Skip(5).Take(10).ToCommand();
    }

    [Benchmark]
    public void RunLinqQuery()
    {
        using var query = BenchmarkStore.Store.QuerySession();
        var docs = query.Query<Target>().Where(x => x.Color == Colors.Green)
            .ToList();
    }

    [Benchmark]
    public void CompiledQueries()
    {
        using var query = BenchmarkStore.Store.QuerySession();
        var docs = query.Query(new BlueTargets());
    }
}

public class BlueTargets: ICompiledListQuery<Target>
{
    public Expression<Func<IMartenQueryable<Target>, IEnumerable<Target>>> QueryIs()
    {
        return x => x.Where(_ => _.Color == Colors.Blue);
    }
}
