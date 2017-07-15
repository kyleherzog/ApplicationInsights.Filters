using ApplicationInsights.Filters.Abstractions;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters
{
    public class FastDependencyFilter
        : DependencyFilterBase
    {
        public FastDependencyFilter(ITelemetryProcessor next) : base(next)
        {
        }

        public int Threshold { get; set; } = 100;

        protected override bool IsOkToSend(DependencyTelemetry item)
        {
            return item.Duration.TotalMilliseconds > Threshold;
        }
    }
}