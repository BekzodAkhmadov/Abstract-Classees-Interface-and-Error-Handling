namespace AbstractClassInterfaceErrorHandling.Interface
{
    class DisplayLogger : ILogger
    {
        private static int _ErrorCount = 0;
        public void LogError(string error)
        {
            Console.WriteLine("There was a error:" + error);
            _ErrorCount++;
        }
        public int ErrorCount { get { return _ErrorCount; } }

    }
}
