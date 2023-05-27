using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    internal abstract class Vehicle
    {
        protected PictureBox PB { get; set; }
        protected Form _form;
        protected System.Windows.Forms.Timer _timer;
        public delegate void RaceEnd(string name);
        public event RaceEnd? FinshRace;

        internal string Name { get; set; }

        protected void InitTimer()
        {
            _timer = new System.Windows.Forms.Timer()
            {
                Interval = 20
            };
            _timer.Tick += Timer1_Tick;
        }
        protected abstract void MoveForward();

        public abstract PictureBox MakePb(int x, int y);

        internal void Timer1_Tick(object? sender, EventArgs e)
        {
            //_pb.Location = new Point(_pb.Location.X + 20, _pb.Location.Y);
            //if (_pb.Location.X > _form.ClientSize.Width)
            //{
            //    _pb.Location = new Point(0 - _pb.Width, _pb.Location.Y);
            //}
            int x = PB.Location.X;
            if(x+PB.Width>=_form.ClientSize.Width)
            {
                _timer.Stop();
                if(Name != null) { Finsh(Name); }
            }
            else MoveForward();
        }

        public void Finsh(string name)
        {
            FinshRace?.Invoke(name);
        }
    
        internal void StartRace(object? sender, EventArgs e)
        {
            //MessageBox.Show("Start!!!");

            if (_timer != null && PB != null)
            {
                _timer.Stop();
                PB.Location = new Point(0, PB.Location.Y);
                _timer.Start();
            }
        }
    }
}
