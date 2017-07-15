using System;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsights.Filters.Abstractions
{
    public abstract class TelemetryPatternsFilterBase<T>
        : TelemetryFilterBase<T> where T : class, ITelemetry
    {
        protected TelemetryPatternsFilterBase(ITelemetryProcessor next) : base(next)
        {
        }

        private string _patternsDelimited;

        public string[] Patterns { get; set; }

        public bool IgnoreCase { get; set; } = true;

        protected StringComparison Comparison
        {
            get
            {
                return IgnoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            }
        }

        public string PatternsDelimited
        {
            get
            {
                return _patternsDelimited;
            }

            set
            {
                if (value != _patternsDelimited)
                {
                    _patternsDelimited = value;
                    if (!string.IsNullOrEmpty(_patternsDelimited))
                    {
                        Patterns = _patternsDelimited.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    }
                    else
                    {
                        Patterns = new string[] { };
                    }
                }
            }
        }
    }
}