namespace LoggingLibrary
{
    using Appenders;
    using Enums;
    using Layouts;
    using Loggers;

    class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Warn;

            var fileAppender = new FileAppender(simpleLayout);
            fileAppender.File = "log.txt";
            fileAppender.ReportLevel = ReportLevel.Warn;

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");

            var xmlLayout = new XmlLayout();
            consoleAppender = new ConsoleAppender(xmlLayout);
            logger = new Logger(consoleAppender);

            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");

        }
    }
}
