namespace cSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Jins");
            person.Introduce("Rubin");
        }
    }
}
