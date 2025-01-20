namespace AbstractClassInterfaceErrorHandling.ErrorHandling
{
    public class BetterDevisionException : System.Exception
    {
        public BetterDevisionException() : base("Unable to divide by zero") { }
        public BetterDevisionException(string message) : base(message) { }
        public BetterDevisionException(string message, System.Exception inner) : base(message, inner) { }

        protected BetterDevisionException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public decimal? Dividend { get; set; }
        public decimal? Divisor { get; set; }
    }
}
