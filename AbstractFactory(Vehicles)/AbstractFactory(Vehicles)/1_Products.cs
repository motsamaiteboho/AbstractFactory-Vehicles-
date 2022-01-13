/*
 * Student Names: Motsamai Teboho
 * Student No: 2016206381
 * Role:declare interfaces for related products which make up a product family
 * */
namespace AbstractFactory_Vehicles_
{
    interface IVehicle
    {
        string Model { get; set; }
        int Year { get; set; }
        decimal Price { get; set; }
    }

    interface ICar : IVehicle
    {
        bool hasSUV { get; set; }
        string GetDetails();
    }
    interface IBakkie : IVehicle
    {
        double Tannage { get; set; }
        bool hasDoubleCab { get; set; }
        string GetDetails();
    }
}//The Interface Segregation Principle (ISP)
