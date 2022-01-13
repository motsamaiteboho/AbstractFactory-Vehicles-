/* Pieter Blignaut
   CSIS2664
   Project 2
   Scenario: Vehicle selling centre with Toyota and Ford cars and bakkies
   Pattern: Abstract factory
   Adapted to comply with SOLID
   September 2020     
 */

/* Matrix
 
 Concrete        |    Interface
 Product class   |  ICar  IBakkie
 ----------------|-----------------
 Toyota car      |   X 
 Toyota bakkie   |            X
 Ford car        |   X
 Ford bakkie     |            X
*/

abstract class AVehicle : IVehicle  //DRY
{
    public Manufacturer manufacturer { get; set; }
    public string model { get; set; }
    public int year { get; set; }
    public decimal price { get; set; }

    public AVehicle(string model_, int year_, decimal price_)
    {
        model = model_;
        year = year_;
        price = price_;
    } //Vehicle constructor

    //public abstract string GetDetails();

    public virtual string GetDetails()
    {
        return "\tManufacturer : " + manufacturer + "\n"
               + "\tModel        : " + model + "\n"
               + "\tYear         : " + year + "\n"
               + "\tPrice        : " + price.ToString("C") + "\n";
    } //GetDetails

} //abstract class Vehicle

abstract class ABakkie : AVehicle, IBakkie
{
    public double tonnage { get; set; }
    public bool hasDoubleCab { get; set; }

    public ABakkie(string model_, int year_, decimal price_, double tonnage_, bool hasDoubleCab_)
    : base(model_, year_, price_)
    {
        tonnage = tonnage_;
        hasDoubleCab = hasDoubleCab_;
    } //Constructor

    public override string GetDetails()
    {
        return base.GetDetails()
               + "\tTonnage      : " + tonnage + "\n"
               + "\tDouble cab   : " + hasDoubleCab + "\n";
    } //GetDetails
} //Bakkie

abstract class ACar : AVehicle, ICar
{
    public bool isSUV { get; }

    public ACar (string model_, int year_, decimal price_, bool isSUV_)
        : base(model_, year_, price_)
    {
        manufacturer = Manufacturer.Toyota;
        isSUV = isSUV_;
    } //Constructor

    public override string GetDetails()
    {
        return base.GetDetails() 
               + "\tSUV          : " + isSUV + "\n";
    } //GetDetails
} //Car

class ToyotaBakkie : ABakkie
{
    public ToyotaBakkie(string model_, int year_, decimal price_, double tonnage_, bool hasDoubleCab_)
        : base(model_, year_, price_, tonnage_, hasDoubleCab_)
    {
        manufacturer = Manufacturer.Toyota;
    }
} //class Bakkie

class ToyotaCar : ACar
{
    public ToyotaCar(string model_, int year_, decimal price_, bool isSUV_)
        : base(model_, year_, price_, isSUV_)
    {
        manufacturer = Manufacturer.Toyota;
    } //Constructor
} //class Car

class FordBakkie : ABakkie
{    
    public FordBakkie(string model_, int year_, decimal price_, double tonnage_, bool hasDoubleCab_)
        : base(model_, year_, price_, tonnage_, hasDoubleCab_)
    {
        manufacturer = Manufacturer.Ford;
    } //Constructor
} //class FordBakkie

class FordCar : ACar
{
    public FordCar(string model_, int year_, decimal price_, bool isSUV_)
        : base(model_, year_, price_, isSUV_)
    {
        manufacturer = Manufacturer.Ford;
    } //Constructor
} //class FordCar