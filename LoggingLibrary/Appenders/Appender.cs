namespace LoggingLibrary.Appenders
{
    using System;
    using Contracts;
    using Enums;

    public abstract class Appender : IAppender
    {
        private ILayout layout;

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Default;
        }

        public ReportLevel ReportLevel { get; set; }

        protected ILayout Layout
        {
            get
            {
                return this.layout; 
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Message layout cannot be empty!");
                }

                this.layout = value;
            }
        }

        public abstract void AppendMessage(ReportLevel reportLevel, string message);
    }
}
