using ApplicationInsights.Filters.Abstractions;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters
{
    public class SyntheticSourceFilter
        : TelemetryFilterBase
    {
        public SyntheticSourceFilter(ITelemetryProcessor next) : base(next)
        {
        }

        protected override bool IsTelemetryOk(ITelemetry item)
        {
            return string.IsNullOrEmpty(item.Context.Operation.SyntheticSource);
        }
    }
}