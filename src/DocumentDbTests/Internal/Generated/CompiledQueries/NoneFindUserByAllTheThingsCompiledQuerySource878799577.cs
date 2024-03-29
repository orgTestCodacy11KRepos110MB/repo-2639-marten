// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Reading.Linq.Compiled;
using Marten.Internal.CompiledQueries;
using Marten.Linq;
using Marten.Linq.QueryHandlers;
using System;

namespace Marten.Generated.CompiledQueries
{
    // START: NoneFindUserByAllTheThingsCompiledQuery878799577
    public class NoneFindUserByAllTheThingsCompiledQuery878799577 : Marten.Internal.CompiledQueries.ClonedCompiledQuery<Marten.Testing.Documents.User, DocumentDbTests.Reading.Linq.Compiled.FindUserByAllTheThings>
    {
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _inner;
        private readonly DocumentDbTests.Reading.Linq.Compiled.FindUserByAllTheThings _query;
        private readonly Marten.Linq.QueryStatistics _statistics;
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;

        public NoneFindUserByAllTheThingsCompiledQuery878799577(Marten.Linq.QueryHandlers.IMaybeStatefulHandler inner, DocumentDbTests.Reading.Linq.Compiled.FindUserByAllTheThings query, Marten.Linq.QueryStatistics statistics, Marten.Internal.CompiledQueries.HardCodedParameters hardcoded) : base(inner, query, statistics, hardcoded)
        {
            _inner = inner;
            _query = query;
            _statistics = statistics;
            _hardcoded = hardcoded;
        }



        public override void ConfigureCommand(Weasel.Postgresql.CommandBuilder builder, Marten.Internal.IMartenSession session)
        {
            var parameters = builder.AppendWithParameters(@"select d.id, d.data from public.mt_doc_user as d where ((d.data ->> 'FirstName' = ? and d.data ->> 'UserName' = ?) and  d.data ->> 'LastName' = ?) LIMIT ?");

            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            parameters[1].Value = _query.Username;

            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            parameters[0].Value = _query.FirstName;

            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            parameters[2].Value = _query.LastName;
            _hardcoded.Apply(parameters);
        }

    }

    // END: NoneFindUserByAllTheThingsCompiledQuery878799577
    
    
    // START: NoneFindUserByAllTheThingsCompiledQuerySource878799577
    public class NoneFindUserByAllTheThingsCompiledQuerySource878799577 : Marten.Internal.CompiledQueries.CompiledQuerySource<Marten.Testing.Documents.User, DocumentDbTests.Reading.Linq.Compiled.FindUserByAllTheThings>
    {
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _maybeStatefulHandler;

        public NoneFindUserByAllTheThingsCompiledQuerySource878799577(Marten.Internal.CompiledQueries.HardCodedParameters hardcoded, Marten.Linq.QueryHandlers.IMaybeStatefulHandler maybeStatefulHandler)
        {
            _hardcoded = hardcoded;
            _maybeStatefulHandler = maybeStatefulHandler;
        }



        public override Marten.Linq.QueryHandlers.IQueryHandler<Marten.Testing.Documents.User> BuildHandler(DocumentDbTests.Reading.Linq.Compiled.FindUserByAllTheThings query, Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.CompiledQueries.NoneFindUserByAllTheThingsCompiledQuery878799577(_maybeStatefulHandler, query, null, _hardcoded);
        }

    }

    // END: NoneFindUserByAllTheThingsCompiledQuerySource878799577
    
    
}

