namespace LoggingLibrary.Layouts
{
    using System.Globalization;
    using System.Threading;
    using System;
    using Contracts;
    using Enums;

    public abstract class Layout : ILayout
    {
        protected Layout()
        {
            this.CurrenDateTime = this.TransformDateTimeFormat();
        }

        protected DateTime CurrenDateTime { get; private set; }

        public abstract string DefineLayout(ReportLevel reportLevel, string message);

        private DateTime TransformDateTimeFormat()
        {
            var culture = "en-US";
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
            var currentDateTimeValue = DateTime.Now;

            return currentDateTimeValue;
        }
    }
}
