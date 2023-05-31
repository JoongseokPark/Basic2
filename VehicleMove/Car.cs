using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleMove
{
    internal class Car : Vehicle
    {
        public Car(Form fm, string name)
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
            pictureBox.Image = Image.FromFile("./image/car.gif");

            return pictureBox;
        }


    }
}
