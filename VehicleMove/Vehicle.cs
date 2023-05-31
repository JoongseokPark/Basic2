using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMove
{
    internal abstract class Vehicle : IMOVE
    {
        protected PictureBox? PB { get; set; }
        protected Form? _form;
        public int Speed { get; set; }
        internal string? Name { get; set; }

        public abstract PictureBox MakePb();

        protected virtual void MoveLeft()
        {
            if(PB != null) PB.Left = PB.Left - Speed;
        }
        protected void MoveRight()
        {
            if (PB != null) PB.Left = PB.Left + Speed;
        }
        protected void MoveUp()
        {
            if (PB != null) PB.Top = PB.Top - Speed;
        }
        protected void MoveDown()
        {
            if (PB != null) PB.Top = PB.Top + Speed;
        }
        protected void MoveLeftUp()
        {
            if (PB != null)
            {
                PB.Left -= Speed;
                PB.Top = PB.Top - Speed;
            }
        }
        protected void Fm_KeyDown(object? sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.KeyData);
            switch (e.KeyCode)
            {
                case Keys.Left:
                    MoveLeft();
                    break;
                case Keys.Right:
                    MoveRight();
                    break;
                case Keys.Up:
                    MoveUp();
                    break;
                case Keys.Down:
                    MoveDown();
                    break;
            }
        }
    }
}
