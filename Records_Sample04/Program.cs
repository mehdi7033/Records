namespace Records_Sample04
{
    //Deconstructor
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("mehdi", "ghadimi");

            (var firstName, var lastName) = p1;

            Console.WriteLine(firstName);

            Console.ReadLine();
        }
    }

    public record Person(string FirstName, string LastName);
}
