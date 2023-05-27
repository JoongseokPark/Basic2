namespace Racing
{
    public partial class Form1 : Form
    {
        Car _car;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Car(this, "Car", 0, 30);
            vehicles[1] = new bike(this, "Bike", 0, 130);
            vehicles[2] = new Scooter(this, "Scooter", 0, 230);

            foreach (var vehicle in vehicles)
            {
                button1.Click += vehicle.StartRace;
                vehicle.FinshRace += Vehicle_FinshRace;
            }

            


            //int onoff = 1;
            //private void button1_Click(object sender, EventArgs e)
            //{
            //    timer1.Interval = 40;
            //    if (onoff == 1)
            //    {
            //        button1.Text = "정지";
            //        timer1.Tick += _car.Timer1_Tick;
            //        timer1.Start();
            //        onoff = 0;
            //    }
            //    else if (onoff == 0)
            //    {
            //        timer1.Tick -= _car.Timer1_Tick;
            //        button1.Text = "출발";
            //        timer1.Stop();
            //        onoff = 1;
            //    }

        //}


        }
        private void Vehicle_FinshRace(string name)
        {
            if (label1.Text == "누가 1등을 할까?")
            {
                label1.Text = $"1등은 {name}입니다";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "누가 1등을 할까?";
        }
    }
}