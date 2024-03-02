namespace Records_Sample01
{
    //1- Equality
    //2- Built-in formatting for display
    //3- Value equality
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person()
            {
                FirstName = "mehdi",
                LastName = "ghadimi"
            };

            var p2 = new Person()
            {
                FirstName = "mehdi",
                LastName = "ghadimi"
            };

            var isEqual = p1.Equals(p2);


            Console.WriteLine(p1.ToString());
            Console.ReadLine();
        }
    }

    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}
