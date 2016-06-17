namespace LoggingLibrary.Appenders
{
    using System;
    using Contracts;
    using Enums;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void AppendMessage(ReportLevel reportLevel, string message)
        {
            var consoleMessage = this.Layout.DefineLayout(reportLevel, message);

            Console.WriteLine(consoleMessage);
        }
    }
}