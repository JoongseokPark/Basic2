using System.Diagnostics;
using System.Windows.Forms;

namespace animalSurvivor
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, Bitmap> _animalSprite = new();
        public static Dictionary<string, Bitmap> _azmgSprite = new();
        public delegate int CalAdd(int a, int b);
        public delegate void PrintString();
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap sprite1 = new Bitmap(Image.FromFile("C:\\Works\\Parkjs\\animalSurvivor\\image\\animals.png"));
            _animalSprite.Add("horse", spriteSplit(sprite1, 2, 2, 320, 320));
            _animalSprite.Add("cow", spriteSplit(sprite1, 324, 66, 256, 256));
            _animalSprite.Add("tiger", spriteSplit(sprite1, 582, 98, 224, 244));
            _animalSprite.Add("goat", spriteSplit(sprite1, 808, 130, 192, 192));

            _animalSprite.Add("sheep", spriteSplit(sprite1, 2, 326, 192, 192));
            _animalSprite.Add("pig", spriteSplit(sprite1, 196, 326, 192, 192));
            _animalSprite.Add("dog", spriteSplit(sprite1, 390, 358, 160, 160));
            _animalSprite.Add("crow", spriteSplit(sprite1, 552, 358, 160, 160));
            _animalSprite.Add("cat", spriteSplit(sprite1, 714, 390, 128, 128));
            _animalSprite.Add("chicken", spriteSplit(sprite1, 844, 390, 128, 128));

            _animalSprite.Add("pigeon_flying", spriteSplit(sprite1, 2, 522, 128, 128));
            _animalSprite.Add("pigeon", spriteSplit(sprite1, 132, 522, 128, 128));
            _animalSprite.Add("rabbit", spriteSplit(sprite1, 262, 522, 128, 128));
            _animalSprite.Add("frog", spriteSplit(sprite1, 392, 554, 96, 96));
            _animalSprite.Add("fox", spriteSplit(sprite1, 490, 554, 96, 96));

            Bitmap sprite2 = new Bitmap(Image.FromFile("C:\\Works\\Parkjs\\animalSurvivor\\image\\azumanga.png"));
            _azmgSprite.Add("ChiYo", spriteSplit(sprite2, 0, 16, 378, 240));
            _azmgSprite.Add("OSaKa", spriteSplit(sprite2, 420, 16, 420, 240));

            //Chiyo.Instance.Init(this);
            //KeyDown += Chiyo.Instance.KeyDown;
            //KeyUp += Chiyo.Instance.KeyUp;
            //timer1.Tick += Chiyo.Instance.Timer_Tick;
            //timer1.Interval = 40;
            //timer1.Start();

            //Link link = new(this);
            //KeyDown += link.KeyDown;
            //KeyUp += link.KeyUp;
            //timer2.Tick += link.Timer_Tick;
            //timer2.Interval = 40;
            //timer2.Start();

            //소 찾기
            //List<Animal> animal = new List<Animal>();
            //animal.Add(new Cow(this));
            //animal.Add(new Rabbit(this));
            //animal.Add(new Pigeon(this));
            //animal.Add(new Horse(this));
            //animal.Add(new Tiger(this));
            //animal.Add(new Goat(this));
            //animal.Add(new Cat(this));

            //animal.ForEach(x =>
            //{
            //    x.ThreadStart();
            //});

            //var cow = animal.FindAll(x => x.GetType() == typeof(Cow));

            //인덱스가 짝수인 동물 찾기
            //Func<int, bool> isEvenIndex = index => index % 2 == 0;
            //animal = animal.Where((x, i) => isEvenIndex(i)).ToList();

            //animal.ForEach(x =>
            //{
            //    x.ThreadStart();
            //});
            //Animal[] animals = new Animal[]
            //{
            //    new Horse(this),
            //    new Tiger(this),
            //    new Rabbit(this),
            //    new Cow(this),
            //    new Cat(this),
            //    new Pigeon(this),
            //    new Goat(this)
            //};
            //foreach (var pet in animals)
            //{
            //    pet.ThreadStart();
            //}

            //show score
            Score.Instance.Init(this);
            //move charater
            Chiyo.Instance.Init(this);
            KeyDown += Chiyo.Instance.KeyDown;
            KeyUp += Chiyo.Instance.KeyUp;
            timer1.Tick += Chiyo.Instance.Timer_Tick;
            timer1.Interval = 40;
            timer1.Start();
            //monster spawn
            timer2.Tick += SpawnAnimals;
            timer2.Interval = 1000;
            timer2.Start();

            //timer1.interval = 50;
            //timer1.start();

            ////익명함수
            //CalAdd cal = delegate (int a, int b)
            //{
            //    return (a + b);
            //};
            //MessageBox.Show(cal(3, 5).ToString());

            //식형식 람다
            //CalAdd cal = (a, b) => a + b;
            //MessageBox.Show(cal(3, 5).ToString());

            //문형식 람다
            //PrintString ps = () =>
            //{
            //    MessageBox.Show("First Line");
            //    MessageBox.Show("Second Line");
            //    MessageBox.Show("End Line");
            //};
            //ps();

            //반환형이 없는 Action
            //Action<string> logMessage = message => MessageBox.Show($"log : {message}");
            //Action<string> showMessage =message => MessageBox.Show($"Message : {message}");

            //EventHandler handler = (sender, e) =>
            //{
            //    logMessage("Event occured");
            //    showMessage("Hello World");
            //};

            //handler(null,EventArgs.Empty);

            //마지막이 반환형인 Func
            //Func<int, int, int> add = (a, b) => a + b;
            //Func<int, int, int> sub = (a, b) => a - b;
            //Func<int, int, int> mul = (a, b) => a * b;
            //Func<int, int, int> div = (a, b) => b != 0 ? a / b : 0;

            //int result1 = add(4, 6);
            //int result2 = sub(4, 6);
            //int result3 = mul(4, 6);
            //int result4 = div(4, 6);

            //MessageBox.Show($"result : {result1}");
            //MessageBox.Show($"result : {result2}");
            //MessageBox.Show($"result : {result3}");
            //MessageBox.Show($"result : {result4}");
        }


        private Bitmap spriteSplit(Bitmap sprite, int x, int y, int width, int height)
        {
            Rectangle srcRect = new Rectangle(x, y, width, height);
            var tmpsprite = sprite.Clone(srcRect, System.Drawing.Imaging.PixelFormat.DontCare);
            return tmpsprite;
        }

        private void SpawnAnimals(object sender, EventArgs e)
        {
            Random rnd = new();
            int animalNum = rnd.Next(0, 7);
            Animals animals = new(this, (AnimalEnum)animalNum);
            List<Animal> animalList = animals.AnimalList;
            animalList.ForEach(a => a.ThreadStart());
        }

        
    }
}