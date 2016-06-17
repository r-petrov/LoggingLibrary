namespace LoggingLibrary.Layouts
{
    using Enums;

    public class XmlLayout : Layout
    {
        public override string DefineLayout(ReportLevel reportLevel, string message)
        {
            var layout = string.Format(
                "<log>\n\t<date>{0}</date>\n\t<level>{1}</level>\n\t<message>{2}</message>\n</log>",
                this.CurrenDateTime, 
                reportLevel, 
                message);

            return layout;
        }
    }
}