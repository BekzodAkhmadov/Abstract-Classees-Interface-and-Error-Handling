namespace AbstractClassInterfaceErrorHandling.Interface
{
    interface ILogger
    {
        void LogError(string error);
        int ErrorCount { get; }
    }
}
