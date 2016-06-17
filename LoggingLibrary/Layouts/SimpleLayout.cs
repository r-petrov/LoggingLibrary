namespace LoggingLibrary.Layouts
{
    using Enums;

    public class SimpleLayout : Layout
    {
        public override string DefineLayout(ReportLevel reportLevel, string message)
        {
            var layout = string.Format("{0} {1} {2}", this.CurrenDateTime.ToString(), reportLevel, message);

            return layout;
        }
    }
}
