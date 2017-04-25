# ServiceStack.Logging.Serilog.Core
Provides Serilog logging adapter for ServiceStack Core.

### Release notes
This is a cumulation of two other projects that brought Serilog to ServiceStack plus improvments. This version is built on .NETStandard 1.6. 

Acknowledgements to https://github.com/alexeyzimarev/ServiceStack.Extras.Serilog & https://github.com/nickvane/ServiceStack.Logging.Serilog

### Usage

```csharp
var logger = new LoggerConfiguration()
    .WriteTo.LiterateConsole()
    .MinimumLevel.Debug()
    .CreateLogger();

LogManager.LogFactory = new SerilogFactory(logger);
```

Use the global Log.Logger instance.

```csharp
Log.Manager.LogFactory = new SerilogFactory();
```

Use Serilog's ForContext with destructuring operator.

```csharp
private readonly ILog _logAppHostContext;

_logAppHostContext = new SerilogFactory(logger).GetLogger(typeof(AppHost));

var testObj = new TestObj
{
    Prop1 = "test",
    Prop2 = -99
};

_logAppHostContext.DebugFormat("Hi! {@testObj}", testObj);
```

```text
Output:
09:42:06.474 |  1 | Hi! TestObj {Prop1="test", Prop2=-99}   (TwApi.CoreServicesHost.AppHost)
```

```text
Output template:
"{Timestamp:HH:mm:ss.fff} | {ThreadId,2} | {Message}   ({SourceContext}){NewLine}{Exception}"
```
