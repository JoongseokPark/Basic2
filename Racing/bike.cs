using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    internal class bike : Vehicle
    {
        public bike(Form fm, string name, int x, int y)
        {
            Name = name;
            _form = fm;
            PB = MakePb(x, y);
            _form.Controls.Add(PB);
            InitTimer();
        }


        protected override void MoveForward()
        {
            Random rnd = new Random();
            PB.Location = new Point(PB.Location.X + rnd.Next(10,13), PB.Location.Y);
        }

        public override PictureBox MakePb(int x, int y)
        {
            PictureBox pictureBox = new();
            pictureBox.Location = new Point(x, y);
            pictureBox.Size = new Size(100, 75);
            pictureBox.Image = Image.FromFile("./image/bike.gif");

            return pictureBox;
        }
    }
}
