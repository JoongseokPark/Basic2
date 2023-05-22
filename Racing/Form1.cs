namespace Racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int onoff = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 40;
            if (onoff == 1)
            {
                button1.Text = "정지";
                timer1.Tick += Timer1_Tick;
                timer1.Start();
                onoff = 0;
            }
            else if (onoff == 0)
            {
                timer1.Tick -= Timer1_Tick;
                button1.Text = "출발";
                timer1.Stop();
                onoff = 1;
            }
            
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X+20, pictureBox1.Location.Y);
            if (pictureBox1.Location.X > ClientSize.Width)
            {
                pictureBox1.Location = new Point(12, pictureBox1.Location.Y);
            }
            
        }
    }
}