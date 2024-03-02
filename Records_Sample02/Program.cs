namespace Records_Sample02
{
    //Positional Parameters
    //Immutability
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("mehdi", "ghadimi");

            //p1.FirstName = "Ali";

            Console.WriteLine(p1.ToString());
        }
    }

    public record Person(string FirstName, string LastName);
}
