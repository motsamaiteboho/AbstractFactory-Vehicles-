/*
 * Student Names: Motsamai Teboho
 * Student No: 2016206381
 * Role: declares interface a set of methods for creating each of the abstract products
 * */
namespace AbstractFactory_Vehicles_
{
    enum Manufacture
    {
        Toyota, Ford
    }
    interface IVehicleFactory
    {
        Manufacture manufacture { get; }
        ICar CreateCar(string Model, int Year, decimal Price, bool hasSUV);
        IBakkie CreateBakkie(string Model, int Year, decimal Price, double Tannage, bool hasDoubleCab);

    }
}
