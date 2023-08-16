// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Execution;

/// <summary>
/// Represents the version of the software currently running.
/// </summary>
/// <param name="Version">The actual version string.</param>
/// <param name="Commit">The source code control commit identifier.</param>
public record SoftwareVersion(string Version, string Commit)
{
    /// <summary>
    /// Gets the not set version.
    /// </summary>
    public static SoftwareVersion Unspecified => new(string.Empty, string.Empty);
}