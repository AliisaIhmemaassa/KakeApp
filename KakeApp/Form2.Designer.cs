namespace KakeApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
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
			tbCarID = new TextBox();
			cbCarType = new ComboBox();
			binCarSave = new Button();
			btnCarCancel = new Button();
			pCarQ.SuspendLayout();
			SuspendLayout();
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
			pCarQ.Paint += pCarQ_Paint;
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
			// 
			// tbMinTemp
			// 
			tbMinTemp.Font = new Font("Segoe UI", 12F);
			tbMinTemp.Location = new Point(217, 193);
			tbMinTemp.Margin = new Padding(3, 4, 3, 4);
			tbMinTemp.Name = "tbMinTemp";
			tbMinTemp.Size = new Size(228, 34);
			tbMinTemp.TabIndex = 11;
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
			tbMaterial.TextChanged += tbMaterial_TextChanged;
			// 
			// tbWeight
			// 
			tbWeight.Font = new Font("Segoe UI", 12F);
			tbWeight.Location = new Point(217, 87);
			tbWeight.Margin = new Padding(3, 4, 3, 4);
			tbWeight.Name = "tbWeight";
			tbWeight.Size = new Size(228, 34);
			tbWeight.TabIndex = 4;
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
			// binCarSave
			// 
			binCarSave.Font = new Font("Segoe UI", 12F);
			binCarSave.Location = new Point(297, 520);
			binCarSave.Margin = new Padding(3, 4, 3, 4);
			binCarSave.Name = "binCarSave";
			binCarSave.Size = new Size(114, 53);
			binCarSave.TabIndex = 3;
			binCarSave.Text = "Save";
			binCarSave.UseVisualStyleBackColor = true;
			binCarSave.Click += binCarSave_Click;
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
			// Form2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(btnCarCancel);
			Controls.Add(binCarSave);
			Controls.Add(cbCarType);
			Controls.Add(tbCarID);
			Controls.Add(pCarQ);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form2";
			Text = "Form2";
			pCarQ.ResumeLayout(false);
			pCarQ.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pCarQ;
        private TextBox tbCarID;
        private ComboBox cbCarType;
        private TextBox tbMaterial;
        private CheckBox chckBox;
        private TextBox tbDestination;
        private TextBox tbWeight;
        private Label lbFragile;
        private Label lbDestination;
        private Label lbWeight;
        private Label lbMaterial;
        private Button binCarSave;
        private Button btnCarCancel;
        private TextBox tbMaxTemp;
        private TextBox tbMinTemp;
        private Label lbMaxTemp;
        private Label lbMinTemp;
        private TextBox tbLegal;
        private Label lbHazard;
        private Label lbLegal;
        private ComboBox cbHazard;
    }
}