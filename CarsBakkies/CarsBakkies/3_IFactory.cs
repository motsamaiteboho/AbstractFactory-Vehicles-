/* Pieter Blignaut
   CSIS2664
   Project 2
   Scenario: Vehicle selling centre with Toyota and Ford cars and bakkies
   Pattern: Abstract factory
   Adapted to comply with SOLID
   September 2020     
 */

enum Manufacturer
{
    Ford, Toyota
} //Manufacturer

interface IVehicleFactory
{
    Manufacturer manufacturer { get; }
    ICar CreateCar(string model, int year, decimal price, bool isSUV);
    IBakkie CreateBakkie(string model, int year, decimal price, double tonnage, bool hasDoubleCab);
} //ICarFactory
