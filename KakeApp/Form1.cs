using KakeForm;
using System.Security.Cryptography;

namespace KakeApp
{
	public partial class Form1 : Form
	{
		Manager m =new Manager();
		public Form1()
		{
			InitializeComponent();
			PageMain();
			cmbLoad();
			Form1_Load();
			RefreshTrucks();
		}

		private void Form1_Load()
		{
			Bank b = new Bank();
			b.CargoIni();
			b.TruckIni();
			RefreshTrucks();
			IniRefreshCargo();
		}
		private void cmbLoad()
		{
			cbTrkType.Items.AddRange(new object[] { "Normal", "Fragile", "Thermal", "Hazard", "Explosive" });
			cbTrkType.SelectedIndex = 0;
			cbHazard.Items.AddRange(new object[] { "Harmless", "ExtraCare", "Hazard", "Exposive" });
			//cbHazard.SelectedIndex = 0;
			cbCarType.Items.AddRange(new object[] { "Normal", "Thermal", "Hazard", "Explosive" });
			cbCarType.SelectedIndex = 0;
		}

		private void PageMain()
		{
			panel1.Visible = true;
			panel2.Visible = false;
			panel3.Visible = false;
			panel1.BringToFront();
		}
		private void PageTruck()
		{
			panel1.Visible = false;
			panel2.Visible = true;
			panel3.Visible = false;
			panel2.BringToFront();
		}
		private void PageCargo()
		{
			panel1.Visible = false;
			panel2.Visible = false;
			panel3.Visible = true;
			panel3.BringToFront();
		}
		//
		//
		//
		private void btnAddTruck_Click(object sender, EventArgs e)
		{
			PageTruck();
		}

		private void btnModTruck_Click(object sender, EventArgs e)
		{
			MessageBox.Show("ModTruck Clicked");
		}

		private void btnRfsTruck_Click(object sender, EventArgs e)
		{
			RefreshTrucks();
		}

		private void btnAddCargo_Click(object sender, EventArgs e)
		{
			PageCargo();
			///
			string placholder_id = string.Empty;
			for (int i = 0; i < 2; i++) {
				int number = new Random().Next(100, 1000);
				placholder_id += number;
				placholder_id += "-";
			}
			placholder_id += new Random().Next(100, 1000);
			tbCarID.Text = placholder_id;
			///
        }

		private void btnModCargo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("ModCargo Clicked");
		}

