// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Reflection;

/// <summary>
/// Defines information for types.
/// </summary>
public interface ITypeInfo
{
    /// <summary>
    /// Gets a value indicating whether or not the type has a default constructor that takes no arguments.
    /// </summary>
    bool HasDefaultConstructor { get; }
}
