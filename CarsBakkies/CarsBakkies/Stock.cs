/* Pieter Blignaut
   CSIS2664
   Project 2
   Scenario: Vehicle selling centre with Toyota and Ford cars and bakkies
   Pattern: Abstract factory
   Adapted to comply with SOLID
   September 2020     
 */

#define Array

using System;
using System.Collections.Generic;

class Stock
{
#if (List)
    private List<IVehicle> vehicles = new List<IVehicle>();
#else
    private IVehicle[] vehicles = new IVehicle[2];
    private int n = 0;
#endif

    public void AddVehicle(IVehicle vehicle)
    {
#if (List)
        vehicles.Add(vehicle);
#else
        if (n == vehicles.Length)
            Array.Resize(ref vehicles, vehicles.Length * 2);
        vehicles[n] = vehicle;
        n++;
#endif   
    } //AddVehicle

    public IEnumerable<IVehicle> ListStock()
    {
#if (List)
        foreach (IVehicle vehicle in vehicles)
            yield return vehicle;
#else
        for (int i = 0; i < n; i++)
            yield return vehicles[i];
#endif
    } //ListStock

} //class Stock