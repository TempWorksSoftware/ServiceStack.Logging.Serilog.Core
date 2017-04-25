[![NuGet](https://img.shields.io/nuget/v/Nuget.Core.svg)](https://www.nuget.org/packages/ServiceStack.Logging.Serilog.Core)

# ServiceStack.Logging.Serilog.Core
Provides Serilog logging adapter for ServiceStack Core.

### Release notes
This is a .NETStandard 1.6 version of the ServiceStack.Logging.Serilog lib. 
https://github.com/ServiceStack/ServiceStack/tree/master/src/ServiceStack.Logging.Serilog

### Usage

```csharp
LogManager.LogFactory = new SerilogFactory();
```

Use Serilog's destructuring operator and ForContext.

```csharp
public static ILog Log = LogManager.GetLogger(typeof(TestServices));

var testObj = new TestObj
{
    Prop1 = "test",
    Prop2 = -99,
	Prop3 = null
};

Log.DebugFormat("Hi! {@testObj}", testObj);

Log.ForContext<TestObj>().DebugFormat("Hi! {@testObj}", testObj);
```

```
Logging output:

15:37:06.398 |  3 | Hi! TestObj {Prop1="test", Prop2=-99, Prop3=null}   (ServiceInterface.TestServices)
15:37:06.401 |  3 | Hi! TestObj {Prop1="test", Prop2=-99, Prop3=null}   (ServiceInterface.TestServices+TestObj)
```

###### Serilog output template (if you're curious):
```
"{Timestamp:HH:mm:ss.fff} | {ThreadId,2} | {Message}   ({SourceContext}){NewLine}{Exception}"
```
