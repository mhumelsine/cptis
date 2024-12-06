namespace cptis.infrastructure.Services
{
    public interface ILogger
    {
        void Debug(string message, Exception ex = null);
        void Trace(string message, Exception ex = null);
        void Info(string message, Exception ex = null);
        void Error(string message, Exception ex = null);
        void Fatal(string message, Exception ex = null);
        void Warning(string message, Exception ex = null);
    }

    public class LoggerManager : ILogger
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        protected virtual NLog.LogEventInfo GetLogEvent(NLog.LogLevel level, Exception ex = null, string message = null)
        {
            var info = new NLog.LogEventInfo
            {
                Message = message,
                Level = level,
                LoggerName = "SYSTEM",
                Exception = ex
            };

            string source = null,
                className = null,
                method = null,
                exceptionType = null,
                exceptionMessage = null,
                stacktrace = null,
                innerExceptionMessage = null;

            if (ex != null)
            {

                source = ex.Source;
                className = ex.TargetSite?.DeclaringType?.FullName;
                method = ex.TargetSite?.Name;
                exceptionType = ex.GetType().FullName;
                exceptionMessage = ex.Message;
                stacktrace = ex.StackTrace;
                innerExceptionMessage = this.GetInnerException(ex);
            }

            info.Properties.Add("User", "SYSTEM"); // TODO: get user from context
            info.Properties.Add("Process", "CPTIS");
            info.Properties.Add("Source", source);
            info.Properties.Add("ClassName", className);
            info.Properties.Add("Method", method);
            info.Properties.Add("ExceptionType", exceptionType);
            info.Properties.Add("ExceptionMessage", exceptionMessage);
            info.Properties.Add("Stacktrace", stacktrace);
            info.Properties.Add("InnerException", innerExceptionMessage);

            return info;
        }

        private string GetInnerException(Exception ex)
        {
            if (ex.InnerException != null)
            {
                return this.GetInnerException(ex.InnerException);
            }

            return ex.Message;
        }

        public virtual void Debug(string message, Exception ex = null)
        {
            logger.Log(this.GetLogEvent(NLog.LogLevel.Debug, ex, message));
        }

        public virtual void Trace(string message, Exception ex = null)
        {
            logger.Log(this.GetLogEvent(NLog.LogLevel.Trace, ex, message));
        }

        public virtual void Info(string message, Exception ex = null)
        {
            logger.Log(this.GetLogEvent(NLog.LogLevel.Info, ex, message));
        }

        public virtual void Error(string message, Exception ex = null)
        {
            logger.Log(this.GetLogEvent(NLog.LogLevel.Error, ex, message));
        }

        public virtual void Fatal(string message, Exception ex = null)
        {
            logger.Log(this.GetLogEvent(NLog.LogLevel.Fatal, ex, message));
        }

        public void Warning(string message, Exception ex = null)
        {
            logger.Log(this.GetLogEvent(NLog.LogLevel.Warn, ex, message));
        }
    }
}
