using System;
using System.Collections.Generic;
using System.Text;

namespace СarShops.Entities
{
    public class Car
    {
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public GearBox GearBox { get; set; }
        public Fuel Fuel { get; set; }
        public double Volume { get; set; }
        public double Consumption { get; set; }
        public double PurchaseCost { get; set; }
        public double SellCost { get; set; }
    }
    public enum Brand { Audi, Porsche, McLaren, Ferrari, Mercedes, Lamborghini, Lotus, Koenigsegg, Nissan, BMW, Tesla }
    public enum GearBox { Automatic, Mechanic, SemiAutomatic}
    public enum Fuel { Petrol, Diesel, Electric}
}
