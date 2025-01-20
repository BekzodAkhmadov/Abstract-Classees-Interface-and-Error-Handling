namespace AbstractClassInterfaceErrorHandling.ErrorHandling
{
    public class StudentNotFoundException : Exception
    {
        public string StudentName { get; }
        public StudentNotFoundException()
            : base() { }

        public StudentNotFoundException(string message)
            : base(message) { }

        public StudentNotFoundException(string message, Exception inner)
            : base(message, inner) { }

        public StudentNotFoundException(string message, string studentName)
            : this(message) { StudentName = studentName; }

    }
}
