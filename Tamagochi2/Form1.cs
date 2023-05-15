namespace Tamagochi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<int,Cat> dic = new Dictionary<int,Cat>();
            int width = 215, height = 235, j = 0;
            for (int i = 1; i < 10; i++)
            {
                dic.Add(i, new Cat("Cat", i * width + 5 - j*645, height * j + 5));
                this.Controls.Add(dic[i].GetPanel());
                if (i % 3 == 0) j++;
                
            }
            //Cat cat1 = new Cat("³Ä¿ËÀÌ", 5, 5);
            //Cat cat2 = new Cat("³ªºñ", 220, 5);
            //Cat cat3 = new Cat("¿ÀÀ×", 435, 5);
            //this.Controls.Add(cat1.GetPanel());
            //this.Controls.Add(cat2.GetPanel());
            //this.Controls.Add(cat3.GetPanel());
            //string[] emos = { "idle", "cry", "feed", "happy", "hungry", "sleep" };
            //comboBox1.Items.AddRange(emos);
            //comboBox1.SelectedIndex = 0;
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Cat cat = new(pictureBox1);
        //    label1.Text = comboBox1.SelectedItem.ToString();
        //    switch (comboBox1.SelectedIndex)
        //    {
        //        case 0:
        //            cat.Idle();
        //            break;
        //        case 1:
        //            cat.Cry();
        //            break;
        //        case 2:
        //            cat.Idle();
        //            break;
        //        case 3:
        //            cat.Idle();
        //            break;
        //        case 4:
        //            cat.Idle();
        //            break;
        //        case 5:
        //            cat.Idle();
        //            break;
        //    }
        //}

    }
}