using System;
using Serilog;
using Serilog.Events;

namespace ServiceStack.Logging.Serilog
{
    /// <summary>
    /// Wrapper over the Serilog
    /// </summary>
    public class SerilogLogger : ILog
    {
        private readonly ILogger _serilog;

        public SerilogLogger(ILogger serilogLogger)
        {
            _serilog = serilogLogger ?? throw new ArgumentNullException(nameof(serilogLogger));
        }

        public bool IsDebugEnabled => _serilog.IsEnabled(LogEventLevel.Debug); 
        public bool IsInfoEnabled  => _serilog.IsEnabled(LogEventLevel.Information);
        public bool IsWarnEnabled  => _serilog.IsEnabled(LogEventLevel.Warning);
        public bool IsErrorEnabled => _serilog.IsEnabled(LogEventLevel.Error);
        public bool IsFatalEnabled => _serilog.IsEnabled(LogEventLevel.Fatal);

        public void Debug(object message)
        {
            _serilog.Debug(Convert.ToString(message));
        }

        public void Debug(object message, Exception exception)
        {
            _serilog.Debug(exception, Convert.ToString(message));
        }

        public void DebugFormat(string format, params object[] args)
        {
            _serilog.Debug(format, args);
        }

        public void Error(object message)
        {
            _serilog.Error(Convert.ToString(message));
        }

        public void Error(object message, Exception exception)
        {
            _serilog.Error(exception, Convert.ToString(message));
        }

        public void ErrorFormat(string format, params object[] args)
        {
            _serilog.Error(format, args);
        }

        public void Fatal(object message)
        {
            _serilog.Fatal(Convert.ToString(message));
        }

        public void Fatal(object message, Exception exception)
        {
            _serilog.Fatal(exception, Convert.ToString(message));
        }

        public void FatalFormat(string format, params object[] args)
        {
            _serilog.Fatal(format, args);
        }

        public void Info(object message)
        {
            _serilog.Information(Convert.ToString(message));
        }

        public void Info(object message, Exception exception)
        {
            _serilog.Information(exception, Convert.ToString(message));
        }

        public void InfoFormat(string format, params object[] args)
        {
            _serilog.Information(format, args);
        }

        public void Warn(object message)
        {
            _serilog.Warning(Convert.ToString(message));
        }

        public void Warn(object message, Exception exception)
        {
            _serilog.Warning(exception, Convert.ToString(message));
        }

        public void WarnFormat(string format, params object[] args)
        {
            _serilog.Warning(format, args);
        }
    }
}