/* Pieter Blignaut
   CSIS2664
   Project 2
   Scenario: Vehicle selling centre with Toyota and Ford cars and bakkies
   Pattern: Abstract factory
   Adapted to comply with SOLID
   September 2020     
 */

//Use DRY - don't repeat fields in the bakkies and car classes.
//ISP: Don't include properties of cars and bakkies in the same interface.

interface IVehicle 
{
    Manufacturer manufacturer { get; }
    string model { get; }
    int year { get; }
    decimal price { get; }
    string GetDetails();
} //IVehicle

interface ICar : IVehicle
{
    bool isSUV { get; }
} //ICar

interface IBakkie : IVehicle
{
    double tonnage { get; set; }
    bool hasDoubleCab { get; set; }
} //IBakkie
