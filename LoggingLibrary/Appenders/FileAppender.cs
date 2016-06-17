namespace LoggingLibrary.Appenders
{
    using System;
    using Contracts;
    using Enums;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) : base(layout)
        {
            this.File = "defaultFileName.txt";
        }

        public string File { get; set; }

        public override void AppendMessage(ReportLevel reportLevel, string message)
        {
            var filePath =
                string.Format(
                    "D:\\SoftUni\\Courses\\fundamental-level\\High-Quality-Code\\Homeworks-And-Exercises\\15.SOLID-and-Other-Principles\\LoggingLibrary\\LoggingLibrary\\{0}", 
                    this.File);
            var fileMessage = this.Layout.DefineLayout(reportLevel, message);

            System.IO.File.AppendAllText(filePath, fileMessage + Environment.NewLine);
        }
    }
}
