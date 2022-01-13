/*
 * Student Names: Motsamai Teboho
 * Student No: 2016206381
 * Role: implement the abstract products, grouped by variants(Toyota/Ford).
 * */
namespace AbstractFactory_Vehicles_
{
    class ToyotaCar : ICar
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public bool hasSUV { get; set; }

        public ToyotaCar(string Model, int Year, decimal Price, bool hasSUV)
        {
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.hasSUV = hasSUV;
        }

        public string GetDetails()
        {
            string s = "Type         : Car\n"
                     + "Model        : " + Model + "\n"
                     + "Year         : " + Year + "\n"
                     + "Price        : " + Price.ToString("C") + "\n"
                     + "SOV          : " + hasSUV;
            return s;
        }
       
    }

    class FordCar: ICar
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public bool hasSUV { get; set; }
        public FordCar(string Model, int Year, decimal Price, bool hasSUV)
        {
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.hasSUV = hasSUV;
        }

        public string GetDetails()
        {
            string s = "Type         : Car\n"
                     + "Model        : " + Model + "\n"
                     + "Year         : " + Year + "\n"
                     + "Price        : " + Price.ToString("C") + "\n"
                     + "SOV          : " + hasSUV;
            return s;
        }
    }

    class ToyotaBakkie : IBakkie
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public double Tannage { get ; set; }
        public bool hasDoubleCab { get; set; }
        public ToyotaBakkie(string Model, int Year, decimal Price, double Tannage, bool hasDoubleCab)
        {
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.hasDoubleCab = hasDoubleCab;
        }

        public string GetDetails()
        {
            string s = "Type         : Bakkie\n"
                     + "Model        : " + Model + "\n"
                     + "Year         : " + Year + "\n"
                     + "Price        : " + Price.ToString("C") + "\n"
                     + "Double Cab   : " + hasDoubleCab;
            return s;
        }
      
    }
    class FordBakkie: IBakkie
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public double Tannage { get; set; }
        public bool hasDoubleCab { get; set; }
        public FordBakkie (string Model, int Year, decimal Price, double Tannage, bool hasDoubleCab)
        {
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.hasDoubleCab = hasDoubleCab;
        }

        public string GetDetails()
        {
            string s = "Type         : Bakkie\n"
                     + "Model        : " + Model + "\n"
                     + "Year         : " + Year + "\n"
                     + "Price        : " + Price.ToString("C") + "\n"
                     + "Double Cab   : " + hasDoubleCab;
            return s;
        }
    }
}
