namespace KakeApp
{
    partial class Form3
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
			tbTrkID = new TextBox();
			tbTrkModel = new TextBox();
			tbTrkWeight = new TextBox();
			cbTrkType = new ComboBox();
			lbTrkID = new Label();
			lbTrkModel = new Label();
			lbTrkWeight = new Label();
			lbTrkType = new Label();
			lbKg = new Label();
			binTrkSave = new Button();
			btnTrkCancel = new Button();
			SuspendLayout();
			// 
			// tbTrkID
			// 
			tbTrkID.Font = new Font("Segoe UI", 12F);
			tbTrkID.Location = new Point(480, 67);
			tbTrkID.Margin = new Padding(3, 4, 3, 4);
			tbTrkID.Name = "tbTrkID";
			tbTrkID.Size = new Size(191, 34);
			tbTrkID.TabIndex = 2;
			// 
			// tbTrkModel
			// 
			tbTrkModel.Font = new Font("Segoe UI", 12F);
			tbTrkModel.Location = new Point(480, 133);
			tbTrkModel.Margin = new Padding(3, 4, 3, 4);
			tbTrkModel.Name = "tbTrkModel";
			tbTrkModel.Size = new Size(191, 34);
			tbTrkModel.TabIndex = 3;
			// 
			// tbTrkWeight
			// 
			tbTrkWeight.Font = new Font("Segoe UI", 12F);
			tbTrkWeight.Location = new Point(480, 200);
			tbTrkWeight.Margin = new Padding(3, 4, 3, 4);
			tbTrkWeight.Name = "tbTrkWeight";
			tbTrkWeight.Size = new Size(123, 34);
			tbTrkWeight.TabIndex = 4;
			tbTrkWeight.KeyPress += tbTrkWeight_KeyPress;
			// 
			// cbTrkType
			// 
			cbTrkType.Font = new Font("Segoe UI", 12F);
			cbTrkType.FormattingEnabled = true;
			cbTrkType.Location = new Point(480, 267);
			cbTrkType.Margin = new Padding(3, 4, 3, 4);
			cbTrkType.Name = "cbTrkType";
			cbTrkType.Size = new Size(191, 36);
			cbTrkType.TabIndex = 5;
			// 
			// lbTrkID
			// 
			lbTrkID.Font = new Font("Segoe UI", 12F);
			lbTrkID.Location = new Point(318, 67);
			lbTrkID.Name = "lbTrkID";
			lbTrkID.Size = new Size(117, 28);
			lbTrkID.TabIndex = 8;
			lbTrkID.Text = "Licence Plate:";
			// 
			// lbTrkModel
			// 
			lbTrkModel.Font = new Font("Segoe UI", 12F);
			lbTrkModel.Location = new Point(318, 133);
			lbTrkModel.Name = "lbTrkModel";
			lbTrkModel.Size = new Size(117, 28);
			lbTrkModel.TabIndex = 9;
			lbTrkModel.Text = "Model:";
			// 
			// lbTrkWeight
			// 
			lbTrkWeight.Font = new Font("Segoe UI", 12F);
			lbTrkWeight.Location = new Point(318, 200);
			lbTrkWeight.Name = "lbTrkWeight";
			lbTrkWeight.Size = new Size(117, 28);
			lbTrkWeight.TabIndex = 10;
			lbTrkWeight.Text = "Weight:";
			// 
			// lbTrkType
			// 
			lbTrkType.Font = new Font("Segoe UI", 12F);
			lbTrkType.Location = new Point(318, 267);
			lbTrkType.Name = "lbTrkType";
			lbTrkType.Size = new Size(117, 28);
			lbTrkType.TabIndex = 11;
			lbTrkType.Text = "Truck Type:";
			// 
			// lbKg
			// 
			lbKg.Font = new Font("Segoe UI", 12F);
			lbKg.Location = new Point(610, 204);
			lbKg.Name = "lbKg";
			lbKg.Size = new Size(117, 28);
			lbKg.TabIndex = 12;
			lbKg.Text = "kg";
			// 
			// binTrkSave
			// 
			binTrkSave.Font = new Font("Segoe UI", 12F);
			binTrkSave.Location = new Point(318, 387);
			binTrkSave.Margin = new Padding(3, 4, 3, 4);
			binTrkSave.Name = "binTrkSave";
			binTrkSave.Size = new Size(114, 53);
			binTrkSave.TabIndex = 13;
			binTrkSave.Text = "Save";
			binTrkSave.UseVisualStyleBackColor = true;
			binTrkSave.Click += binTrkSave_Click;
			// 
			// btnTrkCancel
			// 
			btnTrkCancel.Font = new Font("Segoe UI", 12F);
			btnTrkCancel.Location = new Point(558, 387);
			btnTrkCancel.Margin = new Padding(3, 4, 3, 4);
			btnTrkCancel.Name = "btnTrkCancel";
			btnTrkCancel.Size = new Size(114, 53);
			btnTrkCancel.TabIndex = 14;
			btnTrkCancel.Text = "Cancel";
			btnTrkCancel.UseVisualStyleBackColor = true;
			btnTrkCancel.Click += btnTrkCancel_Click;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(btnTrkCancel);
			Controls.Add(binTrkSave);
			Controls.Add(lbKg);
			Controls.Add(lbTrkType);
			Controls.Add(lbTrkWeight);
			Controls.Add(lbTrkModel);
			Controls.Add(lbTrkID);
			Controls.Add(cbTrkType);
			Controls.Add(tbTrkWeight);
			Controls.Add(tbTrkModel);
			Controls.Add(tbTrkID);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form3";
			Text = "Form3";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbTrkID;
        private TextBox tbTrkModel;
        private TextBox tbTrkWeight;
        private ComboBox cbTrkType;
        private Label lbTrkID;
        private Label lbTrkModel;
        private Label lbTrkWeight;
        private Label lbTrkType;
        private Label lbKg;
        private Button binTrkSave;
        private Button btnTrkCancel;
    }
}