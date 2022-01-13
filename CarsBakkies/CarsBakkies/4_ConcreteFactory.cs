/* Pieter Blignaut
   CSIS2664
   Project 2
   Scenario: Vehicle selling centre with Toyota and Ford cars and bakkies
   Pattern: Abstract factory
   Adapted to comply with SOLID
   September 2020     
 */

class ToyotaFactory : IVehicleFactory
{
    public Manufacturer manufacturer
    {
        get { return Manufacturer.Toyota; }
    } //manufacturer

    public IBakkie CreateBakkie(string model, int year, decimal price, double Tonnage, bool hasDoubleCab)
    {
        return new ToyotaBakkie(model, year, price, Tonnage, hasDoubleCab);
    } //CreateBakkie

    public ICar CreateCar(string model, int year, decimal price, bool isSUV)
    {
        return new ToyotaCar(model, year, price, isSUV);
    } //CreateCar

} //ToyotaFactory

class FordFactory : IVehicleFactory
{
    public Manufacturer manufacturer
    {
        get { return Manufacturer.Ford; }
    } //manufacturer

    public IBakkie CreateBakkie(string model, int year, decimal price, double Tonnage, bool hasDoubleCab)
    {
        return new FordBakkie(model, year, price, Tonnage, hasDoubleCab);
    } //CreateBakkie

    public ICar CreateCar(string model, int year, decimal price, bool isSUV)
    {
        return new FordCar(model, year, price, isSUV);
    } //CreateCar

} //FordFactory
