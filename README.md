# Application Insights Filters

[![Build status](https://ci.appveyor.com/api/projects/status/u780jr8bdo907bv0?svg=true)](https://ci.appveyor.com/project/kyleherzog/applicationinsights-filters)

--------------------------

Library that filters telemetry being sent to Application Insights, minimizing the data storage required and allowing you to focus on the telemetry that matters to you.

The various filters are enabled and configured by simply adding the appropriate entry into the ApplicationInsights.config file.

See the [changelog](CHANGELOG.md) for changes and roadmap.

## Dependency Filters

### Fast Dependency Filter
Filters out dependencies that execute faster than a given minimum number of milliseconds.

#### Properties
###### Threshold
The maximum number of milliseconds for the dependency call to be considered fast. The default is 100.

#### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.FastDependencyFilter, ApplicationInsights.Filters">
      <Threshold>150</Threshold>
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

## Exception Filters

### ExceptionMessageContainsFilter
Filters out exceptions that contain specific text.

#### Properties
######  PatternsDelimited
A comma delimited list of text to find within the exception message. 

###### IgnoreCase
A boolean value indicating whether to apply case sensitivity to pattern matching.  The default value is true.

##### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.ExceptionMessageContainsFilter, ApplicationInsights.Filters">
      <PatternsDelimited>not found,unknown source</PatternsDelimited>
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

### ExceptionMessageEndsWithFilter
Filters out exceptions that end with specific text.

#### Properties
######  PatternsDelimited
A comma delimited list of text options to find at the end of the exception message. 

###### IgnoreCase
A boolean value indicating whether to apply case sensitivity to pattern matching.

##### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.ExceptionMessageEndsWithFilter, ApplicationInsights.Filters">
      <PatternsDelimited>not found.,missing.</PatternsDelimited>
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

### ExceptionMessageStartsWithFilter
Filters out exceptions that start with specific text.

#### Properties
######  PatternsDelimited
A comma delimited list of text options to find at the begining of the exception message. 

###### IgnoreCase
A boolean value indicating whether to apply case sensitivity to pattern matching.

##### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.ExceptionMessageStartsWithFilter, ApplicationInsights.Filters">
      <PatternsDelimited>An exception,The controller</PatternsDelimited>
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

## Request Filters
### RequestPathContainsFilter
Filters out requests that have an absolute path that contains specific text.

#### Properties
######  PatternsDelimited
A comma delimited list of text to find within the request path. 

###### IgnoreCase
A boolean value indicating whether to apply case sensitivity to pattern matching.  The default value is true.

##### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.RequestPathContainsFilter, ApplicationInsights.Filters">
      <PatternsDelimited>images/,files/</PatternsDelimited>
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

### RequestPathEndsWithFilter
Filters out requests that have an absolute path that ends with specific text.

#### Properties
######  PatternsDelimited
A comma delimited list of text to match at the end of the absolute path. 

###### IgnoreCase
A boolean value indicating whether to apply case sensitivity to pattern matching.

##### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.RequestPathEndsWithFilter, ApplicationInsights.Filters">
      <PatternsDelimited>.jpg,.gif,.svg</PatternsDelimited>
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

### RequestPathStartsWithFilter
Filters out requests that have an absolute path that starts with matched text.

#### Properties
######  PatternsDelimited
A comma delimited list of text to matche at the begining of the absolute path. 

###### IgnoreCase
A boolean value indicating whether to apply case sensitivity to pattern matching.

##### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.RequestPathStartsWithFilter, ApplicationInsights.Filters">
      <PatternsDelimited>/files/,/images/</PatternsDelimited>
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

## Operation Filters
### SyntheticSourceFilter
Filters out any telemetry for with the operation has a synthetic source marked as true. (bot traffic)

##### ApplicationInsights.config Example
~~~ xml
<TelemetryProcessors>
    <Add Type="ApplicationInsights.Filters.SyntheticSourceFilter, ApplicationInsights.Filters">
    </Add>
</TelemetryProcessors>
~~~
&nbsp;

## License
[Apache 2.0](LICENSE)