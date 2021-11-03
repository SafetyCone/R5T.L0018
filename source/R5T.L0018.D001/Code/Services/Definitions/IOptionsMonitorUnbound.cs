using System;

using Microsoft.Extensions.Options;

using R5T.T0064;


namespace R5T.L0018.D001
{
    [ServiceDefinitionMarker]
    [UnboundGenericServiceDefinitionMarker(typeof(IOptionsMonitor<>))]
    public interface IOptionsMonitorUnbound : IServiceDefinition, IUnboundGenericServiceDefinition
    {
    }
}
