using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class DependencyFilterBase
        : TelemetryFilterBase<DependencyTelemetry>
    {
        protected DependencyFilterBase(ITelemetryProcessor next) : base(next)
        {
        }
    }
}