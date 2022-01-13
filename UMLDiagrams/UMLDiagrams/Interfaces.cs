using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagrams
{
    public enum Manufacturers
    {
        Ford, Toyota
    }
    interface IVehicle
    {
         Manufacturers manufacturer { get; set; }
         string Model { get; set; }
         int Year { get; set; }
         decimal Price { get; set; }
    }

    interface ICar: IVehicle
    {
        bool HasSUV { get; set; }
    }
    interface IBakkie: IVehicle
    {
        string Tannage { get; set; }
        bool HasDoubleCab { get; set; }
    }

}

