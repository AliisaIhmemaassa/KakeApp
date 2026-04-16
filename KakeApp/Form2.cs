using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }
    }
}
