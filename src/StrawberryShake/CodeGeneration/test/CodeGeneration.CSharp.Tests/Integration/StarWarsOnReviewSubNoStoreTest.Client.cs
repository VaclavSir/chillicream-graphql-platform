﻿// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable RedundantNameQualifier
// ReSharper disable ArrangeObjectCreationWhenTypeEvident
// ReSharper disable UnusedType.Global
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedMethodReturnValue.Local
// ReSharper disable ConvertToAutoProperty
// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable InconsistentNaming

// StarWarsOnReviewSubNoStoreClient

// <auto-generated/>
#nullable enable annotations
#nullable disable warnings

namespace Microsoft.Extensions.DependencyInjection
{
    // StrawberryShake.CodeGeneration.CSharp.Generators.DependencyInjectionGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public static partial class StarWarsOnReviewSubNoStoreClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.StarWarsOnReviewSubNoStoreClientStoreAccessor> AddStarWarsOnReviewSubNoStoreClient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var serviceCollection = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp =>
            {
                ConfigureClientDefault(sp, serviceCollection, strategy);
                return new ClientServiceProvider(global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => new global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.StarWarsOnReviewSubNoStoreClientStoreAccessor());
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.OnReviewSubSubscription>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.StarWarsOnReviewSubNoStoreClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IStarWarsOnReviewSubNoStoreClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            return new global::StrawberryShake.ClientBuilder<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.StarWarsOnReviewSubNoStoreClientStoreAccessor>("StarWarsOnReviewSubNoStoreClient", services, serviceCollection);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(global::System.IServiceProvider parentServices, global::Microsoft.Extensions.DependencyInjection.ServiceCollection services, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Transport.WebSockets.IWebSocketConnection>(services, sp =>
            {
                var sessionPool = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.WebSockets.ISessionPool>(parentServices);
                return new global::StrawberryShake.Transport.WebSockets.WebSocketConnection(async ct => await sessionPool.CreateAsync("StarWarsOnReviewSubNoStoreClient", ct));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UUIDSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.JsonSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(services, sp => new global::StrawberryShake.Serialization.SerializerResolver(global::System.Linq.Enumerable.Concat(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(parentServices), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(sp))));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult>, global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.OnReviewSubResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubSubscription>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult>, global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.OnReviewSubBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult>>(services, sp => new global::StrawberryShake.StorelessOperationExecutor<global::System.Text.Json.JsonDocument, global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.WebSockets.IWebSocketConnection>(sp), () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult>>(sp), () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IResultPatcher<global::System.Text.Json.JsonDocument>>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IResultPatcher<global::System.Text.Json.JsonDocument>, global::StrawberryShake.Json.JsonResultPatcher>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.OnReviewSubSubscription>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubSubscription>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.OnReviewSubSubscription>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.StarWarsOnReviewSubNoStoreClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IStarWarsOnReviewSubNoStoreClient>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.StarWarsOnReviewSubNoStoreClient>(sp));
            return services;
        }

        private sealed class ClientServiceProvider : System.IServiceProvider, System.IDisposable
        {
            private readonly System.IServiceProvider _provider;
            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}

namespace StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore
{
    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnReviewSubResult : global::System.IEquatable<OnReviewSubResult>, IOnReviewSubResult
    {
        public OnReviewSubResult(global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSub_OnReview onReview)
        {
            OnReview = onReview;
        }

        public global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSub_OnReview OnReview { get; }

        public virtual global::System.Boolean Equals(OnReviewSubResult? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (OnReview.Equals(other.OnReview));
        }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((OnReviewSubResult)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * OnReview.GetHashCode();
                return hash;
            }
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnReviewSub_OnReview_Review : global::System.IEquatable<OnReviewSub_OnReview_Review>, IOnReviewSub_OnReview_Review
    {
        public OnReviewSub_OnReview_Review(global::System.String __typename, global::System.Int32 stars, global::System.String? commentary)
        {
            this.__typename = __typename;
            Stars = stars;
            Commentary = commentary;
        }

        /// <summary>
        /// The name of the current Object type at runtime.
        /// </summary>
        public global::System.String __typename { get; }

        public global::System.Int32 Stars { get; }

        public global::System.String? Commentary { get; }

        public virtual global::System.Boolean Equals(OnReviewSub_OnReview_Review? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (__typename.Equals(other.__typename)) && global::System.Object.Equals(Stars, other.Stars) && ((Commentary is null && other.Commentary is null) || Commentary != null && Commentary.Equals(other.Commentary));
        }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((OnReviewSub_OnReview_Review)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * __typename.GetHashCode();
                hash ^= 397 * Stars.GetHashCode();
                if (Commentary != null)
                {
                    hash ^= 397 * Commentary.GetHashCode();
                }

                return hash;
            }
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IOnReviewSubResult
    {
        public global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSub_OnReview OnReview { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IOnReviewSub_OnReview
    {
        /// <summary>
        /// The name of the current Object type at runtime.
        /// </summary>
        public global::System.String __typename { get; }

        public global::System.Int32 Stars { get; }

        public global::System.String? Commentary { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IOnReviewSub_OnReview_Review : IOnReviewSub_OnReview
    {
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationDocumentGenerator
    /// <summary>
    /// Represents the operation service of the OnReviewSub GraphQL operation
    /// <code>
    /// subscription OnReviewSub {
    ///   onReview(episode: NEW_HOPE) {
    ///     __typename
    ///     stars
    ///     commentary
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnReviewSubSubscriptionDocument : global::StrawberryShake.IDocument
    {
        private OnReviewSubSubscriptionDocument()
        {
        }

        public static OnReviewSubSubscriptionDocument Instance { get; } = new OnReviewSubSubscriptionDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Subscription;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x73, 0x75, 0x62, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x4f, 0x6e, 0x52, 0x65, 0x76, 0x69, 0x65, 0x77, 0x53, 0x75, 0x62, 0x20, 0x7b, 0x20, 0x6f, 0x6e, 0x52, 0x65, 0x76, 0x69, 0x65, 0x77, 0x28, 0x65, 0x70, 0x69, 0x73, 0x6f, 0x64, 0x65, 0x3a, 0x20, 0x4e, 0x45, 0x57, 0x5f, 0x48, 0x4f, 0x50, 0x45, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x73, 0x74, 0x61, 0x72, 0x73, 0x20, 0x63, 0x6f, 0x6d, 0x6d, 0x65, 0x6e, 0x74, 0x61, 0x72, 0x79, 0x20, 0x7d, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "92220fce37342d7ade3d63a2a81342eb1fb14bac");
        public override global::System.String ToString()
        {
#if NETCOREAPP3_1_OR_GREATER
        return global::System.Text.Encoding.UTF8.GetString(Body);
#else
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
#endif
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceGenerator
    /// <summary>
    /// Represents the operation service of the OnReviewSub GraphQL operation
    /// <code>
    /// subscription OnReviewSub {
    ///   onReview(episode: NEW_HOPE) {
    ///     __typename
    ///     stars
    ///     commentary
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnReviewSubSubscription : global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubSubscription
    {
        private readonly global::StrawberryShake.IOperationExecutor<IOnReviewSubResult> _operationExecutor;
        public OnReviewSubSubscription(global::StrawberryShake.IOperationExecutor<IOnReviewSubResult> operationExecutor)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IOnReviewSubResult);
        public global::System.IObservable<global::StrawberryShake.IOperationResult<IOnReviewSubResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {
            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: OnReviewSubSubscriptionDocument.Instance.Hash.Value, name: "OnReviewSub", document: OnReviewSubSubscriptionDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceInterfaceGenerator
    /// <summary>
    /// Represents the operation service of the OnReviewSub GraphQL operation
    /// <code>
    /// subscription OnReviewSub {
    ///   onReview(episode: NEW_HOPE) {
    ///     __typename
    ///     stars
    ///     commentary
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IOnReviewSubSubscription : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.IObservable<global::StrawberryShake.IOperationResult<IOnReviewSubResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ClientGenerator
    /// <summary>
    /// Represents the StarWarsOnReviewSubNoStoreClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class StarWarsOnReviewSubNoStoreClient : global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IStarWarsOnReviewSubNoStoreClient
    {
        private readonly global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubSubscription _onReviewSub;
        public StarWarsOnReviewSubNoStoreClient(global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubSubscription onReviewSub)
        {
            _onReviewSub = onReviewSub ?? throw new global::System.ArgumentNullException(nameof(onReviewSub));
        }

        public static global::System.String ClientName => "StarWarsOnReviewSubNoStoreClient";
        public global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubSubscription OnReviewSub => _onReviewSub;
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ClientInterfaceGenerator
    /// <summary>
    /// Represents the StarWarsOnReviewSubNoStoreClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IStarWarsOnReviewSubNoStoreClient
    {
        global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubSubscription OnReviewSub { get; }
    }
}

namespace StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State
{
    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultDataFactoryGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnReviewSubResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.OnReviewSubResult>
    {
        public OnReviewSubResultFactory()
        {
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult);
        public OnReviewSubResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (dataInfo is OnReviewSubResultInfo info)
            {
                return new OnReviewSubResult(MapNonNullableIOnReviewSub_OnReview(info.OnReview));
            }

            throw new global::System.ArgumentException("OnReviewSubResultInfo expected.");
        }

        private global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSub_OnReview MapNonNullableIOnReviewSub_OnReview(global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.ReviewData data)
        {
            IOnReviewSub_OnReview returnValue = default !;
            if (data.__typename.Equals("Review", global::System.StringComparison.Ordinal))
            {
                returnValue = new OnReviewSub_OnReview_Review(data.__typename ?? throw new global::System.ArgumentNullException(), data.Stars ?? throw new global::System.ArgumentNullException(), data.Commentary);
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInfoGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnReviewSubResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        public OnReviewSubResultInfo(global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.ReviewData onReview)
        {
            OnReview = onReview;
        }

        public global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.ReviewData OnReview { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => global::System.Array.Empty<global::StrawberryShake.EntityId>();
        public global::System.UInt64 Version => 0;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new OnReviewSubResultInfo(OnReview);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.JsonResultBuilderGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnReviewSubBuilder : global::StrawberryShake.OperationResultBuilder<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult>
    {
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        public OnReviewSubBuilder(global::StrawberryShake.IOperationResultDataFactory<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult> resultDataFactory, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            ResultDataFactory = resultDataFactory ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String") ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int") ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
        }

        protected override global::StrawberryShake.IOperationResultDataFactory<global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.IOnReviewSubResult> ResultDataFactory { get; }

        protected override global::StrawberryShake.IOperationResultDataInfo BuildData(global::System.Text.Json.JsonElement obj)
        {
            return new OnReviewSubResultInfo(Deserialize_NonNullableIOnReviewSub_OnReview(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "onReview")));
        }

        private global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.ReviewData Deserialize_NonNullableIOnReviewSub_OnReview(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            if (obj.Value.ValueKind == global::System.Text.Json.JsonValueKind.Null)
            {
                throw new global::System.ArgumentNullException();
            }

            var typename = obj.Value.GetProperty("__typename").GetString();
            if (typename?.Equals("Review", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::StrawberryShake.CodeGeneration.CSharp.Integration.StarWarsOnReviewSubNoStore.State.ReviewData(typename, stars: Deserialize_NonNullableInt32(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "stars")), commentary: Deserialize_String(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "commentary")));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String Deserialize_NonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            if (obj.Value.ValueKind == global::System.Text.Json.JsonValueKind.Null)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Int32 Deserialize_NonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            if (obj.Value.ValueKind == global::System.Text.Json.JsonValueKind.Null)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.String? Deserialize_String(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            if (obj.Value.ValueKind == global::System.Text.Json.JsonValueKind.Null)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.DataTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "0.0.0.0")]
    public partial class ReviewData
    {
        public ReviewData(global::System.String __typename, global::System.Int32? stars = default !, global::System.String? commentary = default !)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Stars = stars;
            Commentary = commentary;
        }

        public global::System.String __typename { get; }

        public global::System.Int32? Stars { get; }

        public global::System.String? Commentary { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.NoStoreAccessorGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class StarWarsOnReviewSubNoStoreClientStoreAccessor : global::StrawberryShake.IStoreAccessor
    {
        public global::StrawberryShake.IOperationStore OperationStore => throw new global::System.NotSupportedException("OperationStore is not supported in store less mode");
        public global::StrawberryShake.IEntityStore EntityStore => throw new global::System.NotSupportedException("EntityStore is not supported in store less mode");
        public global::StrawberryShake.IEntityIdSerializer EntityIdSerializer => throw new global::System.NotSupportedException("EntityIdSerializer is not supported in store less mode");
        public global::StrawberryShake.IOperationRequestFactory GetOperationRequestFactory(global::System.Type resultType)
        {
            throw new global::System.NotSupportedException("GetOperationRequestFactory is not supported in store less mode");
        }

        public global::StrawberryShake.IOperationResultDataFactory GetOperationResultDataFactory(global::System.Type resultType)
        {
            throw new global::System.NotSupportedException("GetOperationResultDataFactory is not supported in store less mode");
        }
    }
}


