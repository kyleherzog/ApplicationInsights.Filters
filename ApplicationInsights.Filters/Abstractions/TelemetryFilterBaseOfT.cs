using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class TelemetryFilterBase<T>
        : TelemetryFilterBase where T : class, ITelemetry
    {
        protected TelemetryFilterBase(ITelemetryProcessor next) : base(next)
        {
        }

        protected override bool IsTelemetryOk(ITelemetry item)
        {
            var t = item as T;
            if (t != null)
            {
                return IsOkToSend(t);
            }

            return true;
        }

        protected abstract bool IsOkToSend(T item);
    }
}