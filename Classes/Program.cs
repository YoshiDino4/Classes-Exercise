namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Stang = new Car();
            Stang.Make = "Ford";
            Stang.Model = "Mustang";
            Stang.Year = 2014;
            
            Console.WriteLine($"Make of car: {Stang.Make} \nModel of car: {Stang.Model} \nYear of car: {Stang.Year}");
        }
    }
}
