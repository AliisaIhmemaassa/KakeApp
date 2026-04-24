using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KakeForm;

namespace KakeApp
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			cbCarType.Items.AddRange(new object[] { "Normal", "Thermal", "Hazard", "Explosive" });
			cbCarType.SelectedIndex = 0;
			cbHazard.Items.AddRange(new object[] { "Harmless", "ExtraCare", "Hazard", "Exposive" });
		}

		Manager m = new Manager();
		private void cbCarType_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbCarType.Controls.Clear();

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

		private void btnCarCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void binCarSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbCarID.Text))
			{
				MessageBox.Show("Enter Cargo ID!");
				return;
			}

			string Id = tbCarID.Text.Trim();

			// Get ALL field values as List<string>
			List<string> fieldValues = GetFieldValues();
			ICargo cargo = cbHazard.SelectedItem.ToString() switch
			{
				"Normal" => new CargoNormal(),
				"Thermal" => new CargoThermal(),
				"Hazard" => new CargoChemical(),
				"Explosive" => new CargoExplosive(),
				_ => null
			};

			cargo.ConstructCargo(fieldValues);


			foreach (string value in fieldValues)
			{
				Console.WriteLine(value);  // Prints each value on new line
			}


		}

		public List<string> GetFieldValues()
		{
			var values = new List<string> { tbCarID.Text.Trim() };

			// TextBoxes
			values.AddRange(
				pCarQ.Controls
				.OfType<TextBox>()
				.Select(tb => tb.Text.Trim())
				.Where(text => !string.IsNullOrEmpty(text))
			);

			// CheckBoxes - convert bool to string
			values.AddRange(
				pCarQ.Controls
				.OfType<CheckBox>()
				.Select(chk => chk.Checked.ToString().ToLower())
			);

			values.AddRange(
				pCarQ.Controls
				.OfType<ComboBox>()
				.Select(cmb => cmb.SelectedItem?.ToString() ?? "")
				.Where(text => !string.IsNullOrEmpty(text))
			);

			return values;
		}

		private void pCarQ_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tbMaterial_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
