using System.Linq;
using ApplicationInsights.Filters.Abstractions;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters
{
    public class ExceptionMessageStartsWithFilter
        : ExceptionPatternsFilterBase
    {
        public ExceptionMessageStartsWithFilter(ITelemetryProcessor next) : base(next)
        {
        }

        protected override bool IsOkToSend(ExceptionTelemetry item)
        {
            var message = item.Exception.Message;
            return !Patterns.Any(p => message.StartsWith(p, Comparison));
        }
    }
}