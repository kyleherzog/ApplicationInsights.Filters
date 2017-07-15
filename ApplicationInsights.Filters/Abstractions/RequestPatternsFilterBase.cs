using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class RequestPatternsFilterBase
        : TelemetryPatternsFilterBase<RequestTelemetry>
    {
        protected RequestPatternsFilterBase(ITelemetryProcessor next) : base(next)
        {
        }
    }
}