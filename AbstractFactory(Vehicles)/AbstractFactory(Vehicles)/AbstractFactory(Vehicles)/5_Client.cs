/*
 * Student Names: Motsamai Teboho
 * Student No: 2016206381
 * Role: work with any concrete factory, communicates with  objects via abstract interfaces
 * */
using System;
using System.Collections;
using System.Collections.Generic;


namespace AbstractFactory_Vehicles_
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Liskov Substition Principle (LSP) 
            IVehicleFactory ToyotaFactory = new ToyotaVehicleFactory();
            IVehicleFactory FordFactory = new FordVehicleFactory();

            Stock stock = new Stock();
            ICar ToyotaCar1 = ToyotaFactory.CreateCar("Yaris",2008,140000,true);
            stock.AddVehicle(ToyotaCar1);

            ICar ToyotaCar2 = ToyotaFactory.CreateCar("Vellfire", 2019, 580000, true);
            stock.AddVehicle(ToyotaCar2);

            ICar ToyotaCar3 = ToyotaFactory.CreateCar("Camry", 2017, 360000, false);
            stock.AddVehicle(ToyotaCar3);

            IBakkie ToyotaBakkie1 = ToyotaFactory.CreateBakkie("Hillux", 2020, 632400,200.42,true);
            stock.AddVehicle(ToyotaBakkie1);

            IBakkie ToyotaBakkie2 = ToyotaFactory.CreateBakkie("Hillux SD", 2015, 432400, 400.42, false);
            stock.AddVehicle(ToyotaBakkie2);

          
            ICar FordCar1 = FordFactory.CreateCar("Fiesta", 2020, 740000, true);
            stock.AddVehicle(FordCar1);

            ICar FordCar2 = FordFactory.CreateCar("Mustang", 2018, 530000, false);
            stock.AddVehicle(FordCar2);

            IBakkie FordBakkie1 = FordFactory.CreateBakkie("Ranger", 2014, 212400, 4006.42, true);
            stock.AddVehicle(FordBakkie1);

            IBakkie FordBakkie2= FordFactory.CreateBakkie("Ecosport", 2019, 672400, 3006.42, true);
            stock.AddVehicle(FordBakkie2);

            foreach (IVehicle vehicle in stock.ListStock())
            {
                if (vehicle is ICar)
                    Console.WriteLine(((ICar)vehicle).GetDetails());
                if (vehicle is IBakkie)
                    Console.WriteLine(((IBakkie)vehicle).GetDetails());

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
    class Stock
    {
        private List<IVehicle> lstVehicles;

        public Stock()
        {
            lstVehicles = new List<IVehicle>();
        }
        
        public void AddVehicle(IVehicle vehicle)
        {
            lstVehicles.Add(vehicle);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (IVehicle vehicle in lstVehicles)
            {
                yield return vehicle;
            }
            
        }
        public List<IVehicle> ListStock()
        {
            return lstVehicles;
        }
    }
    //The Dependency Inversion Principle(DIP)
}
