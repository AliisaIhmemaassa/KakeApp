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
		public string CreateCargo(List<string> cargo)
		{
			string txt = "";

			switch (cargo[1])
			{
				case "CargoNormal":
					txt = new CargoNormal().ConstructCargo2(cargo);
					break;
				case "CargoThermal":
					txt = new CargoThermal().ConstructCargo2(cargo);
					break;
				case "CargoChemical":
					txt = new CargoChemical().ConstructCargo2(cargo);
					break;
				case "CargoExplosive":
					txt = new CargoExplosive().ConstructCargo2(cargo);
					break;
				default:
					txt = "";
					break;
			}
			return txt;
		}
	}
}
