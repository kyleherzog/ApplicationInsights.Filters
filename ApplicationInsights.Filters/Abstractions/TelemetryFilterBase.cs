using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class TelemetryFilterBase
        : ITelemetryProcessor
    {
        protected TelemetryFilterBase(ITelemetryProcessor next)
        {
            Next = next;
        }

        protected ITelemetryProcessor Next { get; set; }

        public void Process(ITelemetry item)
        {
            if (IsTelemetryOk(item))
            {
                Next.Process(item);
            }
        }

        protected abstract bool IsTelemetryOk(ITelemetry item);
    }
}