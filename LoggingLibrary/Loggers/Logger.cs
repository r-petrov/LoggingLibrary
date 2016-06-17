namespace LoggingLibrary.Loggers
{
    using System;
    using Contracts;
    using Enums;

    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }

        public IAppender[] Appenders
        {
            get
            {
                return this.appenders;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Message appenders cannot be empty!");
                }

                this.appenders = value;
            }
        }

        public void Info(string message)
        {
            this.AppendMessages(ReportLevel.Info, message);
        }

        public void Warn(string message)
        {
            this.AppendMessages(ReportLevel.Warn, message);
        }

        public void Error(string message)
        {
            this.AppendMessages(ReportLevel.Error, message);
        }

        public void Critical(string message)
        {
            this.AppendMessages(ReportLevel.Critical, message);
        }

        public void Fatal(string message)
        {
            this.AppendMessages(ReportLevel.Fatal, message);
        }

        private void AppendMessages(ReportLevel reportLevel, string message)
        {
            var reportLevelValue = (int)reportLevel;
            foreach (var appender in this.Appenders)
            {
                var currentReportLevelValue = (int)appender.ReportLevel;
                if (currentReportLevelValue <= reportLevelValue)
                {
                    appender.AppendMessage(reportLevel, message);
                }
            }
        }
    }
}