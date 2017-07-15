using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class RequestFilterBase
        : TelemetryFilterBase<RequestTelemetry>
    {
        protected RequestFilterBase(ITelemetryProcessor next) : base(next)
        {
        }
    }
}