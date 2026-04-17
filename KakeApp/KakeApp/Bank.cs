using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KakeForm
{
	public class Bank
	{
		private static Dictionary<string, Cargo> _cargoList = new();
		private static Dictionary<string, List<string>> _cargoString = new();
		private static Dictionary<string, Truck> _truckList = new();

		public static Dictionary<string, Cargo> CargoList => _cargoList;
		public static Dictionary<string, List<string>> CargoString => _cargoString;
		public static Dictionary<string, Truck> TruckList => _truckList;

		//public void CargoIni()
		//{
		//	var data = SaveLoad.LoadFromJson<Dictionary<string, Cargo>>("CargoList.json");
		//	_cargoList = data ?? new Dictionary<string, Cargo>();
		//}
		public void CargoIni()
		{
			var data = SaveLoad.LoadFromJson<Dictionary<string, List<string>>>("CargoList.json");
			_cargoString = data ?? new Dictionary<string, List<string>>();
		}

		public void TruckIni()
		{
			var data = SaveLoad.LoadFromJson<Dictionary<string, Truck>>("TruckList.json");
			_truckList = data ?? new Dictionary<string, Truck>();
		}
	}
}