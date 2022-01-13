/* Pieter Blignaut
   CSIS2664
   Project 2
   Scenario: Vehicle selling centre with Toyota and Ford cars and bakkies
   Pattern: Abstract factory
   Adapted to comply with SOLID
   September 2020     
 */

using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        //Black text on white background
        BackgroundColor = System.ConsoleColor.White;
        ForegroundColor = System.ConsoleColor.Black;
        Clear();
        WriteLine();

        //Instantiate factories
        IVehicleFactory FordFactory = new FordFactory();
        IVehicleFactory ToyotaFactory = new ToyotaFactory();

        //Add stock
        Stock stock = new Stock();

        IVehicle car1 = ToyotaFactory.CreateCar("Corolla", 2019, 230000, false);
        stock.AddVehicle(car1);

        IVehicle car2 = ToyotaFactory.CreateCar("Corolla", 2018, 200000m, false);
        stock.AddVehicle(car2);

        IVehicle car3 = ToyotaFactory.CreateCar("Fortuner", 2020, 700000m, true);
        stock.AddVehicle(car3);

        IVehicle bakkie1 = ToyotaFactory.CreateBakkie("Hilux", 2016, 150000m, 1.5, false);
        stock.AddVehicle(bakkie1);

        IVehicle car4 = FordFactory.CreateCar("Figo", 2018, 150000m, false);
        stock.AddVehicle(car4);

        IVehicle bakkie2 = FordFactory.CreateBakkie("Ranger", 2018, 450000m, 2, true);
        stock.AddVehicle(bakkie2);

        //Show stock
        foreach (IVehicle vehicle in stock.ListStock())
            WriteLine(vehicle.GetDetails());

        ReadKey();
    } //Main

} //class Client



