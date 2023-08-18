// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Execution;

/// <summary>
/// Represents the current context of execution.
/// </summary>
/// <param name="MicroserviceId">The <see cref="MicroserviceId"/>.</param>
/// <param name="TenantId">The <see cref="TenantId"/>.</param>
/// <param name="CorrelationId">The <see cref="CorrelationId"/>.</param>
/// <param name="IsInKernel">Whether or not we're running inside the kernel. Defaults to false.</param>
public record ExecutionContext(
    MicroserviceId MicroserviceId,
    TenantId TenantId,
    CorrelationId CorrelationId,
    bool IsInKernel = false);
