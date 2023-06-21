using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSurvivor
{
    internal class Chiyo : Singleton<Chiyo>, IMove,IMoveEvent
    {
        public PictureBox PB { get; set; }
        protected Form Fm;
        protected bool LeftKeyPressed = false;
        protected bool RightKeyPressed = false;
        protected bool UpKeyPressed = false;
        protected bool DownKeyPressed = false;

        private const int ROWCNT = 3, COLCNT = 9, SPRITEWIDTH = 42, SPRITEHEIGHT = 80;

        private List<Bitmap> _cells;
        private int _currentFrame = 0, _numFrame = 9, _animeState = 0;

        public int Speed { get; set; }
        

        public void Init(Form form)
        {
            Fm = form;
            PB = MakePb();
            form.Controls.Add(PB);
            _cells = MakeSpriteCell();
            Speed = 15;
        }

        public PictureBox MakePb()
        {
            PictureBox pictureBox = new();
            pictureBox.Location = new Point(5, 5);
            pictureBox.Size = new Size(SPRITEWIDTH, SPRITEHEIGHT);

            return pictureBox;
        }

        private List<Bitmap> MakeSpriteCell()
        {
            List<Bitmap> splitImage = new();
            Bitmap img = Form1._azmgSprite["ChiYo"];

            for (int i = 0; i < ROWCNT; i++)
            {
                for (int x = 0; x < COLCNT; x++)
                {
                    Rectangle cellRect = new(SPRITEWIDTH * x, SPRITEHEIGHT * i, SPRITEWIDTH, SPRITEHEIGHT);
                    var tmpimg = img.Clone(cellRect, System.Drawing.Imaging.PixelFormat.DontCare);
                    if (tmpimg != null) splitImage.Add(tmpimg);
                }
            }
            return splitImage;
        }

        public void Left()
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
                    _animeState = 1;
                    break;
                case Keys.Right:
                    RightKeyPressed = true;
                    _animeState = 1;
                    break;
                case Keys.Up:
                    UpKeyPressed = true;
                    _animeState = 0;
                    break;
                case Keys.Down:
                    DownKeyPressed = true;
                    _animeState = 2;
                    break;
            }
        }
        public void KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    LeftKeyPressed = false;
                    break;
                case Keys.Right:
                    RightKeyPressed = false;
                    break;
                case Keys.Up:
                    UpKeyPressed = false;
                    break;
                case Keys.Down:
                    DownKeyPressed = false;
                    break;
            }
        }

        public void Timer_Tick(object? sender, EventArgs e)
        {
            _currentFrame = (_currentFrame + 1)%_numFrame;
            Bitmap tmpimg = null;
            if (_cells != null)
            {
                tmpimg = new(_cells[_currentFrame + _animeState * _numFrame]); 
            }
            Image oldimg = PB.Image;

            if (LeftKeyPressed)
            {
                Left();
                tmpimg.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (RightKeyPressed) Right();
            if (UpKeyPressed) Up();
            if (DownKeyPressed) Down();

            if (tmpimg != null) PB.Image = (Bitmap)tmpimg;
            oldimg?.Dispose();
        }
    }
}
