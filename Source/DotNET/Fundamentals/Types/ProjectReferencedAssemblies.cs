// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;
using Microsoft.Extensions.DependencyModel;

namespace Aksio.Types;

/// <summary>
/// Represents an implementation of <see cref="ICanProvideAssembliesForDiscovery"/> that provides project referenced assemblies.
/// </summary>
public class ProjectReferencedAssemblies : ICanProvideAssembliesForDiscovery
{
    /// <summary>
    /// Gets the instance of <see cref="PackageReferencedAssemblies"/>.
    /// </summary>
    /// <remarks>
    /// Its recommended to use the singleton defined here, rather than building your own instance.
    /// This is due to the performance impact of scanning all assemblies in the application.
    /// </remarks>
    public static readonly ICanProvideAssembliesForDiscovery Instance = new ProjectReferencedAssemblies();

    readonly List<Assembly> _assemblies = new();

    /// <summary>
    /// Initializes a new instance of <see cref="ProjectReferencedAssemblies"/>.
    /// </summary>
    public ProjectReferencedAssemblies()
    {
        var entryAssembly = Assembly.GetEntryAssembly();
        var dependencyModel = DependencyContext.Load(entryAssembly);
        var projectReferencedAssemblies = dependencyModel.RuntimeLibraries
                            .Where(_ => _.Type.Equals("project"))
                            .Select(_ => AssemblyHelpers.Resolve(_.Name)!)
                            .Where(_ => _ is not null)
                            .Distinct()
                            .ToArray();
        _assemblies.AddRange(projectReferencedAssemblies);
    }

    /// <inheritdoc/>
    public IEnumerable<Assembly> Assemblies => _assemblies;
}
