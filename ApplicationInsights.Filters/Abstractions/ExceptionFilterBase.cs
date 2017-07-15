using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class ExceptionFilterBase
        : TelemetryFilterBase<ExceptionTelemetry>
    {
        protected ExceptionFilterBase(ITelemetryProcessor next) : base(next)
        {
        }
    }
}