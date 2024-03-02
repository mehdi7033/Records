namespace Records_Sample08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("mehdi", "ghadimi");
            p1.Phones = new List<string>()
            {
                "0912344343"
            };

            p1.Phones.Add("093784554");

            Console.WriteLine(p1.ToString()) ;
        }
    }

    public record Person(string FirstName, string LastName)
    {
        public List<string> Phones { get; set; }
    }
}
