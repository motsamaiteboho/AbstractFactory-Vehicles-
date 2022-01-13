using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagrams
{
    public abstract class CVehicle : IVehicle
    {
        public  Manufacturers manufacturer { get; set; }
        public  string Model { get; set; }
        public  int Year { get; set; }
        public  decimal Price { get; set; }

        public CVehicle(Manufacturers manufacturer, string Model, int Year, decimal Price)
        {
            this.manufacturer = manufacturer;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
    }

    public class CCar : CVehicle, ICar
    {
        public bool HasSUV { get; set; }
        public CCar(Manufacturers manufacturer, string Model, int Year, decimal Price, bool hasSUV):base(manufacturer,Model,Year,Price)
        {
            this.HasSUV = hasSUV;
        }
    }

    public class CBakkie : CVehicle, IBakkie
    {
        public string Tannage { get; set; }
        public bool HasDoubleCab { get; set; }
        public CBakkie (Manufacturers manufacturer, string Model, int Year, decimal Price, bool hasDoubleCab, string Tonnage) : base(manufacturer, Model, Year, Price)
        {
            this.Tannage = Tannage;
            this.HasDoubleCab = HasDoubleCab;
        }
    }
}
