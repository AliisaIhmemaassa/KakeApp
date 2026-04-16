using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using static KakeForm.CargoChemical;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace KakeForm
{
    public class Cargo
    {
        protected List<string> Prompts = new List<string>() { "ID", "Description", "Weight", "Destination" };
        public string ID { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public string Destination { get; set; }
        public Cargo() { }
        public Cargo(string id, string description, double weight, string destination)
        {
            ID = id;
            Description = description;
            Weight = weight;
            Destination = destination;
        }
    }
    public class CargoNormal : Cargo, ICargo
    {
        public bool IsFragile { get; set; }
        public CargoNormal() { }
        public CargoNormal(string id, string description, double weight, string destination, bool fragile)
        : base(id, description, weight, destination)
        {
            IsFragile = fragile;
        }
        public void ConstructCargo(List<string> list)
        {
            Bank.CargoList.Add(list[0], new CargoNormal(list[0], list[1], double.Parse(list[2]), list[3], bool.Parse(list[4])));
        }
        public bool ValidateDestination(Truck.TruckType truck)
        {
            return (IsFragile && truck == Truck.TruckType.Fragile) ||
                   (!IsFragile && truck == Truck.TruckType.Normal);
        }
        public List<string> MakeCargo()
        {
            Prompts.Add("IsFragile");
            return new List<string>()
            {
                "Normal Cargo - ID: ",
                "Description: ",
                "Weight: ",
                "Destination: ",
                "Is Fragile? (true/false): "
            };
        }
        public override string ToString()
        {
            return $"{ID} (Type: Normal, Fragile: {IsFragile}, Destination: {Destination})";
        }
    }
    public class CargoThermal : Cargo, ICargo
    {
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        public CargoThermal() { }
        public CargoThermal(string id, string description, double weight, string destination, double maxtemp, double mintemp)
        : base(id, description, weight, destination)
        {
            MaxTemp = maxtemp;
            MinTemp = mintemp;
        }
        public void ConstructCargo(List<string> list)
        {
            Bank.CargoList.Add(list[0], new CargoThermal(list[0], list[1], double.Parse(list[2]), list[3], double.Parse(list[4]), double.Parse(list[5])));
        }
        public bool ValidateDestination(Truck.TruckType truck)
        {
            return truck == Truck.TruckType.Thermal;
        }
        public List<string> MakeCargo()
        {
            Prompts.Add("MaxTemp"); Prompts.Add("MinTemp");
            return new List<string>()
            {
                "Thermal Cargo - ID: ",
                "Description: ",
                "Weight: ",
                "Destination: ",
                "Min Temperature: ",
                "Max Temperature: "
            };
        }
        public override string ToString()
        {
            return $"{ID} (Type: Thermal, Destination: {Destination})";
        }
    }

    public class CargoLegal : Cargo
    {
        protected List<string> Prompts = new List<string>() { "ID", "Description", "Weight", "Destination", "LegalDocuments" };
        public string LegalDocuments { get; set; }
        public CargoLegal() { }
        public CargoLegal(string id, string description, double weight, string destination, string legaldoc)
        : base(id, description, weight, destination)
        {
            LegalDocuments = legaldoc;
        }
    }
    public class CargoChemical : CargoLegal, ICargo
    {
        public enum ChemicalClass
        {
            Harmless = 0,
            ExtraCare = 1,
            Hazard = 2,
            Exposive = 3,
        }
        public ChemicalClass HazardLevel { get; set; }
        public CargoChemical() { }
        public CargoChemical(string id, string description, double weight, string destination, string legaldoc, ChemicalClass hazlev)
        : base(id, description, weight, destination, legaldoc)
        {
            HazardLevel = hazlev;
        }
        public void ConstructCargo(List<string> list)
        {
            Bank.CargoList.Add(list[0], new CargoChemical(list[0], list[1], double.Parse(list[2]), list[3], list[4], Enum.Parse<ChemicalClass>(list[5])));
        }
        public bool ValidateDestination(Truck.TruckType truck)
        {
            return HazardLevel switch
            {
                ChemicalClass.Harmless => true,
                ChemicalClass.ExtraCare => truck != Truck.TruckType.Normal,
                ChemicalClass.Hazard => truck == Truck.TruckType.Hazard || truck == Truck.TruckType.Explosive,
                ChemicalClass.Exposive => truck == Truck.TruckType.Explosive,
                _ => false
            };
        }
        public List<string> MakeCargo()
        {
            Prompts.Add("HazardLevel");
            return new List<string>()
            {
                "Chemical Cargo - ID: ",
                "Description: ",
                "Weight: ",
                "Destination: ",
                "Legal Documents: ",
                "Hazard Level (Harmless/ExtraCare/Hazard/Explosive): "
            };
        }
        public override string ToString()
        {
            return $"{ID} (Type: Chemical, Hazard level: {HazardLevel}, Destination: {Destination})";
        }

    }
    public class CargoExplosive : CargoLegal, ICargo
    {
        public CargoExplosive() { }
        public CargoExplosive(string id, string description, double weight, string destination, string legaldoc)
        : base(id, description, weight, destination, legaldoc) { }
        public void ConstructCargo(List<string> list)
        {
            Bank.CargoList.Add(list[0], new CargoExplosive(list[0], list[1], double.Parse(list[2]), list[3], list[4]));
        }
        public bool ValidateDestination(Truck.TruckType truck)
        {
            return truck == Truck.TruckType.Explosive;
        }
        public List<string> MakeCargo()
        {
            return new List<string>()
            {
                "Explosive Cargo - ID: ",
                "Description: ",
                "Weight: ",
                "Destination: ",
                "Legal Documents: "
            };
        }
        public override string ToString()
        {
            return $"{ID} (Type: Explosive, Destination: {Destination})";
        }
    }
}