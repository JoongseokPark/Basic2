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
            
            //Cat cat1 = new Cat("냐옹이", 5, 5);
            //Cat cat2 = new Cat("나비", 220, 5);
            //Cat cat3 = new Cat("오잉", 435, 5);
            //this.Controls.Add(cat1.GetPanel());
            //this.Controls.Add(cat2.GetPanel());
            //this.Controls.Add(cat3.GetPanel());

            //Cat[] cats = new Cat[20];
            //int j = 0, k = 0, div = 4;
            //for(int i=0; i < cats.Length; i++)
            //{
            //    string catname = "고양이" + (i + 1);
            //    cats[i] = new Cat(catname, 5 + (k * 210), 5 + (j * 230));
            //    this.Controls.Add(cats[i].Pn);
            //    k++;
            //    if (i != 0 && (i+1) % div == 0)
            //    {
            //        j++;
            //        k = 0;
            //    }
            //}

            Dog[] dogs = new Dog[20];
            int j = 0, k = 0, div = 4;
            for (int i = 0; i < dogs.Length; i++)
            {
                string dogname = "강아지" + (i + 1);
                dogs[i] = new Dog(dogname, 5 + (k * 210), 5 + (j * 230));
                this.Controls.Add(dogs[i].Pn);
                k++;
                if (i != 0 && (i + 1) % div == 0)
                {
                    j++;
                    k = 0;
                }
            }

            //Dictionary<int,Cat> dic = new Dictionary<int,Cat>();
            //int width = 215, height = 235, j = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    dic.Add(i, new Cat("Cat", i * width + 5 - j*645, height * j + 5));
            //    this.Controls.Add(dic[i].GetPanel());
            //    if (i % 3 == 0) j++;

            //}
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