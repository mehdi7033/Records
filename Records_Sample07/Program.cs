namespace Records_Sample07
{
    //A record can inherit from another record.
    //However, a record can't inherit from a class,
    //and a class can't inherit from a record.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public record Employee : Person
    {

    }
}
