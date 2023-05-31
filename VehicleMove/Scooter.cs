using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMove
{
    internal class Scooter : Vehicle
    {
        public Scooter(Form fm, string name, int x, int y)
        {
            Name = name;
            _form = fm;
            PB = MakePb();
            _form.Controls.Add(PB);
            fm.KeyDown += Fm_KeyDown;
        }
        


        public override PictureBox MakePb()
        {
            PictureBox pictureBox = new();
            pictureBox.Location = new Point(5, 5);
            pictureBox.Size = new Size(100, 75);
            pictureBox.Image = Image.FromFile("./image/scooter.gif");

            return pictureBox;
        }
    }
}
