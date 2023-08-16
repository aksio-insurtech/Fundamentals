// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Execution.for_ExecutionContextManager;

public class when_establishing_new_context_without_microservice_and_software_version_specified : Specification
{
    ExecutionContextManager manager;
    MicroserviceId microservice_id;
    TenantId tenant_id;
    CorrelationId correlation_id;
    SoftwareVersion version;

    public when_establishing_new_context_without_microservice_and_software_version_specified()
    {
        // Since the specification runner is using IAsyncLifetime - it will be in a different async context.
        // Use default behavior, since we need to have control over the async context.
        manager = new();
        microservice_id = Guid.NewGuid();
        tenant_id = Guid.NewGuid();
        correlation_id = Guid.NewGuid().ToString();
        version = new("Some Version", "Sha254523");

        ExecutionContextManager.SetGlobalMicroserviceId(microservice_id);
        ExecutionContextManager.SetGlobalSoftwareVersion(version);

        manager.Establish(tenant_id, correlation_id);
    }

    [Fact] void should_have_the_current_context_with_microservice_id() => manager.Current.MicroserviceId.ShouldEqual(microservice_id);
    [Fact] void should_have_the_current_context_with_tenant_id() => manager.Current.TenantId.ShouldEqual(tenant_id);
    [Fact] void should_have_the_current_context_with_correlation_id() => manager.Current.CorrelationId.ShouldEqual(correlation_id);
    [Fact] void should_have_the_current_context_with_version() => manager.Current.Version.ShouldEqual(version);
}
