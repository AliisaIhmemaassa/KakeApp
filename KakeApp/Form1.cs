namespace KakeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.BringToFront();
            Console.WriteLine(lbTrkWeight.Width);
            Console.WriteLine(lbTrkType.Width);
            Console.WriteLine(tbTrkWeight.Width);
            Console.WriteLine(cbTrkType.Width);
            ;
        }

        private void btnAddTruck_Click(object sender, EventArgs e)
        {
            Console.WriteLine("BTruck");
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel2.BringToFront();
        }

        private void btnModTruck_Click(object sender, EventArgs e)
        {

        }

        private void btnRfsTruck_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            Console.WriteLine("BCar");
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.BringToFront();
        }

        private void btnModCargo_Click(object sender, EventArgs e)
        {

        }

        private void btnRfsCargo_Click(object sender, EventArgs e)
        {

        }
    }
}
