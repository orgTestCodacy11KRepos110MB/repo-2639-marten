using System;
using Marten.Linq.QueryHandlers;

namespace Marten.Internal.CompiledQueries;

public abstract class CompiledQuerySource<TOut, TQuery>: ICompiledQuerySource
{
    public Type QueryType => typeof(TQuery);

    public IQueryHandler Build(object query, IMartenSession session)
    {
        return BuildHandler((TQuery)query, session);
    }

    public abstract IQueryHandler<TOut> BuildHandler(TQuery query, IMartenSession session);
}
