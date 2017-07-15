using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class ExceptionPatternsFilterBase
        : TelemetryPatternsFilterBase<ExceptionTelemetry>
    {
        protected ExceptionPatternsFilterBase(ITelemetryProcessor next) : base(next)
        {
        }
    }
}