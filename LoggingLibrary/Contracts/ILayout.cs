namespace LoggingLibrary.Contracts
{
    using Enums;

    public interface ILayout
    {
        string DefineLayout(ReportLevel reportLevel, string message);
    }
}