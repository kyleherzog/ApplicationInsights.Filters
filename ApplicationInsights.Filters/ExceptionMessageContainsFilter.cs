using System.Linq;
using ApplicationInsights.Filters.Abstractions;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters
{
    public class ExceptionMessageContainsFilter
        : ExceptionPatternsFilterBase
    {
        public ExceptionMessageContainsFilter(ITelemetryProcessor next) : base(next)
        {
        }

        protected override bool IsOkToSend(ExceptionTelemetry item)
        {
            var message = item.Exception.Message;
            return !Patterns.Any(p => message.IndexOf(p, Comparison) >= 0);
        }
    }
}