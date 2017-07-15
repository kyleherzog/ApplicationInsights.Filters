using System.Linq;
using ApplicationInsights.Filters.Abstractions;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters
{
    public class ExceptionMessageEndsWithFilter
        : ExceptionPatternsFilterBase
    {
        public ExceptionMessageEndsWithFilter(ITelemetryProcessor next) : base(next)
        {
        }

        protected override bool IsOkToSend(ExceptionTelemetry item)
        {
            var message = item.Exception.Message;
            return !Patterns.Any(p => message.EndsWith(p, Comparison));
        }
    }
}