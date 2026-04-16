using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KakeForm
{
    public class Truck
    {
        public enum TruckType
        {
            Normal = 0,
            Fragile = 1,
            Thermal = 2,
            Hazard = 3,
            Explosive = 4
        }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public TruckType Type { get; set; }
        public string DriverName { get; set; }
        public double MaxLoadKg { get; set; }
        public List<Cargo> TruckCargo { get; set; }

        public Truck(string model, string licensePlate, TruckType type, double maxLoadKg)
        {
            Model = model;
            LicensePlate = licensePlate;
            Type = type;
            MaxLoadKg = maxLoadKg;
            TruckCargo = new List<Cargo>();
        }
        public override string ToString()
        {
            return $"{Model} [{LicensePlate}], Driver: {DriverName}, Max Load: {MaxLoadKg}kg, ";
        }
        public string getCargo()
        {
            string CargoList = "";
            TruckCargo.Sort();
            foreach (Cargo carg in TruckCargo)
            {
                CargoList = CargoList + carg.ToString();
            }
            return CargoList;
        }
    }
}
