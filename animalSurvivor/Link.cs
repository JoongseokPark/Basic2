using animalSurvivor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSurvivor
{
    internal class Link : IMove, IMoveEvent
    {
        protected bool LeftKeyPressed = false;
        protected bool RightKeyPressed = false;
        protected bool UpKeyPressed = false;
        protected bool DownKeyPressed = false;

        private Image _img = Image.FromFile("C:\\Works\\Parkjs\\VehicleMove\\image\\zelda.png");
        private const int ROWCNT = 8, CELLCNT = 10, SPRITEWIDTH = 120, SPRITEHEIGHT = 130;

        private List<Image> _cells;
        private int _currentFrame = 0, _numFrame = 3, _animeState = 0;

        public PictureBox PB { get; set; }
        public int Speed { get; set; }
        protected Form Fm;

        public Link(Form form)
        {
            Fm = form;
            PB = MakePb();
            _cells = Split((Bitmap)_img);
            form.Controls.Add(PB);
            Speed = 15;
        }

        public PictureBox MakePb()
        {
            PictureBox pictureBox = new();
            pictureBox.Location = new Point(5, 5);
            pictureBox.Size = new Size(SPRITEWIDTH, SPRITEHEIGHT);

            return pictureBox;
        }

        private List<Image> Split(Bitmap image)
        {
            List<Image> splitImage = new();

            for (int i = 0; i < ROWCNT; i++)
            {
                Rectangle srcRect = new Rectangle(0, SPRITEHEIGHT * i, image.Width, SPRITEHEIGHT);
                var row = image.Clone(srcRect, System.Drawing.Imaging.PixelFormat.DontCare);

                for (int x = 0; x < CELLCNT; x++)
                {
                    Rectangle cellRect = new(SPRITEWIDTH * x, 0, SPRITEWIDTH, SPRITEHEIGHT);
                    var tmpimg = row.Clone(cellRect, System.Drawing.Imaging.PixelFormat.DontCare);
                    if (tmpimg != null) splitImage.Add(tmpimg);
                }
            }
            return splitImage;
        }

        public  void Left()
        {
            if (PB != null) PB.Left = PB.Left - Speed;
        }
        public void Right()
        {
            if (PB != null) PB.Left = PB.Left + Speed;
        }
        public void Up()
        {
            if (PB != null) PB.Top = PB.Top - Speed;
        }
        public void Down()
        {
            if (PB != null) PB.Top = PB.Top + Speed;
        }
        public void KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    LeftKeyPressed = true;
                    _animeState = 5;
                    _numFrame = 10;
                    break;
                case Keys.Right:
                    RightKeyPressed = true;
                    _animeState = 7;
                    _numFrame = 10;
                    break;
                case Keys.Up:
                    UpKeyPressed = true;
                    _animeState = 6;
                    _numFrame = 10;
                    break;
                case Keys.Down:
                    DownKeyPressed = true;
                    _animeState = 4;
                    _numFrame = 10;
                    break;
            }
        }
        public void KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    LeftKeyPressed = false;
                    _animeState = 1;
                    _numFrame = 3;
                    _currentFrame = 0;
                    break;
                case Keys.Right:
                    RightKeyPressed = false;
                    _animeState = 3;
                    _numFrame = 3;
                    _currentFrame = 0;
                    break;
                case Keys.Up:
                    UpKeyPressed = false;
                    _animeState = 2;
                    _numFrame = 1;
                    _currentFrame = 0;
                    break;
                case Keys.Down:
                    DownKeyPressed = false;
                    _animeState = 0;
                    _numFrame = 3;
                    _currentFrame = 0;
                    break;
            }
        }

        public void Timer_Tick(object? sender, EventArgs e)
        {
            if (LeftKeyPressed) Left();
            if (RightKeyPressed) Right();
            if (UpKeyPressed) Up();
            if (DownKeyPressed) Down();

            _currentFrame = (_currentFrame + 1) % _numFrame;
            Bitmap tmpimg = new(_cells[_animeState * 10 + _currentFrame]);
            var oldimg = PB?.Image;
            if (tmpimg != null) PB.Image = (Bitmap)tmpimg;
            oldimg?.Dispose();
        }

    }
}
