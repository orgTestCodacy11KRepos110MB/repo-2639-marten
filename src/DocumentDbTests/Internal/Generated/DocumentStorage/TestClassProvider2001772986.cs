// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Bugs;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertTestClassOperation2001772986
    public class UpsertTestClassOperation2001772986 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertTestClassOperation2001772986(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_bug_849_not_node_not_correctly_evaluated_testclass(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertTestClassOperation2001772986
    
    
    // START: InsertTestClassOperation2001772986
    public class InsertTestClassOperation2001772986 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertTestClassOperation2001772986(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_bug_849_not_node_not_correctly_evaluated_testclass(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertTestClassOperation2001772986
    
    
    // START: UpdateTestClassOperation2001772986
    public class UpdateTestClassOperation2001772986 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateTestClassOperation2001772986(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_bug_849_not_node_not_correctly_evaluated_testclass(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateTestClassOperation2001772986
    
    
    // START: QueryOnlyTestClassSelector2001772986
    public class QueryOnlyTestClassSelector2001772986 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyTestClassSelector2001772986(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass Resolve(System.Data.Common.DbDataReader reader)
        {

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyTestClassSelector2001772986
    
    
    // START: LightweightTestClassSelector2001772986
    public class LightweightTestClassSelector2001772986 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightTestClassSelector2001772986(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightTestClassSelector2001772986
    
    
    // START: IdentityMapTestClassSelector2001772986
    public class IdentityMapTestClassSelector2001772986 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapTestClassSelector2001772986(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapTestClassSelector2001772986
    
    
    // START: DirtyTrackingTestClassSelector2001772986
    public class DirtyTrackingTestClassSelector2001772986 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingTestClassSelector2001772986(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingTestClassSelector2001772986
    
    
    // START: QueryOnlyTestClassDocumentStorage2001772986
    public class QueryOnlyTestClassDocumentStorage2001772986 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyTestClassDocumentStorage2001772986(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyTestClassSelector2001772986(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyTestClassDocumentStorage2001772986
    
    
    // START: LightweightTestClassDocumentStorage2001772986
    public class LightweightTestClassDocumentStorage2001772986 : Marten.Internal.Storage.LightweightDocumentStorage<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightTestClassDocumentStorage2001772986(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightTestClassSelector2001772986(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightTestClassDocumentStorage2001772986
    
    
    // START: IdentityMapTestClassDocumentStorage2001772986
    public class IdentityMapTestClassDocumentStorage2001772986 : Marten.Internal.Storage.IdentityMapDocumentStorage<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapTestClassDocumentStorage2001772986(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapTestClassSelector2001772986(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapTestClassDocumentStorage2001772986
    
    
    // START: DirtyTrackingTestClassDocumentStorage2001772986
    public class DirtyTrackingTestClassDocumentStorage2001772986 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingTestClassDocumentStorage2001772986(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertTestClassOperation2001772986
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingTestClassSelector2001772986(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingTestClassDocumentStorage2001772986
    
    
    // START: TestClassBulkLoader2001772986
    public class TestClassBulkLoader2001772986 : Marten.Internal.CodeGeneration.BulkLoader<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid> _storage;

        public TestClassBulkLoader2001772986(Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_bug_849_not_node_not_correctly_evaluated_testclass(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_bug_849_not_node_not_correctly_evaluated_testclass (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp.\"id\", mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp.\"data\", mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp.\"mt_version\", mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp left join public.mt_doc_bug_849_not_node_not_correctly_evaluated_testclass on mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp.id = public.mt_doc_bug_849_not_node_not_correctly_evaluated_testclass.id where public.mt_doc_bug_849_not_node_not_correctly_evaluated_testclass.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_bug_849_not_node_not_correctly_evaluated_testclass target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_bug_849_not_node_not_correctly_evaluated_testclass_temp as select * from public.mt_doc_bug_849_not_node_not_correctly_evaluated_testclass limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: TestClassBulkLoader2001772986
    
    
    // START: TestClassProvider2001772986
    public class TestClassProvider2001772986 : Marten.Internal.Storage.DocumentProvider<DocumentDbTests.Bugs.Bug_849_not_node_not_correctly_evaluated.TestClass>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public TestClassProvider2001772986(Marten.Schema.DocumentMapping mapping) : base(new TestClassBulkLoader2001772986(new QueryOnlyTestClassDocumentStorage2001772986(mapping)), new QueryOnlyTestClassDocumentStorage2001772986(mapping), new LightweightTestClassDocumentStorage2001772986(mapping), new IdentityMapTestClassDocumentStorage2001772986(mapping), new DirtyTrackingTestClassDocumentStorage2001772986(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: TestClassProvider2001772986
    
    
}

