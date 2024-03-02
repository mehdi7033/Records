namespace Records_Sample05
{
    //init keyword
    internal class Program
    {
        static void Main(string[] args)
        {

            var p1 = new Person()
            {
                FirstName = "mehdi",
                LastName = "ghadimi"
            };

            var p2 = new Person();
            

            Console.WriteLine(p1.ToString());

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    class PersonPrivateSet
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public PersonPrivateSet(string first, string last) => (FirstName, LastName) = (first, last);

        public void ChangeName(string first, string last) => (FirstName, LastName) = (first, last);
    }

    class PersonReadOnly
    {
        public string FirstName { get; }
        public string LastName { get; }
        public PersonReadOnly(string first, string last) => (FirstName, LastName) = (first, last);
    }

    class PersonInit
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}
