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
            tbCarID = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tbTrkLicense = new TextBox();
            tbTrkModel = new TextBox();
            tbTrkWeight = new TextBox();
            cbTrkType = new ComboBox();
            lbTrkLicense = new Label();
            lbTrkModel = new Label();
            lbTrkWeight = new Label();
            lbTrkType = new Label();
            cbCarType = new ComboBox();
            panel4 = new Panel();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddCargo
            // 
            btnAddCargo.Location = new Point(370, 40);
            btnAddCargo.Name = "btnAddCargo";
            btnAddCargo.Size = new Size(100, 45);
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRfsTruck);
            tabPage2.Controls.Add(btnModTruck);
            tabPage2.Controls.Add(btnAddTruck);
            tabPage2.Controls.Add(listBoxTruck);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRfsTruck
            // 
            btnRfsTruck.Font = new Font("Segoe UI", 20F);
            btnRfsTruck.Location = new Point(370, 160);
            btnRfsTruck.Name = "btnRfsTruck";
            btnRfsTruck.Size = new Size(100, 45);
            btnRfsTruck.TabIndex = 6;
            btnRfsTruck.Text = "🔄️";
            btnRfsTruck.UseVisualStyleBackColor = true;
            btnRfsTruck.Click += btnRfsTruck_Click;
            // 
            // btnModTruck
            // 
            btnModTruck.Location = new Point(370, 100);
            btnModTruck.Name = "btnModTruck";
            btnModTruck.Size = new Size(100, 45);
            btnModTruck.TabIndex = 5;
            btnModTruck.Text = "Modify Trucks";
            btnModTruck.UseVisualStyleBackColor = true;
            btnModTruck.Click += btnModTruck_Click;
            // 
            // btnAddTruck
            // 
            btnAddTruck.Location = new Point(370, 40);
            btnAddTruck.Name = "btnAddTruck";
            btnAddTruck.Size = new Size(100, 45);
            btnAddTruck.TabIndex = 4;
            btnAddTruck.Text = "Add Trucks";
            btnAddTruck.UseVisualStyleBackColor = true;
            btnAddTruck.Click += btnAddTruck_Click;
            // 
            // listBoxTruck
            // 
            listBoxTruck.FormattingEnabled = true;
            listBoxTruck.Location = new Point(6, 10);
            listBoxTruck.Name = "listBoxTruck";
            listBoxTruck.Size = new Size(335, 379);
            listBoxTruck.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRfsCargo);
            tabPage1.Controls.Add(btnModCargo);
            tabPage1.Controls.Add(listBoxCargo);
            tabPage1.Controls.Add(btnAddCargo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRfsCargo
            // 
            btnRfsCargo.Font = new Font("Segoe UI", 20F);
            btnRfsCargo.Location = new Point(370, 160);
            btnRfsCargo.Name = "btnRfsCargo";
            btnRfsCargo.Size = new Size(100, 45);
            btnRfsCargo.TabIndex = 3;
            btnRfsCargo.Text = "🔄️";
            btnRfsCargo.UseVisualStyleBackColor = true;
            btnRfsCargo.Click += btnRfsCargo_Click;
            // 
            // btnModCargo
            // 
            btnModCargo.Location = new Point(370, 100);
            btnModCargo.Name = "btnModCargo";
            btnModCargo.Size = new Size(100, 45);
            btnModCargo.TabIndex = 2;
            btnModCargo.Text = "Modify Cargo";
            btnModCargo.UseVisualStyleBackColor = true;
            btnModCargo.Click += btnModCargo_Click;
            // 
            // listBoxCargo
            // 
            listBoxCargo.FormattingEnabled = true;
            listBoxCargo.Location = new Point(6, 10);
            listBoxCargo.Name = "listBoxCargo";
            listBoxCargo.Size = new Size(335, 379);
            listBoxCargo.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbCarID);
            panel3.Controls.Add(cbCarType);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 0;
            // 
            // tbCarID
            // 
            tbCarID.Location = new Point(572, 362);
            tbCarID.Name = "tbCarID";
            tbCarID.Size = new Size(100, 23);
            tbCarID.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbTrkLicense);
            panel2.Controls.Add(tbTrkModel);
            panel2.Controls.Add(tbTrkWeight);
            panel2.Controls.Add(cbTrkType);
            panel2.Controls.Add(lbTrkLicense);
            panel2.Controls.Add(lbTrkModel);
            panel2.Controls.Add(lbTrkWeight);
            panel2.Controls.Add(lbTrkType);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 0;
            // 
            // tbTrkLicense
            // 
            tbTrkLicense.Location = new Point(440, 50);
            tbTrkLicense.Name = "tbTrkLicense";
            tbTrkLicense.Size = new Size(162, 23);
            tbTrkLicense.TabIndex = 7;
            // 
            // tbTrkModel
            // 
            tbTrkModel.Location = new Point(440, 80);
            tbTrkModel.Name = "tbTrkModel";
            tbTrkModel.Size = new Size(120, 23);
            tbTrkModel.TabIndex = 9;
            // 
            // tbTrkWeight
            // 
            tbTrkWeight.Location = new Point(440, 140);
            tbTrkWeight.Name = "tbTrkWeight";
            tbTrkWeight.Size = new Size(100, 23);
            tbTrkWeight.TabIndex = 11;
            // 
            // cbTrkType
            // 
            cbTrkType.FormattingEnabled = true;
            cbTrkType.Location = new Point(440, 110);
            cbTrkType.Name = "cbTrkType";
            cbTrkType.Size = new Size(121, 23);
            cbTrkType.TabIndex = 13;
            // 
            // lbTrkLicense
            // 
            lbTrkLicense.AutoSize = true;
            lbTrkLicense.Font = new Font("Segoe UI", 16F);
            lbTrkLicense.Location = new Point(360, 55);
            lbTrkLicense.Name = "lbTrkLicense";
            lbTrkLicense.Size = new Size(159, 30);
            lbTrkLicense.TabIndex = 15;
            lbTrkLicense.Text = "Licensaeeplate:";
            // 
            // lbTrkModel
            // 
            lbTrkModel.AutoSize = true;
            lbTrkModel.Font = new Font("Segoe UI", 16F);
            lbTrkModel.Location = new Point(360, 85);
            lbTrkModel.Name = "lbTrkModel";
            lbTrkModel.Size = new Size(81, 30);
            lbTrkModel.TabIndex = 17;
            lbTrkModel.Text = "Model:";
            // 
            // lbTrkWeight
            // 
            lbTrkWeight.AutoSize = true;
            lbTrkWeight.Font = new Font("Segoe UI", 16F);
            lbTrkWeight.Location = new Point(360, 115);
            lbTrkWeight.Name = "lbTrkWeight";
            lbTrkWeight.Size = new Size(131, 30);
            lbTrkWeight.TabIndex = 19;
            lbTrkWeight.Text = "Weight (kg):";
            // 
            // lbTrkType
            // 
            lbTrkType.AutoSize = true;
            lbTrkType.Font = new Font("Segoe UI", 16F);
            lbTrkType.Location = new Point(360, 145);
            lbTrkType.Name = "lbTrkType";
            lbTrkType.Size = new Size(122, 30);
            lbTrkType.TabIndex = 21;
            lbTrkType.Text = "Truck Type:";
            // 
            // cbCarType
            // 
            cbCarType.FormattingEnabled = true;
            cbCarType.Location = new Point(340, 214);
            cbCarType.Name = "cbCarType";
            cbCarType.Size = new Size(121, 23);
            cbCarType.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Location = new Point(300, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private TextBox tbTrkLicense;
        private TextBox tbTrkModel;
        private TextBox tbTrkWeight;
        private ComboBox cbTrkType;
        private Label lbTrkLicense;
        private Label lbTrkModel;
        private Label lbTrkWeight;
        private Label lbTrkType;
        private TextBox tbCarID;
        private ComboBox cbCarType;
        private Panel panel4;
    }
}
