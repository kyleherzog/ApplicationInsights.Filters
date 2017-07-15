using System.Linq;
using ApplicationInsights.Filters.Abstractions;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters
{
    public class RequestPathContainsFilter
        : RequestPatternsFilterBase
    {
        public RequestPathContainsFilter(ITelemetryProcessor next) : base(next)
        {
        }

        protected override bool IsOkToSend(RequestTelemetry request)
        {
            var path = request.Url.AbsolutePath;
            return !Patterns.Any(p => path.IndexOf(p, Comparison) >= 0);
        }
    }
}