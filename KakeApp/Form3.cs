using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace KakeApp
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
			cbTrkType.Items.AddRange(new object[] { "Normal", "Fragile", "Thermal", "Hazard", "Explosive" });
			cbTrkType.SelectedIndex = 0;
		}

		Manager m = new Manager();
		private void binTrkSave_Click(object sender, EventArgs e)
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

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnTrkCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tbTrkWeight_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Numbers + control keys only (backspace, delete, etc.)
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;  // Block input
		}
	}
}
