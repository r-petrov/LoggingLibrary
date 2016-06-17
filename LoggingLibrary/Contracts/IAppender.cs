namespace LoggingLibrary.Contracts
{
    using Enums;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        void AppendMessage(ReportLevel reportLevel, string message);
    }
}