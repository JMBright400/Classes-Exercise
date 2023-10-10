namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var automobile = new Car();
            automobile.Make = "Pontiac";
            automobile.Model = "GTO Judge";
            automobile.Year = "1969";

            Console.WriteLine($"The {automobile.Year} {automobile.Model} was the best muscle car {automobile.Make} ever made.");
        }
    }
}