		private void btnRfsCargo_Click(object sender, EventArgs e)
		{
			RefreshCargo();
		}
        //
        // Truck
        //
        private void btnTrkCancel_Click(object sender, EventArgs e)
        {
            clearAllBoxesTrk();
            PageMain();
        }
        private void btnTrkSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbTrkID.Text) ||
				string.IsNullOrWhiteSpace(tbTrkModel.Text) ||
				cbTrkType.SelectedIndex < 0 ||
				string.IsNullOrWhiteSpace(tbTrkWeight.Text))
			{
				MessageBox.Show("Fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string LicensePlate = tbTrkID.Text.Trim();
			string Model = tbTrkModel.Text.Trim();
			string TrkType = cbTrkType.SelectedItem.ToString();
			string MaxLoad = tbTrkWeight.Text;

			m.saveTrkstr(new Dictionary<string, string> { { "Lp", LicensePlate }, { "Md", Model }, { "Ty", TrkType }, { "Ml", MaxLoad } });
			clearAllBoxesTrk();
			RefreshTrucks();
			PageMain();
		}
		private void tbTrkWeight_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}
		private void clearAllBoxesTrk()
		{
			tbTrkID.Clear();
			tbTrkModel.Clear();
			tbTrkWeight.Clear();
			cbTrkType.SelectedIndex = 0;

		}
		//
		// Cargo
		//
		private void btnCarCancel_Click(object sender, EventArgs e)
		{
			clearAllBoxesCar();
			PageMain();
		}
		private void btnCarSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbCarID.Text))
			{
				MessageBox.Show("Enter Cargo ID!");
				return;
			}

			string Id = tbCarID.Text.Trim();

			List<string> fieldValues = GetFieldValues();
			ICargo cargo = cbCarType.SelectedItem.ToString() switch
			{
				"Normal" => new CargoNormal(),
				"Thermal" => new CargoThermal(),
				"Hazard" => new CargoChemical(),
				"Explosive" => new CargoExplosive(),
				_ => null
			};

			if (cargo == null)
			{
				MessageBox.Show("Save failed");
				return;
			}
			else
			{
				cargo.ConstructCargo(fieldValues);
				SaveLoad.SaveToJson(Bank.CargoString, "CargoString.json");
				clearAllBoxesCar();
				RefreshCargo();
				PageMain();
			}
		}
        public List<string> GetFieldValues()
        {
            var values = new List<string> { tbCarID.Text.Trim() };

			if (!string.IsNullOrWhiteSpace(tbMaterial.Text)) { values.Add(tbMaterial.Text.Trim()); }
            if (!string.IsNullOrWhiteSpace(tbWeight.Text)) { values.Add(tbWeight.Text.Trim()); }
            if (!string.IsNullOrWhiteSpace(tbDestination.Text)) { values.Add(tbDestination.Text.Trim()); }
            if (!string.IsNullOrWhiteSpace(tbMaxTemp.Text)) { values.Add(tbMaxTemp.Text.Trim()); }
            if (!string.IsNullOrWhiteSpace(tbMinTemp.Text)) { values.Add(tbMinTemp.Text.Trim()); }
            if (!string.IsNullOrWhiteSpace(tbLegal.Text)) { values.Add(tbLegal.Text.Trim()); }
            if (cbHazard.SelectedIndex != -1) { values.Add(cbHazard.Text.Trim()); }
			values.Add(chckBox.Checked.ToString().ToLower());

            return values;
        }
        private void cbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCarType.Controls.Clear();
            clearBoxesCar();

            switch (cbCarType.SelectedItem)
            {
                case "Normal":
                    tbLegal.Visible = false;
                    lbLegal.Visible = false;
                    cbHazard.Visible = false;
                    lbHazard.Visible = false;
                    tbMaxTemp.Visible = false;
                    lbMaxTemp.Visible = false;
                    tbMinTemp.Visible = false;
                    lbMinTemp.Visible = false;

                    tbMaterial.Visible = true;
                    lbMaterial.Visible = true;
                    tbWeight.Visible = true;
                    lbWeight.Visible = true;
                    tbDestination.Visible = true;
                    lbDestination.Visible = true;
                    chckBox.Visible = true;
                    lbFragile.Visible = true;

                    break;
                case "Thermal":
                    tbLegal.Visible = false;
                    lbLegal.Visible = false;
                    cbHazard.Visible = false;
                    lbHazard.Visible = false;
                    chckBox.Visible = false;
                    lbFragile.Visible = false;

                    tbMaterial.Visible = true;
                    lbMaterial.Visible = true;
                    tbWeight.Visible = true;
                    lbWeight.Visible = true;
                    tbDestination.Visible = true;
                    lbDestination.Visible = true;
                    tbMaxTemp.Visible = true;
                    lbMaxTemp.Visible = true;
                    tbMinTemp.Visible = true;
                    lbMinTemp.Visible = true;
                    break;
                case "Hazard":
                    tbMaxTemp.Visible = false;
                    lbMaxTemp.Visible = false;
                    tbMinTemp.Visible = false;
                    lbMinTemp.Visible = false;
                    chckBox.Visible = false;
                    lbFragile.Visible = false;

                    tbMaterial.Visible = true;
                    lbMaterial.Visible = true;
                    tbWeight.Visible = true;
                    lbWeight.Visible = true;
                    tbDestination.Visible = true;
                    lbDestination.Visible = true;
                    tbLegal.Visible = true;
                    lbLegal.Visible = true;
                    cbHazard.Visible = true;
                    lbHazard.Visible = true;
                    break;
                case "Explosive":
                    cbHazard.Visible = false;
                    lbHazard.Visible = false;
                    tbMaxTemp.Visible = false;
                    lbMaxTemp.Visible = false;
                    tbMinTemp.Visible = false;
                    lbMinTemp.Visible = false;
                    chckBox.Visible = false;
                    lbFragile.Visible = false;

                    tbMaterial.Visible = true;
                    lbMaterial.Visible = true;
                    tbWeight.Visible = true;
                    lbWeight.Visible = true;
                    tbDestination.Visible = true;
                    lbDestination.Visible = true;
                    tbLegal.Visible = true;
                    lbLegal.Visible = true;
                    break;
            }
        }
        private void tbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void tbMaxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void tbMinTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void clearAllBoxesCar()
        {
            tbCarID.Clear();
            cbCarType.SelectedIndex = 0;
            tbLegal.Clear();
            cbHazard.SelectedIndex = 0;
            tbMaxTemp.Clear();
            tbMinTemp.Clear();
            tbMaterial.Clear();
            tbWeight.Clear();
            tbDestination.Clear();
            chckBox.Checked = false;
        }
        private void clearBoxesCar()
        {
            tbLegal.Clear();
            cbHazard.SelectedIndex = 0;
            tbMaxTemp.Clear();
            tbMinTemp.Clear();
            chckBox.Checked = false;
			cbHazard.SelectedIndex = -1;
        }
        //
        //
        //
		private void RefreshTrucks() 
		{
			listBoxTruck.Items.Clear();
			foreach (var truck in Bank.TruckList.Values)
			{
				listBoxTruck.Items.Add(truck);
			}
		}
		private void RefreshCargo()
		{
			listBoxCargo.Items.Clear();
			foreach (var cargo in Bank.CargoList.Values)
			{
				listBoxCargo.Items.Add(cargo);
			}
		}
		private void IniRefreshCargo()
		{
			listBoxCargo.Items.Clear();
			foreach (var cargoBase in Bank.CargoString.Values)
			{
				Console.WriteLine(cargoBase[1]);
				string displayText = m.CreateCargo(cargoBase);
				listBoxCargo.Items.Add(displayText);
			}
		}
	}
}
