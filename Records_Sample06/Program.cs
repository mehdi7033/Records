namespace Records_Sample06
{
    //required keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person()
            {
                FirstName = "mehdi",
                LastName = "ghadimi" 
            };


            Console.WriteLine("Hello, World!");
        }
    }

    public class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
