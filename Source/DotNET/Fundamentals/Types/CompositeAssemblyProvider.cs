// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;

namespace Aksio.Types;

/// <summary>
/// Represents an implementation of <see cref="ICanProvideAssembliesForDiscovery"/> that provides a composite of multiple <see cref="ICanProvideAssembliesForDiscovery"/>.
/// </summary>
public class CompositeAssemblyProvider : ICanProvideAssembliesForDiscovery
{
    readonly List<ICanProvideAssembliesForDiscovery> _providers = new();

    /// <inheritdoc/>
    public IEnumerable<Assembly> Assemblies => _providers.SelectMany(_ => _.Assemblies);

    /// <inheritdoc/>
    public IEnumerable<Type> DefinedTypes => _providers.SelectMany(_ => _.DefinedTypes);

    /// <summary>
    /// Initializes a new instance of <see cref="CompositeAssemblyProvider"/>.
    /// </summary>
    /// <param name="providers">Providers to use.</param>
    public CompositeAssemblyProvider(params ICanProvideAssembliesForDiscovery[] providers)
    {
        _providers.AddRange(providers);
    }

    /// <inheritdoc/>
    public void Initialize()
    {
        _providers.ForEach(_ => _.Initialize());
    }
}
