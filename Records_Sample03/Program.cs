namespace Records_Sample03
{
    //Shallow copy using `with` keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("mehdi", "ghadimi");

            var p2 = p1 with { FirstName = "Ali" };

            Console.WriteLine(p2.ToString());

            Console.ReadLine();
        }
    }

    public record Person(string FirstName, string LastName);
}
