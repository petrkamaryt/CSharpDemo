namespace CSharpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("Skoda");
            myCar.Color = "Black";
            myCar.IsInsured = true;
            //myCar.Manafacturer = "Skoda";
            myCar.Start();
            var car = (ICar)myCar;
            Console.WriteLine($"Manafacturer: {myCar.Manufacturer}");

            //var console = new Console();

            var myCarB = new Car("Volkswagen");
            Console.WriteLine($"{Car.CarCounter}");
            Car.DoSomethingElse();
        }
    }
}