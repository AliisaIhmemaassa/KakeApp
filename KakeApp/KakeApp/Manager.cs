using System;
using System.Collections.Generic;
using System.Text;
using KakeForm;

namespace KakeApp
{
    internal class Manager
    {
        public void saveTrkstr(Dictionary<string, string> Trk)
        {
            Bank.TruckList.Add( Trk["Lp"], new Truck(Trk["Lp"], Trk["Md"], Enum.Parse<Truck.TruckType>(Trk["Ty"]), double.Parse(Trk["Ml"])));
            SaveLoad.SaveToJson(Bank.TruckList, "TruckList.json");
        }
        public void MkCar(Dictionary<string, string> Car)
        {
            
            
			ICargo cargo = Car["Ty"] switch
			{
				"Normal" => new CargoNormal(),
				"Thermal" => new CargoThermal(),
				"Hazard" => new CargoChemical(),
				"Explosive" => new CargoExplosive(),
				_ => null
			};

            //cargo.ConstructCargo();
		}
    }
}
