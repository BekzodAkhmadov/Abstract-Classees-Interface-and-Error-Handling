namespace AbstractClassInterfaceErrorHandling.Interface
{
    class DbLoggercs : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine("Error logged to database");
        }
        public int ErrorCount { get { return 0; } }

    }
}
