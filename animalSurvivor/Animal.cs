using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSurvivor
{
    internal abstract class Animal : IMove
    {
        protected bool _LeftKeyPressed = false;
        protected bool _RightKeyPressed = false;
        protected bool _UpKeyPressed = false;
        protected bool _DownKeyPressed = false;
        public PictureBox PB { get; set; }
        protected Form _form;

        protected List<Bitmap> Cells { get; set; } 
        private int _speed = 3;

        private int _tickCnt = 0;
        private int _currentFrame = 0, _numFrame = 4, _animeState = 0;
        protected const int ENDTICKCNT = 30, ENDLINE = 100, ROWCNT = 4, COLCNT = 4;

        protected int Speed
        {
            get { return _speed; }
            set { _speed = value; }   
        }
        System.Threading.Timer _timer;
        delegate void ThreadTimerFired();
        bool _disposed = false;
        protected abstract PictureBox MakePictureBox();
        protected abstract List<Bitmap> MakeSpriteCell();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if(_disposed) return;
            if(disposing)
            {
                Score.Instance.AddScore();
                _timer.Dispose();
                PB.Dispose();
            }
            _disposed = true;
        }
        public void AutoMove()
        {
            _tickCnt++;
            _currentFrame = (_currentFrame + 1) % _numFrame;
            
            if(_tickCnt > ENDTICKCNT)
            {
                _LeftKeyPressed = false;
                _RightKeyPressed = false;
                _UpKeyPressed = false;
                _DownKeyPressed = false;
                _currentFrame = 0;

                Random rnd = new();
                int direction = rnd.Next(4);
                _animeState = direction;
                switch(direction)
                {
                    case 0:
                        _DownKeyPressed=true;
                        _animeState = 0;
                        break;
                    case 1:
                        _UpKeyPressed = true;
                        _animeState = 3;
                        break;
                    case 2:
                        _RightKeyPressed = true;
                        _animeState = 2;
                        break;
                    case 3:
                        _LeftKeyPressed = true;
                        _animeState = 1;
                        break;
                }
                _tickCnt = 0;
            }
            else
            {
                if (PB != null && Chiyo.Instance.PB != null)
                {
                    int dx = PB.Location.X - Chiyo.Instance.PB.Location.X;
                    int dy = PB.Location.Y - Chiyo.Instance.PB.Location.Y;
                    double distance = Math.Sqrt(Math.Pow(dx,2) + Math.Pow(dy,2));

                    if(distance < 500)
                    {
                        double angle = Math.Atan2(dy, dx);
                        PB.Left -= (int)(Math.Cos(angle) * _speed);
                        PB.Top -= (int)(Math.Sin(angle) * _speed);
                        if ((int)angle == 1) _animeState = 3;
                        if ((int)angle == 3) _animeState = 2;
                        if ((int)angle == 0) _animeState = 1;
                        if ((int)angle < 0) _animeState = 0;

                        if(distance < 30)
                        {
                            Dispose();
                        }
                    }
                    else
                    {
                        if (_LeftKeyPressed) Left();
                        if (_RightKeyPressed) Right();
                        if (_UpKeyPressed) Up();
                        if (_DownKeyPressed) Down();

                        if (PB.Location.X > _form.Width - ENDLINE)
                        {
                            _RightKeyPressed = false;
                            _LeftKeyPressed = true;
                            _animeState = 1;
                        }
                        if (PB.Location.X < ENDLINE)
                        {
                            _RightKeyPressed = true;
                            _LeftKeyPressed = false;
                            _animeState = 2;
                        }
                        if (PB.Location.Y > _form.Height - ENDLINE)
                        {
                            _UpKeyPressed = true;
                            _DownKeyPressed = false;
                            _animeState = 3;
                        }
                        if (PB.Location.Y < ENDLINE)
                        {
                            _DownKeyPressed = true;
                            _UpKeyPressed = false;
                            _animeState = 0;
                        }

                        Image oldimg = PB.Image;
                        Bitmap img = null;
                        if (Cells != null)
                        {
                            img = new(Cells[_currentFrame + _animeState * _numFrame]);
                        }
                        PB.Image = img;
                        oldimg?.Dispose();
                    }
                }
                
            }
            
        }

        // IMove 구현
        public virtual void Right()
        {
            if (PB != null) PB.Left += _speed;
        }
        public virtual void Left()
        {
            if (PB != null) PB.Left -= _speed;
        }
        public virtual void Up()
        {
            if (PB != null) PB.Top -= _speed;
        }
        public virtual void Down()
        {
            if (PB != null) PB.Top += _speed;
        }

        public void ThreadStart()
        {
            Random rnd = new();
            _timer = new System.Threading.Timer(CallBack);
            _timer.Change(0,rnd.Next(30,45));
        }

        public void CallBack(object? src)
        {
            if (_form != null)
            {
                if(_form.InvokeRequired)
                {
                    _form.BeginInvoke(new ThreadTimerFired(AutoMove));
                }
            }
        }
    }
}
