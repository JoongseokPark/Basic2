using System.Diagnostics.Eventing.Reader;

namespace VehicleMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IMOVE bike = new bike(this, "µû¸ª");
            bike.Speed = 15;
        }

    }
}