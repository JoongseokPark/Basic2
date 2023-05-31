using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMove
{
    internal class bike : Vehicle
    {
        public bike(Form fm, string name)
        {
            Name = name;
            _form = fm;
            PB = MakePb();
            _form.Controls.Add(PB);
            fm.KeyDown += Fm_KeyDown;
        }

        protected override void MoveLeft()
        {
            MessageBox.Show("자전거 후진 불가");
        }

        public override PictureBox MakePb()
        {
            PictureBox pictureBox = new();
            pictureBox.Location = new Point(5, 5);
            pictureBox.Size = new Size(100, 75);
            pictureBox.Image = Image.FromFile("./image/bike.gif");

            return pictureBox;
        }
    }
}
