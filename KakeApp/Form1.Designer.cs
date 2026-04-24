namespace KakeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnAddCargo = new Button();
			tabControl1 = new TabControl();
			tabPage2 = new TabPage();
			btnRfsTruck = new Button();
			btnModTruck = new Button();
			btnAddTruck = new Button();
			listBoxTruck = new ListBox();
			tabPage1 = new TabPage();
			btnRfsCargo = new Button();
			btnModCargo = new Button();
			listBoxCargo = new ListBox();
			panel3 = new Panel();
			btnCarCancel = new Button();
			btnCarSave = new Button();
			cbCarType = new ComboBox();
			tbCarID = new TextBox();
			pCarQ = new Panel();
			cbHazard = new ComboBox();
			lbHazard = new Label();
			lbLegal = new Label();
			tbLegal = new TextBox();
			lbMaxTemp = new Label();
			lbMinTemp = new Label();
			tbMaxTemp = new TextBox();
			tbMinTemp = new TextBox();
			lbFragile = new Label();
			lbDestination = new Label();
			lbWeight = new Label();
			lbMaterial = new Label();
			chckBox = new CheckBox();
			tbDestination = new TextBox();
			tbMaterial = new TextBox();
			tbWeight = new TextBox();
			panel1 = new Panel();
			panel2 = new Panel();
			btnTrkCancel = new Button();
			btnTrkSave = new Button();
			lbKg = new Label();
			lbTrkType = new Label();
			lbTrkWeight = new Label();
			lbTrkModel = new Label();
			lbTrkID = new Label();
			cbTrkType = new ComboBox();
			tbTrkWeight = new TextBox();
			tbTrkModel = new TextBox();
			tbTrkID = new TextBox();
			tabControl1.SuspendLayout();
			tabPage2.SuspendLayout();
			tabPage1.SuspendLayout();
			panel3.SuspendLayout();
			pCarQ.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// btnAddCargo
			// 
			btnAddCargo.Location = new Point(423, 53);
			btnAddCargo.Margin = new Padding(3, 4, 3, 4);
			btnAddCargo.Name = "btnAddCargo";
			btnAddCargo.Size = new Size(114, 60);
			btnAddCargo.TabIndex = 1;
			btnAddCargo.Text = "Ass Cargo";
			btnAddCargo.UseVisualStyleBackColor = true;
			btnAddCargo.Click += btnAddCargo_Click;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Margin = new Padding(3, 4, 3, 4);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(914, 600);
			tabControl1.TabIndex = 4;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(btnRfsTruck);
			tabPage2.Controls.Add(btnModTruck);
			tabPage2.Controls.Add(btnAddTruck);
			tabPage2.Controls.Add(listBoxTruck);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Margin = new Padding(3, 4, 3, 4);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3, 4, 3, 4);
			tabPage2.Size = new Size(906, 567);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Trucks";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnRfsTruck
			// 
			btnRfsTruck.Font = new Font("Segoe UI", 20F);
			btnRfsTruck.Location = new Point(423, 213);
			btnRfsTruck.Margin = new Padding(3, 4, 3, 4);
			btnRfsTruck.Name = "btnRfsTruck";
			btnRfsTruck.Size = new Size(114, 60);
			btnRfsTruck.TabIndex = 6;
			btnRfsTruck.Text = "🔄️";
			btnRfsTruck.UseVisualStyleBackColor = true;
			btnRfsTruck.Click += btnRfsTruck_Click;
			// 
			// btnModTruck
			// 
			btnModTruck.Location = new Point(423, 133);
			btnModTruck.Margin = new Padding(3, 4, 3, 4);
			btnModTruck.Name = "btnModTruck";
			btnModTruck.Size = new Size(114, 60);
			btnModTruck.TabIndex = 5;
			btnModTruck.Text = "Modify Trucks";
			btnModTruck.UseVisualStyleBackColor = true;
			btnModTruck.Click += btnModTruck_Click;
			// 
			// btnAddTruck
			// 
			btnAddTruck.Location = new Point(423, 53);
			btnAddTruck.Margin = new Padding(3, 4, 3, 4);
			btnAddTruck.Name = "btnAddTruck";
			btnAddTruck.Size = new Size(114, 60);
			btnAddTruck.TabIndex = 4;
			btnAddTruck.Text = "Add Trucks";
			btnAddTruck.UseVisualStyleBackColor = true;
			btnAddTruck.Click += btnAddTruck_Click;
			// 
			// listBoxTruck
			// 
			listBoxTruck.FormattingEnabled = true;
			listBoxTruck.Location = new Point(7, 13);
			listBoxTruck.Margin = new Padding(3, 4, 3, 4);
			listBoxTruck.Name = "listBoxTruck";
			listBoxTruck.Size = new Size(382, 504);
			listBoxTruck.TabIndex = 3;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(btnRfsCargo);
			tabPage1.Controls.Add(btnModCargo);
			tabPage1.Controls.Add(listBoxCargo);
			tabPage1.Controls.Add(btnAddCargo);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Margin = new Padding(3, 4, 3, 4);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3, 4, 3, 4);
			tabPage1.Size = new Size(906, 567);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Cargo";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnRfsCargo
			// 
			btnRfsCargo.Font = new Font("Segoe UI", 20F);
			btnRfsCargo.Location = new Point(423, 213);
			btnRfsCargo.Margin = new Padding(3, 4, 3, 4);
			btnRfsCargo.Name = "btnRfsCargo";
			btnRfsCargo.Size = new Size(114, 60);
			btnRfsCargo.TabIndex = 3;
			btnRfsCargo.Text = "🔄️";
			btnRfsCargo.UseVisualStyleBackColor = true;
			btnRfsCargo.Click += btnRfsCargo_Click;
			// 
			// btnModCargo
			// 
			btnModCargo.Location = new Point(423, 133);
			btnModCargo.Margin = new Padding(3, 4, 3, 4);
			btnModCargo.Name = "btnModCargo";
			btnModCargo.Size = new Size(114, 60);
			btnModCargo.TabIndex = 2;
			btnModCargo.Text = "Modify Cargo";
			btnModCargo.UseVisualStyleBackColor = true;
			btnModCargo.Click += btnModCargo_Click;
			// 
			// listBoxCargo
			// 
			listBoxCargo.FormattingEnabled = true;
			listBoxCargo.Location = new Point(7, 13);
			listBoxCargo.Margin = new Padding(3, 4, 3, 4);
			listBoxCargo.Name = "listBoxCargo";
			listBoxCargo.Size = new Size(382, 504);
			listBoxCargo.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(btnCarCancel);
			panel3.Controls.Add(btnCarSave);
			panel3.Controls.Add(cbCarType);
			panel3.Controls.Add(tbCarID);
			panel3.Controls.Add(pCarQ);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 0);
			panel3.Margin = new Padding(3, 4, 3, 4);
			panel3.Name = "panel3";
			panel3.Size = new Size(914, 600);
			panel3.TabIndex = 0;
			// 
			// btnCarCancel
			// 
			btnCarCancel.Font = new Font("Segoe UI", 12F);
			btnCarCancel.Location = new Point(503, 520);
			btnCarCancel.Margin = new Padding(3, 4, 3, 4);
			btnCarCancel.Name = "btnCarCancel";
			btnCarCancel.Size = new Size(114, 53);
			btnCarCancel.TabIndex = 4;
			btnCarCancel.Text = "Cancel";
			btnCarCancel.UseVisualStyleBackColor = true;
			btnCarCancel.Click += btnCarCancel_Click;
			// 
			// btnCarSave
			// 
			btnCarSave.Font = new Font("Segoe UI", 12F);
			btnCarSave.Location = new Point(297, 520);
			btnCarSave.Margin = new Padding(3, 4, 3, 4);
			btnCarSave.Name = "btnCarSave";
			btnCarSave.Size = new Size(114, 53);
			btnCarSave.TabIndex = 3;
			btnCarSave.Text = "Save";
			btnCarSave.UseVisualStyleBackColor = true;
			btnCarSave.Click += btnCarSave_Click;
			// 
			// cbCarType
			// 
			cbCarType.Font = new Font("Segoe UI", 12F);
			cbCarType.FormattingEnabled = true;
			cbCarType.Location = new Point(361, 109);
			cbCarType.Margin = new Padding(3, 4, 3, 4);
			cbCarType.Name = "cbCarType";
			cbCarType.Size = new Size(191, 36);
			cbCarType.TabIndex = 2;
			cbCarType.SelectedIndexChanged += cbCarType_SelectedIndexChanged;
			// 
			// tbCarID
			// 
			tbCarID.Font = new Font("Segoe UI", 12F);
			tbCarID.Location = new Point(361, 67);
			tbCarID.Margin = new Padding(3, 4, 3, 4);
			tbCarID.Name = "tbCarID";
			tbCarID.PlaceholderText = "ID";
			tbCarID.Size = new Size(191, 34);
			tbCarID.TabIndex = 1;
			tbCarID.TextAlign = HorizontalAlignment.Center;
			// 
			// pCarQ
			// 
			pCarQ.BorderStyle = BorderStyle.FixedSingle;
			pCarQ.Controls.Add(cbHazard);
			pCarQ.Controls.Add(lbHazard);
			pCarQ.Controls.Add(lbLegal);
			pCarQ.Controls.Add(tbLegal);
			pCarQ.Controls.Add(lbMaxTemp);
			pCarQ.Controls.Add(lbMinTemp);
			pCarQ.Controls.Add(tbMaxTemp);
			pCarQ.Controls.Add(tbMinTemp);
			pCarQ.Controls.Add(lbFragile);
			pCarQ.Controls.Add(lbDestination);
			pCarQ.Controls.Add(lbWeight);
			pCarQ.Controls.Add(lbMaterial);
			pCarQ.Controls.Add(chckBox);
			pCarQ.Controls.Add(tbDestination);
			pCarQ.Controls.Add(tbMaterial);
			pCarQ.Controls.Add(tbWeight);
			pCarQ.Location = new Point(217, 187);
			pCarQ.Margin = new Padding(3, 4, 3, 4);
			pCarQ.Name = "pCarQ";
			pCarQ.Size = new Size(480, 319);
			pCarQ.TabIndex = 0;
			// 
			// cbHazard
			// 
			cbHazard.DropDownStyle = ComboBoxStyle.DropDownList;
			cbHazard.Font = new Font("Segoe UI", 12F);
			cbHazard.FormattingEnabled = true;
			cbHazard.Location = new Point(217, 247);
			cbHazard.Margin = new Padding(3, 4, 3, 4);
			cbHazard.Name = "cbHazard";
			cbHazard.Size = new Size(228, 36);
			cbHazard.TabIndex = 19;
			// 
			// lbHazard
			// 
			lbHazard.AutoSize = true;
			lbHazard.Font = new Font("Segoe UI", 12F);
			lbHazard.Location = new Point(34, 257);
			lbHazard.Name = "lbHazard";
			lbHazard.Size = new Size(123, 28);
			lbHazard.TabIndex = 18;
			lbHazard.Text = "Hazard level:";
			// 
			// lbLegal
			// 
			lbLegal.AutoSize = true;
			lbLegal.Font = new Font("Segoe UI", 12F);
			lbLegal.Location = new Point(34, 204);
			lbLegal.Name = "lbLegal";
			lbLegal.Size = new Size(126, 28);
			lbLegal.TabIndex = 17;
			lbLegal.Text = "Legal papers:";
			// 
			// tbLegal
			// 
			tbLegal.Font = new Font("Segoe UI", 12F);
			tbLegal.Location = new Point(217, 193);
			tbLegal.Margin = new Padding(3, 4, 3, 4);
			tbLegal.Name = "tbLegal";
			tbLegal.Size = new Size(228, 34);
			tbLegal.TabIndex = 15;
			// 
			// lbMaxTemp
			// 
			lbMaxTemp.AutoSize = true;
			lbMaxTemp.Font = new Font("Segoe UI", 12F);
			lbMaxTemp.Location = new Point(34, 251);
			lbMaxTemp.Name = "lbMaxTemp";
			lbMaxTemp.Size = new Size(104, 28);
			lbMaxTemp.TabIndex = 14;
			lbMaxTemp.Text = "Max temp:";
			// 
			// lbMinTemp
			// 
			lbMinTemp.AutoSize = true;
			lbMinTemp.Font = new Font("Segoe UI", 12F);
			lbMinTemp.Location = new Point(34, 197);
			lbMinTemp.Name = "lbMinTemp";
			lbMinTemp.Size = new Size(101, 28);
			lbMinTemp.TabIndex = 13;
			lbMinTemp.Text = "Min temp:";
			// 
			// tbMaxTemp
			// 
			tbMaxTemp.Font = new Font("Segoe UI", 12F);
			tbMaxTemp.Location = new Point(217, 247);
			tbMaxTemp.Margin = new Padding(3, 4, 3, 4);
			tbMaxTemp.Name = "tbMaxTemp";
			tbMaxTemp.Size = new Size(228, 34);
			tbMaxTemp.TabIndex = 12;
			tbMaxTemp.KeyPress += tbMaxTemp_KeyPress;
			// 
			// tbMinTemp
			// 
			tbMinTemp.Font = new Font("Segoe UI", 12F);
			tbMinTemp.Location = new Point(217, 193);
			tbMinTemp.Margin = new Padding(3, 4, 3, 4);
			tbMinTemp.Name = "tbMinTemp";
			tbMinTemp.Size = new Size(228, 34);
			tbMinTemp.TabIndex = 11;
			tbMinTemp.KeyPress += tbMinTemp_KeyPress;
			// 
			// lbFragile
			// 
			lbFragile.AutoSize = true;
			lbFragile.Font = new Font("Segoe UI", 12F);
			lbFragile.Location = new Point(34, 197);
			lbFragile.Name = "lbFragile";
			lbFragile.Size = new Size(67, 28);
			lbFragile.TabIndex = 10;
			lbFragile.Text = "Fagile:";
			// 
			// lbDestination
			// 
			lbDestination.AutoSize = true;
			lbDestination.Font = new Font("Segoe UI", 12F);
			lbDestination.Location = new Point(34, 144);
			lbDestination.Name = "lbDestination";
			lbDestination.Size = new Size(116, 28);
			lbDestination.TabIndex = 9;
			lbDestination.Text = "Destination:";
			// 
			// lbWeight
			// 
			lbWeight.AutoSize = true;
			lbWeight.Font = new Font("Segoe UI", 12F);
			lbWeight.Location = new Point(34, 91);
			lbWeight.Name = "lbWeight";
			lbWeight.Size = new Size(109, 28);
			lbWeight.TabIndex = 8;
			lbWeight.Text = "Wight (kg):";
			// 
			// lbMaterial
			// 
			lbMaterial.AutoSize = true;
			lbMaterial.Font = new Font("Segoe UI", 12F);
			lbMaterial.Location = new Point(34, 37);
			lbMaterial.Name = "lbMaterial";
			lbMaterial.Size = new Size(88, 28);
			lbMaterial.TabIndex = 7;
			lbMaterial.Text = "Material:";
			// 
			// chckBox
			// 
			chckBox.Location = new Point(217, 193);
			chckBox.Margin = new Padding(3, 4, 3, 4);
			chckBox.Name = "chckBox";
			chckBox.Size = new Size(229, 39);
			chckBox.TabIndex = 6;
			chckBox.Text = "checkBox1";
			chckBox.UseVisualStyleBackColor = true;
			// 
			// tbDestination
			// 
			tbDestination.Font = new Font("Segoe UI", 12F);
			tbDestination.Location = new Point(217, 140);
			tbDestination.Margin = new Padding(3, 4, 3, 4);
			tbDestination.Name = "tbDestination";
			tbDestination.Size = new Size(228, 34);
			tbDestination.TabIndex = 5;
			// 
			// tbMaterial
			// 
			tbMaterial.Font = new Font("Segoe UI", 12F);
			tbMaterial.Location = new Point(217, 33);
			tbMaterial.Margin = new Padding(3, 4, 3, 4);
			tbMaterial.Name = "tbMaterial";
			tbMaterial.Size = new Size(228, 34);
			tbMaterial.TabIndex = 3;
			// 
			// tbWeight
			// 
			tbWeight.Font = new Font("Segoe UI", 12F);
			tbWeight.Location = new Point(217, 87);
			tbWeight.Margin = new Padding(3, 4, 3, 4);
			tbWeight.Name = "tbWeight";
			tbWeight.Size = new Size(228, 34);
			tbWeight.TabIndex = 4;
			tbWeight.KeyPress += tbWeight_KeyPress;
			// 
			// panel1
			// 
			panel1.Controls.Add(tabControl1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(914, 600);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnTrkCancel);
			panel2.Controls.Add(btnTrkSave);
			panel2.Controls.Add(lbKg);
			panel2.Controls.Add(lbTrkType);
			panel2.Controls.Add(lbTrkWeight);
			panel2.Controls.Add(lbTrkModel);
			panel2.Controls.Add(lbTrkID);
			panel2.Controls.Add(cbTrkType);
			panel2.Controls.Add(tbTrkWeight);
			panel2.Controls.Add(tbTrkModel);
			panel2.Controls.Add(tbTrkID);
			panel2.Location = new Point(0, 0);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(914, 600);
			panel2.TabIndex = 0;
			// 
			// btnTrkCancel
			// 
			btnTrkCancel.Font = new Font("Segoe UI", 12F);
			btnTrkCancel.Location = new Point(488, 290);
			btnTrkCancel.Name = "btnTrkCancel";
			btnTrkCancel.Size = new Size(100, 40);
			btnTrkCancel.TabIndex = 14;
			btnTrkCancel.Text = "Cancel";
			btnTrkCancel.UseVisualStyleBackColor = true;
			btnTrkCancel.Click += btnTrkCancel_Click;
			// 
			// btnTrkSave
			// 
			btnTrkSave.Font = new Font("Segoe UI", 12F);
			btnTrkSave.Location = new Point(278, 290);
			btnTrkSave.Name = "btnTrkSave";
			btnTrkSave.Size = new Size(100, 40);
			btnTrkSave.TabIndex = 13;
			btnTrkSave.Text = "Save";
			btnTrkSave.UseVisualStyleBackColor = true;
			btnTrkSave.Click += btnTrkSave_Click;
			// 
			// lbKg
			// 
			lbKg.AutoSize = true;
			lbKg.Font = new Font("Segoe UI", 12F);
			lbKg.Location = new Point(534, 153);
			lbKg.Name = "lbKg";
			lbKg.Size = new Size(34, 28);
			lbKg.TabIndex = 12;
			lbKg.Text = "kg";
			// 
			// lbTrkType
			// 
			lbTrkType.AutoSize = true;
			lbTrkType.Font = new Font("Segoe UI", 12F);
			lbTrkType.Location = new Point(278, 200);
			lbTrkType.Name = "lbTrkType";
			lbTrkType.Size = new Size(107, 28);
			lbTrkType.TabIndex = 11;
			lbTrkType.Text = "Truck Type:";
			// 
			// lbTrkWeight
			// 
			lbTrkWeight.AutoSize = true;
			lbTrkWeight.Font = new Font("Segoe UI", 12F);
			lbTrkWeight.Location = new Point(278, 150);
			lbTrkWeight.Name = "lbTrkWeight";
			lbTrkWeight.Size = new Size(79, 28);
			lbTrkWeight.TabIndex = 10;
			lbTrkWeight.Text = "Weight:";
			// 
			// lbTrkModel
			// 
			lbTrkModel.AutoSize = true;
			lbTrkModel.Font = new Font("Segoe UI", 12F);
			lbTrkModel.Location = new Point(278, 100);
			lbTrkModel.Name = "lbTrkModel";
			lbTrkModel.Size = new Size(73, 28);
			lbTrkModel.TabIndex = 9;
			lbTrkModel.Text = "Model:";
			// 
			// lbTrkID
			// 
			lbTrkID.AutoSize = true;
			lbTrkID.Font = new Font("Segoe UI", 12F);
			lbTrkID.Location = new Point(278, 50);
			lbTrkID.Name = "lbTrkID";
			lbTrkID.Size = new Size(127, 28);
			lbTrkID.TabIndex = 8;
			lbTrkID.Text = "Licence Plate:";
			// 
			// cbTrkType
			// 
			cbTrkType.Font = new Font("Segoe UI", 12F);
			cbTrkType.FormattingEnabled = true;
			cbTrkType.Location = new Point(420, 200);
			cbTrkType.Name = "cbTrkType";
			cbTrkType.Size = new Size(168, 36);
			cbTrkType.TabIndex = 5;
			// 
			// tbTrkWeight
			// 
			tbTrkWeight.Font = new Font("Segoe UI", 12F);
			tbTrkWeight.Location = new Point(420, 150);
			tbTrkWeight.Name = "tbTrkWeight";
			tbTrkWeight.Size = new Size(108, 34);
			tbTrkWeight.TabIndex = 4;
			tbTrkWeight.KeyPress += tbTrkWeight_KeyPress;
			// 
			// tbTrkModel
			// 
			tbTrkModel.Font = new Font("Segoe UI", 12F);
			tbTrkModel.Location = new Point(420, 100);
			tbTrkModel.Name = "tbTrkModel";
			tbTrkModel.Size = new Size(168, 34);
			tbTrkModel.TabIndex = 3;
			// 
			// tbTrkID
			// 
			tbTrkID.Font = new Font("Segoe UI", 12F);
			tbTrkID.Location = new Point(420, 50);
			tbTrkID.Name = "tbTrkID";
			tbTrkID.Size = new Size(168, 34);
			tbTrkID.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Controls.Add(panel3);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			tabControl1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			pCarQ.ResumeLayout(false);
			pCarQ.PerformLayout();
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		private void BtnTrkSave_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void BinCarSave_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion
		private Button btnAddCargo;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Button btnRfsTruck;
        private Button btnModTruck;
        private Button btnAddTruck;
        private ListBox listBoxTruck;
        private TabPage tabPage1;
        private Button btnRfsCargo;
        private Button btnModCargo;
        private ListBox listBoxCargo;
		private Panel panel1;
        private Panel panel2;
        private Panel panel3;
		private Button btnTrkCancel;
		private Button btnTrkSave;
		private Label lbKg;
		private Label lbTrkType;
		private Label lbTrkWeight;
		private Label lbTrkModel;
		private Label lbTrkID;
		private ComboBox cbTrkType;
		private TextBox tbTrkWeight;
		private TextBox tbTrkModel;
		private TextBox tbTrkID;
		private Button btnCarCancel;
		private Button btnCarSave;
		private ComboBox cbCarType;
		private TextBox tbCarID;
		private Panel pCarQ;
		private ComboBox cbHazard;
		private Label lbHazard;
		private Label lbLegal;
		private TextBox tbLegal;
		private Label lbMaxTemp;
		private Label lbMinTemp;
		private TextBox tbMaxTemp;
		private TextBox tbMinTemp;
		private Label lbFragile;
		private Label lbDestination;
		private Label lbWeight;
		private Label lbMaterial;
		private CheckBox chckBox;
		private TextBox tbDestination;
		private TextBox tbMaterial;
		private TextBox tbWeight;
	}
}
