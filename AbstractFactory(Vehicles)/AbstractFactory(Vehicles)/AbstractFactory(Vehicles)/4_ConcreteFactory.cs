/*
 * Student Names: Motsamai Teboho
 * Student No: 2016206381
 * Role: implement creation methods of the abstract factory.
 * */
namespace AbstractFactory_Vehicles_
{
    class ToyotaVehicleFactory : IVehicleFactory
    {
        public Manufacture manufacture  { get { return Manufacture.Toyota; } }

        public IBakkie CreateBakkie(string Model, int Year, decimal Price, double Tannage, bool hasDoubleCab)
        {
            return new ToyotaBakkie(Model, Year, Price,Tannage,hasDoubleCab);
        }


        public ICar CreateCar(string Model, int Year, decimal Price, bool hasSUV)
        {
            return new ToyotaCar(Model, Year, Price, hasSUV);
        }

    }

    class FordVehicleFactory : IVehicleFactory
    {
        public Manufacture manufacture { get { return Manufacture.Ford; } }


        public IBakkie CreateBakkie(string Model, int Year, decimal Price, double Tannage, bool hasDoubleCab)
        {
            return new FordBakkie(Model, Year, Price, Tannage, hasDoubleCab);
        }

        public ICar CreateCar(string Model, int Year, decimal Price, bool hasSUV)
        {
            return new FordCar(Model, Year, Price, hasSUV);
        }
    }
}
